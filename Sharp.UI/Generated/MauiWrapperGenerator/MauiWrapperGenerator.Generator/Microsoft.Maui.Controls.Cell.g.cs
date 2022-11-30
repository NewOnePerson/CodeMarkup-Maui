﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ICellGeneratedExtension
    {
        public static T IsContextActionsLegacyModeEnabled<T>(this T obj,
            bool? isContextActionsLegacyModeEnabled)
            where T : Sharp.UI.ICell
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Cell>(obj);
            if (isContextActionsLegacyModeEnabled != null) mauiObject.IsContextActionsLegacyModeEnabled = (bool)isContextActionsLegacyModeEnabled;
            return obj;
        }
        
        public static T IsContextActionsLegacyModeEnabled<T>(this T obj,
            bool? isContextActionsLegacyModeEnabled,
            Func<ValueDef<bool>, ValueDef<bool>> definition)
            where T : Sharp.UI.ICell
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Cell>(obj);
            if (isContextActionsLegacyModeEnabled != null) mauiObject.IsContextActionsLegacyModeEnabled = (bool)isContextActionsLegacyModeEnabled;
            var def = definition(new ValueDef<bool>());
            if (def.ValueIsSet()) mauiObject.IsContextActionsLegacyModeEnabled = def.GetValue();
            return obj;
        }
        
        public static T IsContextActionsLegacyModeEnabled<T>(this T obj,
            Func<ValueDef<bool>, ValueDef<bool>> definition)
            where T : Sharp.UI.ICell
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Cell>(obj);
            var def = definition(new ValueDef<bool>());
            if (def.ValueIsSet()) mauiObject.IsContextActionsLegacyModeEnabled = def.GetValue();
            return obj;
        }
        
        public static T Height<T>(this T obj,
            double? height)
            where T : Sharp.UI.ICell
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Cell>(obj);
            if (height != null) mauiObject.Height = (double)height;
            return obj;
        }
        
        public static T Height<T>(this T obj,
            double? height,
            Func<ValueDef<double>, ValueDef<double>> definition)
            where T : Sharp.UI.ICell
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Cell>(obj);
            if (height != null) mauiObject.Height = (double)height;
            var def = definition(new ValueDef<double>());
            if (def.ValueIsSet()) mauiObject.Height = def.GetValue();
            return obj;
        }
        
        public static T Height<T>(this T obj,
            Func<ValueDef<double>, ValueDef<double>> definition)
            where T : Sharp.UI.ICell
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Cell>(obj);
            var def = definition(new ValueDef<double>());
            if (def.ValueIsSet()) mauiObject.Height = def.GetValue();
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            bool? isEnabled)
            where T : Sharp.UI.ICell
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Cell>(obj);
            if (isEnabled != null) mauiObject.IsEnabled = (bool)isEnabled;
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            bool? isEnabled,
            Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ICell
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Cell>(obj);
            if (isEnabled != null) mauiObject.IsEnabled = (bool)isEnabled;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Cell.IsEnabledProperty));
            if (def.ValueIsSet()) mauiObject.IsEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ICell
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Cell>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Cell.IsEnabledProperty));
            if (def.ValueIsSet()) mauiObject.IsEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnAppearing<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ICell
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Cell>(obj);
            mauiObject.Appearing += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnDisappearing<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ICell
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Cell>(obj);
            mauiObject.Disappearing += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnForceUpdateSizeRequested<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ICell
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Cell>(obj);
            mauiObject.ForceUpdateSizeRequested += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnTapped<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ICell
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Cell>(obj);
            mauiObject.Tapped += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669