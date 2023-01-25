﻿using System.IO;
using System.Linq;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using MonoDevelop.Core;
using MonoDevelop.Utilities;
using System;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using MonoDevelop.Ide.Gui;
using MonoDevelop.Projects;
using System.IO.Pipes;
using MonoDevelop.Core.Assemblies;
using MonoDevelop.Projects.MSBuild;
using EnvDTE;
using Gtk;
using Microsoft.VisualStudio.OLE.Interop;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;
using MonoDevelop.Ide.TypeSystem;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Text;
using Pango;

namespace HotReload
{
    public class HotReloadData
    {
        public string[] TypeNames { get; set; }
        public byte[] AssemblyData { get; set; }
        public byte[] PdbData { get; set; }
    }

    public class StartupHandler : CommandHandler
	{
        static DateTime beginTime;
        static int asseblyVersion = 0;

        protected override void Run ()
		{
            IdeServices.ProjectOperations.BeforeStartProject += ProjectOperations_BeforeStartProject;
        }

        DotNetProject ActiveProject
            => (IdeApp.ProjectOperations.CurrentSelectedSolution?.StartupItem
                ?? IdeApp.ProjectOperations.CurrentSelectedBuildTarget)
                as DotNetProject;

        DotNetProject _hotReloadedProject = null;
        DotNetProject HotReloadedProject
        {
            get => _hotReloadedProject;
            set
            {
                if (_hotReloadedProject != null) _hotReloadedProject.FileChangedInProject -= ActiveProject_FileChangedInProject;
                _hotReloadedProject = value;
            }
        }

        void StartHotReloadSession()
        {
            if (ActiveProject != null && HotReloadedProject == null)
            {
                beginTime = DateTime.Now;
                HotReloadedProject = ActiveProject;                
                HotReloadedProject.FileChangedInProject += ActiveProject_FileChangedInProject;  
            }
        }

        void ProjectOperations_BeforeStartProject(object sender, EventArgs e)
        {
            StartHotReloadSession();
        }

        string GetClassNameWithNamespace(ClassDeclarationSyntax syntax)
        {
            var namespaceString =
                        (syntax.Parent as FileScopedNamespaceDeclarationSyntax)?.Name.ToString()
                        ?? (syntax.Parent as NamespaceDeclarationSyntax)?.Name.ToString();

            namespaceString = string.IsNullOrEmpty(namespaceString) ? "" : $"{namespaceString}.";

            return $"{namespaceString}{syntax.Identifier.Text}";
        }

        IEnumerable<string> GetClassNames(SyntaxTree syntaxTree)
        {
            return syntaxTree
                .GetRoot()
                .DescendantNodes().OfType<ClassDeclarationSyntax>()
                .Where(e => e.Parent is NamespaceDeclarationSyntax || e.Parent is FileScopedNamespaceDeclarationSyntax)
                .Select(e => GetClassNameWithNamespace(e));                
        }

        List<string> GetClassNamesForChangedSyntaxTrees(List<SyntaxTree> changedFilesSyntaxTreeList)
        {
            var classList = new List<string>();

            foreach (var syntaxTree in changedFilesSyntaxTreeList)
                classList.AddRange(GetClassNames(syntaxTree));

            return classList;
        }

        async Task CompileAndEmitChanges(string activeProjectName, IEnumerable<string> changedFilePaths)
        {
            try
            {
                asseblyVersion++;

                // ------ Microsoft.CodeAnalysis projects ------

                var typeService = await Runtime.GetService<TypeSystemService>();
                var solution = typeService.Workspace.CurrentSolution;
                var projects = solution.Projects;
                var activeProject = solution.Projects.FirstOrDefault(e => e.AssemblyName.Equals(activeProjectName));
                var referencedProjects = activeProject.ProjectReferences?.Select(e => solution.Projects.FirstOrDefault(x => x.Id == e.ProjectId));
                var generators = activeProject.AnalyzerReferences.SelectMany(e => e.GetGeneratorsForAllLanguages());
                var includedProjects = referencedProjects?.ToList() ?? new List<Microsoft.CodeAnalysis.Project>();
                includedProjects.Add(activeProject);

                var compilation = await activeProject?.GetCompilationAsync();

                // --------- syntax tree ----------

                List<SyntaxTree> syntaxTreeList = new List<SyntaxTree>();
                List<SyntaxTree> changedFilesSyntaxTreeList = new List<SyntaxTree>();

                // assembly name
                var versionSyntaxTree = CSharpSyntaxTree.ParseText($"[assembly: System.Reflection.AssemblyVersionAttribute(\"1.0.{asseblyVersion}\")]");

                // global usings
                var usings = compilation.SyntaxTrees
                        .SelectMany(e => e
                            .GetRoot()
                            .DescendantNodes().OfType<UsingDirectiveSyntax>()
                            .Where(e => e.GlobalKeyword.ValueText == "global"))
                        .Select(e => e.ToString())
                        .Distinct()
                        .ToList();
                var usingsText = string.Join("\n", usings);
                var usingsSyntaxTree = CSharpSyntaxTree.ParseText(usingsText);
                syntaxTreeList.Add(usingsSyntaxTree);

                // changed files
                foreach (var changedFilePath in changedFilePaths)
                {
                    var codeText = await File.ReadAllTextAsync(changedFilePath);
                    var syntaxTree = CSharpSyntaxTree.ParseText(codeText);
                    syntaxTreeList.Add(syntaxTree);
                    changedFilesSyntaxTreeList.Add(syntaxTree);                                       
                }

                // find changed names
                var changedClassNames = GetClassNamesForChangedSyntaxTrees(changedFilesSyntaxTreeList);

                // partial classes
                var partialSyntaxTrees = compilation.SyntaxTrees
                        .Where(e =>
                            !e.FilePath.EndsWith(".g.cs") &&
                            GetClassNames(e).Intersect(changedClassNames).Count() > 0 &&
                            !changedFilePaths.Contains(e.FilePath));
                syntaxTreeList.AddRange(partialSyntaxTrees);

                // --------- metadata reference ---------

                List<MetadataReference> metadataReferences = new List<MetadataReference>();
                metadataReferences.AddRange(includedProjects.Select(e => MetadataReference.CreateFromFile(e.OutputFilePath)));
                metadataReferences.AddRange(compilation.References);

                // --------- new compilation ------------

                var outputAssemblyName = $"{activeProjectName}-{asseblyVersion}";

                CSharpCompilation newCompilation =
                    CSharpCompilation.Create(outputAssemblyName, syntaxTreeList, metadataReferences,
                    new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

                var generatorDriver = CSharpGeneratorDriver.Create(generators);
                generatorDriver.RunGeneratorsAndUpdateCompilation(newCompilation, out var newCompilationWithGenetators, out var diagnostics);

#pragma warning disable CA1416
                using (NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", activeProjectName, PipeDirection.Out))
                {
                    // pipe connection
                    await pipeClient.ConnectAsync();
#pragma warning restore CA1416
                    var streamWriter = new StreamWriter(pipeClient);
                    streamWriter.AutoFlush = true;

                    using (var dllStream = new MemoryStream())
                    using (var pdbStream = new MemoryStream())
                    {
                        var emitResult = newCompilationWithGenetators.Emit(dllStream, pdbStream);
                        if (emitResult.Success)
                        {
                            var hotReloadData = new HotReloadData
                            {
                                TypeNames = changedClassNames.ToArray(),
                                AssemblyData = dllStream.GetBuffer(),
                                PdbData = pdbStream.GetBuffer()
                            };

                            var json = JsonSerializer.Serialize(hotReloadData);

                            // send file location
                            await streamWriter.WriteLineAsync(json);
                        }
                    }
                }
            }
#pragma warning disable CS0168
            catch (Exception ex)
            {

            }
#pragma warning restore CS0168
        }

        const double timeSpanBetweenCompilations = 2.0;
        static SemaphoreSlim semaphore = new SemaphoreSlim(1);
        async void ActiveProject_FileChangedInProject(object sender, ProjectFileEventArgs args)
        {
            if (IdeServices.ProjectOperations.CurrentRunOperation.IsCompleted) HotReloadedProject = null;

            var lapsedTime = DateTime.Now.Subtract(beginTime).TotalSeconds;
            if (HotReloadedProject is null || lapsedTime < timeSpanBetweenCompilations) return;

            await semaphore.WaitAsync();

            beginTime = DateTime.Now;

            var configuration = IdeApp.Workspace.ActiveConfiguration;
            var dllName = ActiveProject.GetOutputFileName(configuration).FileNameWithoutExtension;

            var changedFilePaths = args
                .Where(e => !e.ProjectFile.FilePath.FullPath.ToString().Contains(".g.cs"))
                .Select(e => e.ProjectFile.FilePath.FullPath.ToString());

            await CompileAndEmitChanges(dllName, changedFilePaths);

            semaphore.Release();
        }
	}
}
