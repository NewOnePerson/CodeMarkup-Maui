﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class SwitchCellGeneratedExtension
    {
        public static T OnColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? onColor)
            where T : Sharp.UI.ISwitchCell
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwitchCell>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(onColor);
            if (onColor != null) mauiObject.OnColor = mauiValue;
            return obj;
        }
        
        public static T OnColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? onColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ISwitchCell
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwitchCell>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(onColor);
            if (onColor != null) mauiObject.OnColor = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.SwitchCell.OnColorProperty));
            if (def.ValueIsSet()) mauiObject.OnColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ISwitchCell
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwitchCell>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.SwitchCell.OnColorProperty));
            if (def.ValueIsSet()) mauiObject.OnColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T On<T>(this T obj,
            bool? on)
            where T : Sharp.UI.ISwitchCell
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwitchCell>(obj);
            var mauiValue = MauiWrapper.Value<bool>(on);
            if (on != null) mauiObject.On = mauiValue;
            return obj;
        }
        
        public static T On<T>(this T obj,
            bool? on,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ISwitchCell
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwitchCell>(obj);
            var mauiValue = MauiWrapper.Value<bool>(on);
            if (on != null) mauiObject.On = mauiValue;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.SwitchCell.OnProperty));
            if (def.ValueIsSet()) mauiObject.On = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T On<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ISwitchCell
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwitchCell>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.SwitchCell.OnProperty));
            if (def.ValueIsSet()) mauiObject.On = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Text<T>(this T obj,
            string? text)
            where T : Sharp.UI.ISwitchCell
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwitchCell>(obj);
            var mauiValue = MauiWrapper.Value<string>(text);
            if (text != null) mauiObject.Text = mauiValue;
            return obj;
        }
        
        public static T Text<T>(this T obj,
            string? text,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.ISwitchCell
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwitchCell>(obj);
            var mauiValue = MauiWrapper.Value<string>(text);
            if (text != null) mauiObject.Text = mauiValue;
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.SwitchCell.TextProperty));
            if (def.ValueIsSet()) mauiObject.Text = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Text<T>(this T obj,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.ISwitchCell
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwitchCell>(obj);
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.SwitchCell.TextProperty));
            if (def.ValueIsSet()) mauiObject.Text = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnOnChanged<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.ToggledEventArgs> action)
            where T : Sharp.UI.ISwitchCell
        {            
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwitchCell>(obj);
            mauiObject.OnChanged += (o, arg) => action(obj, arg);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
