﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class SelectableItemsViewGeneratedExtension
    {
        public static T SelectedItem<T>(this T obj,
            object? selectedItem)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var mauiValue = MauiWrapper.Value<object>(selectedItem);
            if (selectedItem != null) mauiObject.SelectedItem = mauiValue;
            return obj;
        }
        
        public static T SelectedItem<T>(this T obj,
            object? selectedItem,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var mauiValue = MauiWrapper.Value<object>(selectedItem);
            if (selectedItem != null) mauiObject.SelectedItem = mauiValue;
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.SelectableItemsView.SelectedItemProperty));
            if (def.ValueIsSet()) mauiObject.SelectedItem = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectedItem<T>(this T obj,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.SelectableItemsView.SelectedItemProperty));
            if (def.ValueIsSet()) mauiObject.SelectedItem = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectedItems<T>(this T obj,
            System.Collections.Generic.IList<object>? selectedItems)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var mauiValue = MauiWrapper.Value<System.Collections.Generic.IList<object>>(selectedItems);
            if (selectedItems != null) mauiObject.SelectedItems = mauiValue;
            return obj;
        }
        
        public static T SelectedItems<T>(this T obj,
            System.Collections.Generic.IList<object>? selectedItems,
            System.Func<BindableDef<System.Collections.Generic.IList<object>>, BindableDef<System.Collections.Generic.IList<object>>> definition)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var mauiValue = MauiWrapper.Value<System.Collections.Generic.IList<object>>(selectedItems);
            if (selectedItems != null) mauiObject.SelectedItems = mauiValue;
            var def = definition(new BindableDef<System.Collections.Generic.IList<object>>(mauiObject, Microsoft.Maui.Controls.SelectableItemsView.SelectedItemsProperty));
            if (def.ValueIsSet()) mauiObject.SelectedItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectedItems<T>(this T obj,
            System.Func<BindableDef<System.Collections.Generic.IList<object>>, BindableDef<System.Collections.Generic.IList<object>>> definition)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var def = definition(new BindableDef<System.Collections.Generic.IList<object>>(mauiObject, Microsoft.Maui.Controls.SelectableItemsView.SelectedItemsProperty));
            if (def.ValueIsSet()) mauiObject.SelectedItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectionChangedCommand<T>(this T obj,
            System.Windows.Input.ICommand? selectionChangedCommand)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var mauiValue = MauiWrapper.Value<System.Windows.Input.ICommand>(selectionChangedCommand);
            if (selectionChangedCommand != null) mauiObject.SelectionChangedCommand = mauiValue;
            return obj;
        }
        
        public static T SelectionChangedCommand<T>(this T obj,
            System.Windows.Input.ICommand? selectionChangedCommand,
            System.Func<BindableDef<System.Windows.Input.ICommand>, BindableDef<System.Windows.Input.ICommand>> definition)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var mauiValue = MauiWrapper.Value<System.Windows.Input.ICommand>(selectionChangedCommand);
            if (selectionChangedCommand != null) mauiObject.SelectionChangedCommand = mauiValue;
            var def = definition(new BindableDef<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandProperty));
            if (def.ValueIsSet()) mauiObject.SelectionChangedCommand = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectionChangedCommand<T>(this T obj,
            System.Func<BindableDef<System.Windows.Input.ICommand>, BindableDef<System.Windows.Input.ICommand>> definition)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var def = definition(new BindableDef<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandProperty));
            if (def.ValueIsSet()) mauiObject.SelectionChangedCommand = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectionChangedCommandParameter<T>(this T obj,
            object? selectionChangedCommandParameter)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var mauiValue = MauiWrapper.Value<object>(selectionChangedCommandParameter);
            if (selectionChangedCommandParameter != null) mauiObject.SelectionChangedCommandParameter = mauiValue;
            return obj;
        }
        
        public static T SelectionChangedCommandParameter<T>(this T obj,
            object? selectionChangedCommandParameter,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var mauiValue = MauiWrapper.Value<object>(selectionChangedCommandParameter);
            if (selectionChangedCommandParameter != null) mauiObject.SelectionChangedCommandParameter = mauiValue;
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandParameterProperty));
            if (def.ValueIsSet()) mauiObject.SelectionChangedCommandParameter = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectionChangedCommandParameter<T>(this T obj,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandParameterProperty));
            if (def.ValueIsSet()) mauiObject.SelectionChangedCommandParameter = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectionMode<T>(this T obj,
            Microsoft.Maui.Controls.SelectionMode? selectionMode)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.SelectionMode>(selectionMode);
            if (selectionMode != null) mauiObject.SelectionMode = mauiValue;
            return obj;
        }
        
        public static T SelectionMode<T>(this T obj,
            Microsoft.Maui.Controls.SelectionMode? selectionMode,
            System.Func<BindableDef<Microsoft.Maui.Controls.SelectionMode>, BindableDef<Microsoft.Maui.Controls.SelectionMode>> definition)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.SelectionMode>(selectionMode);
            if (selectionMode != null) mauiObject.SelectionMode = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SelectionMode>(mauiObject, Microsoft.Maui.Controls.SelectableItemsView.SelectionModeProperty));
            if (def.ValueIsSet()) mauiObject.SelectionMode = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T SelectionMode<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.SelectionMode>, BindableDef<Microsoft.Maui.Controls.SelectionMode>> definition)
            where T : Sharp.UI.ISelectableItemsView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SelectionMode>(mauiObject, Microsoft.Maui.Controls.SelectableItemsView.SelectionModeProperty));
            if (def.ValueIsSet()) mauiObject.SelectionMode = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnSelectionChanged<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.SelectionChangedEventArgs> action)
            where T : Sharp.UI.ISelectableItemsView
        {            
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SelectableItemsView>(obj);
            mauiObject.SelectionChanged += (o, arg) => action(obj, arg);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
