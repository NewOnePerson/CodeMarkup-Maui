﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class SwitchGeneratedExtension
    {
        public static T OnColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color onColor)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Switch>(obj);
            mauiObject.OnColor = (Microsoft.Maui.Graphics.Color)onColor;
            return obj;
        }
        
        public static T OnColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Switch>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.OnColor = builder.GetValue();
            return obj;
        }
        
        public static T OnColor<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Graphics.Color>, LazyValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Switch>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.OnColor = builder.GetValue();
            return obj;
        }
        
        public static T OnColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Switch>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Switch.OnColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ThumbColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color thumbColor)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Switch>(obj);
            mauiObject.ThumbColor = (Microsoft.Maui.Graphics.Color)thumbColor;
            return obj;
        }
        
        public static T ThumbColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Switch>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.ThumbColor = builder.GetValue();
            return obj;
        }
        
        public static T ThumbColor<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Graphics.Color>, LazyValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Switch>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.ThumbColor = builder.GetValue();
            return obj;
        }
        
        public static T ThumbColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Switch>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Switch.ThumbColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsToggled<T>(this T obj,
            bool isToggled)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Switch>(obj);
            mauiObject.IsToggled = (bool)isToggled;
            return obj;
        }
        
        public static T IsToggled<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Switch>(obj);
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.IsToggled = builder.GetValue();
            return obj;
        }
        
        public static T IsToggled<T>(this T obj,
            System.Func<LazyValueBuilder<bool>, LazyValueBuilder<bool>> buildValue)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Switch>(obj);
            var builder = buildValue(new LazyValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.IsToggled = builder.GetValue();
            return obj;
        }
        
        public static T IsToggled<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Switch>(obj);
            var builder = buildBinding(new BindingBuilder<bool>(mauiObject, Microsoft.Maui.Controls.Switch.IsToggledProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnToggled<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ToggledEventArgs> handler)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Switch>(obj);
            mauiObject.Toggled += handler;
            return obj;
        }
        
        public static T OnToggled<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISwitch
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Switch>(obj);
            mauiObject.Toggled += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
