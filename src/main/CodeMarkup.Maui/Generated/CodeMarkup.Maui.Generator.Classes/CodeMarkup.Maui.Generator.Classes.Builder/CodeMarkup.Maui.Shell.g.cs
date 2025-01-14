﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Classes.Builder
//

#nullable enable


using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;


namespace CodeMarkup.Maui
{
	using CodeMarkup.Maui;

    public partial class Shell : IList<Microsoft.Maui.Controls.ShellItem>
	{

        // ----- constructors -----

        public Shell() { }

        public Shell(out Shell shell) 
        {
            shell = this;
        }

        public Shell(System.Func<Shell, Shell> configure) 
        {
            configure(this);
        }

        public Shell(out Shell shell, System.Func<Shell, Shell> configure) 
        {
            shell = this;
            configure(this);
        }

        // ----- collection container -----

        public int Count => this.Items.Count;
        public Microsoft.Maui.Controls.ShellItem this[int index] { get => this.Items[index]; set => this.Items[index] = value; }
        public bool IsReadOnly => false;
        public void Clear() => this.Items.Clear();
        public bool Contains(Microsoft.Maui.Controls.ShellItem item) => this.Items.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.ShellItem[] array, int arrayIndex) => this.Items.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.ShellItem> GetEnumerator() => this.Items.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.ShellItem item) => this.Items.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.ShellItem item) => this.Items.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.ShellItem item) => this.Items.Remove(item);
        public void RemoveAt(int index) => this.Items.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.Items.GetEnumerator();
        public void Add(Microsoft.Maui.Controls.ShellItem item) => this.Items.Add(item);

    }
}

#nullable restore
