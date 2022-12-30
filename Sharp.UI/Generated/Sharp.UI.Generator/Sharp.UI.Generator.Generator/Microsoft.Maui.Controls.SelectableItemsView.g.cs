﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class SelectableItemsViewGeneratedExtension
    {
        public static T SelectedItem<T>(this T obj,
            object selectedItem)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            mauiObject.SelectedItem = (object)selectedItem;
            return obj;
        }
        
        public static T SelectedItem<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) mauiObject.SelectedItem = builder.GetValue();
            return obj;
        }
        
        public static T SelectedItem<T>(this T obj,
            System.Func<LazyValueBuilder<object>, LazyValueBuilder<object>> buildValue)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var builder = buildValue(new LazyValueBuilder<object>());
            if (builder.ValueIsSet()) mauiObject.SelectedItem = builder.GetValue();
            return obj;
        }
        
        public static T SelectedItem<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var builder = buildBinding(new BindingBuilder<object>(mauiObject, Microsoft.Maui.Controls.SelectableItemsView.SelectedItemProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T SelectedItems<T>(this T obj,
            System.Collections.Generic.IList<object> selectedItems)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            mauiObject.SelectedItems = (System.Collections.Generic.IList<object>)selectedItems;
            return obj;
        }
        
        public static T SelectedItems<T>(this T obj,
            System.Func<ValueBuilder<System.Collections.Generic.IList<object>>, ValueBuilder<System.Collections.Generic.IList<object>>> buildValue)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var builder = buildValue(new ValueBuilder<System.Collections.Generic.IList<object>>());
            if (builder.ValueIsSet()) mauiObject.SelectedItems = builder.GetValue();
            return obj;
        }
        
        public static T SelectedItems<T>(this T obj,
            System.Func<LazyValueBuilder<System.Collections.Generic.IList<object>>, LazyValueBuilder<System.Collections.Generic.IList<object>>> buildValue)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var builder = buildValue(new LazyValueBuilder<System.Collections.Generic.IList<object>>());
            if (builder.ValueIsSet()) mauiObject.SelectedItems = builder.GetValue();
            return obj;
        }
        
        public static T SelectedItems<T>(this T obj,
            System.Func<BindingBuilder<System.Collections.Generic.IList<object>>, BindingBuilder<System.Collections.Generic.IList<object>>> buildBinding)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var builder = buildBinding(new BindingBuilder<System.Collections.Generic.IList<object>>(mauiObject, Microsoft.Maui.Controls.SelectableItemsView.SelectedItemsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T SelectionChangedCommand<T>(this T obj,
            System.Windows.Input.ICommand selectionChangedCommand)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            mauiObject.SelectionChangedCommand = (System.Windows.Input.ICommand)selectionChangedCommand;
            return obj;
        }
        
        public static T SelectionChangedCommand<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var builder = buildValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) mauiObject.SelectionChangedCommand = builder.GetValue();
            return obj;
        }
        
        public static T SelectionChangedCommand<T>(this T obj,
            System.Func<LazyValueBuilder<System.Windows.Input.ICommand>, LazyValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var builder = buildValue(new LazyValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) mauiObject.SelectionChangedCommand = builder.GetValue();
            return obj;
        }
        
        public static T SelectionChangedCommand<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buildBinding)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var builder = buildBinding(new BindingBuilder<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T SelectionChangedCommandParameter<T>(this T obj,
            object selectionChangedCommandParameter)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            mauiObject.SelectionChangedCommandParameter = (object)selectionChangedCommandParameter;
            return obj;
        }
        
        public static T SelectionChangedCommandParameter<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) mauiObject.SelectionChangedCommandParameter = builder.GetValue();
            return obj;
        }
        
        public static T SelectionChangedCommandParameter<T>(this T obj,
            System.Func<LazyValueBuilder<object>, LazyValueBuilder<object>> buildValue)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var builder = buildValue(new LazyValueBuilder<object>());
            if (builder.ValueIsSet()) mauiObject.SelectionChangedCommandParameter = builder.GetValue();
            return obj;
        }
        
        public static T SelectionChangedCommandParameter<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var builder = buildBinding(new BindingBuilder<object>(mauiObject, Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandParameterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T SelectionMode<T>(this T obj,
            Microsoft.Maui.Controls.SelectionMode selectionMode)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            mauiObject.SelectionMode = (Microsoft.Maui.Controls.SelectionMode)selectionMode;
            return obj;
        }
        
        public static T SelectionMode<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.SelectionMode>, ValueBuilder<Microsoft.Maui.Controls.SelectionMode>> buildValue)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.SelectionMode>());
            if (builder.ValueIsSet()) mauiObject.SelectionMode = builder.GetValue();
            return obj;
        }
        
        public static T SelectionMode<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.SelectionMode>, LazyValueBuilder<Microsoft.Maui.Controls.SelectionMode>> buildValue)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Controls.SelectionMode>());
            if (builder.ValueIsSet()) mauiObject.SelectionMode = builder.GetValue();
            return obj;
        }
        
        public static T SelectionMode<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.SelectionMode>, BindingBuilder<Microsoft.Maui.Controls.SelectionMode>> buildBinding)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.SelectionMode>(mauiObject, Microsoft.Maui.Controls.SelectableItemsView.SelectionModeProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnSelectionChanged<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.SelectionChangedEventArgs> handler)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            mauiObject.SelectionChanged += handler;
            return obj;
        }
        
        public static T OnSelectionChanged<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            mauiObject.SelectionChanged += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
