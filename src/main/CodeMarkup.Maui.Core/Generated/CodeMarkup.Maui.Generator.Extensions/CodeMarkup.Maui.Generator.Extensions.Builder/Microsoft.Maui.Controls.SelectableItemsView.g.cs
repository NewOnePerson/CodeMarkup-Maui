﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class SelectableItemsViewExtension
    {
        public static T SelectedItem<T>(this T self,
            object selectedItem)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            self.SetValue(Microsoft.Maui.Controls.SelectableItemsView.SelectedItemProperty, selectedItem);
            return self;
        }
        
        public static T SelectedItem<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.SelectableItemsView.SelectedItemProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> SelectedItem<T>(this SettersContext<T> self,
            object selectedItem)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.SelectableItemsView.SelectedItemProperty, Value = selectedItem });
            return self;
        }
        
        public static SettersContext<T> SelectedItem<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            var context = new PropertySettersContext<object>(self.XamlSetters, Microsoft.Maui.Controls.SelectableItemsView.SelectedItemProperty);
            configure(context).Build();
            return self;
        }
        
        public static T SelectedItems<T>(this T self,
            IList<object> selectedItems)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            foreach (var item in selectedItems)
                self.SelectedItems.Add(item);
            return self;
        }

        public static T SelectedItems<T>(this T self,
            params object[] selectedItems)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            foreach (var item in selectedItems)
                self.SelectedItems.Add(item);
            return self;
        }
        
        public static T SelectedItems<T>(this T self, Func<PropertyContext<System.Collections.Generic.IList<object>>, IPropertyBuilder<System.Collections.Generic.IList<object>>> configure)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            var context = new PropertyContext<System.Collections.Generic.IList<object>>(self, Microsoft.Maui.Controls.SelectableItemsView.SelectedItemsProperty);
            configure(context).Build();
            return self;
        }
        
        public static T SelectionChangedCommand<T>(this T self,
            System.Windows.Input.ICommand selectionChangedCommand)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            self.SetValue(Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandProperty, selectionChangedCommand);
            return self;
        }
        
        public static T SelectionChangedCommand<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            var context = new PropertyContext<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> SelectionChangedCommand<T>(this SettersContext<T> self,
            System.Windows.Input.ICommand selectionChangedCommand)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandProperty, Value = selectionChangedCommand });
            return self;
        }
        
        public static SettersContext<T> SelectionChangedCommand<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandProperty);
            configure(context).Build();
            return self;
        }
        
        public static T SelectionChangedCommandParameter<T>(this T self,
            object selectionChangedCommandParameter)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            self.SetValue(Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandParameterProperty, selectionChangedCommandParameter);
            return self;
        }
        
        public static T SelectionChangedCommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandParameterProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> SelectionChangedCommandParameter<T>(this SettersContext<T> self,
            object selectionChangedCommandParameter)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandParameterProperty, Value = selectionChangedCommandParameter });
            return self;
        }
        
        public static SettersContext<T> SelectionChangedCommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            var context = new PropertySettersContext<object>(self.XamlSetters, Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandParameterProperty);
            configure(context).Build();
            return self;
        }
        
        public static T SelectionMode<T>(this T self,
            Microsoft.Maui.Controls.SelectionMode selectionMode)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            self.SetValue(Microsoft.Maui.Controls.SelectableItemsView.SelectionModeProperty, selectionMode);
            return self;
        }
        
        public static T SelectionMode<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.SelectionMode>, IPropertyBuilder<Microsoft.Maui.Controls.SelectionMode>> configure)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.SelectionMode>(self, Microsoft.Maui.Controls.SelectableItemsView.SelectionModeProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> SelectionMode<T>(this SettersContext<T> self,
            Microsoft.Maui.Controls.SelectionMode selectionMode)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.SelectableItemsView.SelectionModeProperty, Value = selectionMode });
            return self;
        }
        
        public static SettersContext<T> SelectionMode<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.SelectionMode>, IPropertySettersBuilder<Microsoft.Maui.Controls.SelectionMode>> configure)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            var context = new PropertySettersContext<Microsoft.Maui.Controls.SelectionMode>(self.XamlSetters, Microsoft.Maui.Controls.SelectableItemsView.SelectionModeProperty);
            configure(context).Build();
            return self;
        }
        
        public static T OnSelectionChanged<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.SelectionChangedEventArgs> handler)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            self.SelectionChanged += handler;
            return self;
        }
        
        public static T OnSelectionChanged<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            self.SelectionChanged += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore