﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class VisualElementExtension
    {
        public static T VisualStateGroups<T>(this T self,
            Microsoft.Maui.Controls.VisualStateGroupList visualStateGroups)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.VisualStateManager.VisualStateGroupsProperty, visualStateGroups);
            return self;
        }
        
        public static T VisualStateGroups<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.VisualStateGroupList>, IPropertyBuilder<Microsoft.Maui.Controls.VisualStateGroupList>> configure)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.VisualStateGroupList>(self, Microsoft.Maui.Controls.VisualStateManager.VisualStateGroupsProperty);
            configure(context).Build();
            return self;
        }
        
        public static Microsoft.Maui.Controls.VisualStateGroupList GetVisualStateGroupsValue<T>(this T self)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            return (Microsoft.Maui.Controls.VisualStateGroupList)self.GetValue(Microsoft.Maui.Controls.VisualStateManager.VisualStateGroupsProperty);
        }
        
        public static T AutomationExcludedWithChildren<T>(this T self,
            bool? automationExcludedWithChildren)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.AutomationProperties.ExcludedWithChildrenProperty, automationExcludedWithChildren);
            return self;
        }
        
        public static T AutomationExcludedWithChildren<T>(this T self, Func<PropertyContext<bool?>, IPropertyBuilder<bool?>> configure)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            var context = new PropertyContext<bool?>(self, Microsoft.Maui.Controls.AutomationProperties.ExcludedWithChildrenProperty);
            configure(context).Build();
            return self;
        }
        
        public static bool? GetAutomationExcludedWithChildrenValue<T>(this T self)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            return (bool?)self.GetValue(Microsoft.Maui.Controls.AutomationProperties.ExcludedWithChildrenProperty);
        }
        
        public static T AutomationIsInAccessibleTree<T>(this T self,
            bool? automationIsInAccessibleTree)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.AutomationProperties.IsInAccessibleTreeProperty, automationIsInAccessibleTree);
            return self;
        }
        
        public static T AutomationIsInAccessibleTree<T>(this T self, Func<PropertyContext<bool?>, IPropertyBuilder<bool?>> configure)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            var context = new PropertyContext<bool?>(self, Microsoft.Maui.Controls.AutomationProperties.IsInAccessibleTreeProperty);
            configure(context).Build();
            return self;
        }
        
        public static bool? GetAutomationIsInAccessibleTreeValue<T>(this T self)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            return (bool?)self.GetValue(Microsoft.Maui.Controls.AutomationProperties.IsInAccessibleTreeProperty);
        }
        
        public static T AutomationName<T>(this T self,
            string automationName)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.AutomationProperties.NameProperty, automationName);
            return self;
        }
        
        public static T AutomationName<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.AutomationProperties.NameProperty);
            configure(context).Build();
            return self;
        }
        
        public static string GetAutomationNameValue<T>(this T self)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            return (string)self.GetValue(Microsoft.Maui.Controls.AutomationProperties.NameProperty);
        }
        
        public static T AutomationHelpText<T>(this T self,
            string automationHelpText)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.AutomationProperties.HelpTextProperty, automationHelpText);
            return self;
        }
        
        public static T AutomationHelpText<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.AutomationProperties.HelpTextProperty);
            configure(context).Build();
            return self;
        }
        
        public static string GetAutomationHelpTextValue<T>(this T self)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            return (string)self.GetValue(Microsoft.Maui.Controls.AutomationProperties.HelpTextProperty);
        }
        
        public static T AutomationLabeledBy<T>(this T self,
            Microsoft.Maui.Controls.VisualElement automationLabeledBy)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.AutomationProperties.LabeledByProperty, automationLabeledBy);
            return self;
        }
        
        public static T AutomationLabeledBy<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.VisualElement>, IPropertyBuilder<Microsoft.Maui.Controls.VisualElement>> configure)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.VisualElement>(self, Microsoft.Maui.Controls.AutomationProperties.LabeledByProperty);
            configure(context).Build();
            return self;
        }
        
        public static Microsoft.Maui.Controls.VisualElement GetAutomationLabeledByValue<T>(this T self)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            return (Microsoft.Maui.Controls.VisualElement)self.GetValue(Microsoft.Maui.Controls.AutomationProperties.LabeledByProperty);
        }
        
        public static T SemanticHint<T>(this T self,
            string semanticHint)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SemanticProperties.HintProperty, semanticHint);
            return self;
        }
        
        public static T SemanticHint<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.SemanticProperties.HintProperty);
            configure(context).Build();
            return self;
        }
        
        public static string GetSemanticHintValue<T>(this T self)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            return (string)self.GetValue(Microsoft.Maui.Controls.SemanticProperties.HintProperty);
        }
        
        public static T SemanticDescription<T>(this T self,
            string semanticDescription)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SemanticProperties.DescriptionProperty, semanticDescription);
            return self;
        }
        
        public static T SemanticDescription<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.SemanticProperties.DescriptionProperty);
            configure(context).Build();
            return self;
        }
        
        public static string GetSemanticDescriptionValue<T>(this T self)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            return (string)self.GetValue(Microsoft.Maui.Controls.SemanticProperties.DescriptionProperty);
        }
        
        public static T SemanticHeadingLevel<T>(this T self,
            Microsoft.Maui.SemanticHeadingLevel semanticHeadingLevel)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SemanticProperties.HeadingLevelProperty, semanticHeadingLevel);
            return self;
        }
        
        public static T SemanticHeadingLevel<T>(this T self, Func<PropertyContext<Microsoft.Maui.SemanticHeadingLevel>, IPropertyBuilder<Microsoft.Maui.SemanticHeadingLevel>> configure)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            var context = new PropertyContext<Microsoft.Maui.SemanticHeadingLevel>(self, Microsoft.Maui.Controls.SemanticProperties.HeadingLevelProperty);
            configure(context).Build();
            return self;
        }
        
        public static Microsoft.Maui.SemanticHeadingLevel GetSemanticHeadingLevelValue<T>(this T self)
            where T : Microsoft.Maui.Controls.VisualElement
        {
            return (Microsoft.Maui.SemanticHeadingLevel)self.GetValue(Microsoft.Maui.Controls.SemanticProperties.HeadingLevelProperty);
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
