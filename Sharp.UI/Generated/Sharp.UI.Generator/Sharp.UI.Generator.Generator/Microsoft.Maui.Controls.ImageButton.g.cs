﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ImageButtonGeneratedExtension
    {
        public static T BorderColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? borderColor)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(borderColor);
            if (borderColor != null) mauiObject.BorderColor = mauiValue;
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? borderColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(borderColor);
            if (borderColor != null) mauiObject.BorderColor = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.ImageButton.BorderColorProperty));
            if (def.ValueIsSet()) mauiObject.BorderColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.ImageButton.BorderColorProperty));
            if (def.ValueIsSet()) mauiObject.BorderColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            int? cornerRadius)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var mauiValue = MauiWrapper.Value<int>(cornerRadius);
            if (cornerRadius != null) mauiObject.CornerRadius = mauiValue;
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            int? cornerRadius,
            System.Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var mauiValue = MauiWrapper.Value<int>(cornerRadius);
            if (cornerRadius != null) mauiObject.CornerRadius = mauiValue;
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.ImageButton.CornerRadiusProperty));
            if (def.ValueIsSet()) mauiObject.CornerRadius = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            System.Func<BindableDef<int>, BindableDef<int>> definition)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var def = definition(new BindableDef<int>(mauiObject, Microsoft.Maui.Controls.ImageButton.CornerRadiusProperty));
            if (def.ValueIsSet()) mauiObject.CornerRadius = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BorderWidth<T>(this T obj,
            double? borderWidth)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var mauiValue = MauiWrapper.Value<double>(borderWidth);
            if (borderWidth != null) mauiObject.BorderWidth = mauiValue;
            return obj;
        }
        
        public static T BorderWidth<T>(this T obj,
            double? borderWidth,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var mauiValue = MauiWrapper.Value<double>(borderWidth);
            if (borderWidth != null) mauiObject.BorderWidth = mauiValue;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.ImageButton.BorderWidthProperty));
            if (def.ValueIsSet()) mauiObject.BorderWidth = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BorderWidth<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.ImageButton.BorderWidthProperty));
            if (def.ValueIsSet()) mauiObject.BorderWidth = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Aspect<T>(this T obj,
            Microsoft.Maui.Aspect? aspect)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Aspect>(aspect);
            if (aspect != null) mauiObject.Aspect = mauiValue;
            return obj;
        }
        
        public static T Aspect<T>(this T obj,
            Microsoft.Maui.Aspect? aspect,
            System.Func<BindableDef<Microsoft.Maui.Aspect>, BindableDef<Microsoft.Maui.Aspect>> definition)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Aspect>(aspect);
            if (aspect != null) mauiObject.Aspect = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.Aspect>(mauiObject, Microsoft.Maui.Controls.ImageButton.AspectProperty));
            if (def.ValueIsSet()) mauiObject.Aspect = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Aspect<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Aspect>, BindableDef<Microsoft.Maui.Aspect>> definition)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Aspect>(mauiObject, Microsoft.Maui.Controls.ImageButton.AspectProperty));
            if (def.ValueIsSet()) mauiObject.Aspect = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsOpaque<T>(this T obj,
            bool? isOpaque)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var mauiValue = MauiWrapper.Value<bool>(isOpaque);
            if (isOpaque != null) mauiObject.IsOpaque = mauiValue;
            return obj;
        }
        
        public static T IsOpaque<T>(this T obj,
            bool? isOpaque,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var mauiValue = MauiWrapper.Value<bool>(isOpaque);
            if (isOpaque != null) mauiObject.IsOpaque = mauiValue;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.ImageButton.IsOpaqueProperty));
            if (def.ValueIsSet()) mauiObject.IsOpaque = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsOpaque<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.ImageButton.IsOpaqueProperty));
            if (def.ValueIsSet()) mauiObject.IsOpaque = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Windows.Input.ICommand? command)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var mauiValue = MauiWrapper.Value<System.Windows.Input.ICommand>(command);
            if (command != null) mauiObject.Command = mauiValue;
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Windows.Input.ICommand? command,
            System.Func<BindableDef<System.Windows.Input.ICommand>, BindableDef<System.Windows.Input.ICommand>> definition)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var mauiValue = MauiWrapper.Value<System.Windows.Input.ICommand>(command);
            if (command != null) mauiObject.Command = mauiValue;
            var def = definition(new BindableDef<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.ImageButton.CommandProperty));
            if (def.ValueIsSet()) mauiObject.Command = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<BindableDef<System.Windows.Input.ICommand>, BindableDef<System.Windows.Input.ICommand>> definition)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var def = definition(new BindableDef<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.ImageButton.CommandProperty));
            if (def.ValueIsSet()) mauiObject.Command = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            object? commandParameter)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var mauiValue = MauiWrapper.Value<object>(commandParameter);
            if (commandParameter != null) mauiObject.CommandParameter = mauiValue;
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            object? commandParameter,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var mauiValue = MauiWrapper.Value<object>(commandParameter);
            if (commandParameter != null) mauiObject.CommandParameter = mauiValue;
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.ImageButton.CommandParameterProperty));
            if (def.ValueIsSet()) mauiObject.CommandParameter = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.ImageButton.CommandParameterProperty));
            if (def.ValueIsSet()) mauiObject.CommandParameter = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Source<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource? source)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.ImageSource>(source);
            if (source != null) mauiObject.Source = mauiValue;
            return obj;
        }
        
        public static T Source<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource? source,
            System.Func<BindableDef<Microsoft.Maui.Controls.ImageSource>, BindableDef<Microsoft.Maui.Controls.ImageSource>> definition)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.ImageSource>(source);
            if (source != null) mauiObject.Source = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ImageSource>(mauiObject, Microsoft.Maui.Controls.ImageButton.SourceProperty));
            if (def.ValueIsSet()) mauiObject.Source = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Source<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.ImageSource>, BindableDef<Microsoft.Maui.Controls.ImageSource>> definition)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ImageSource>(mauiObject, Microsoft.Maui.Controls.ImageButton.SourceProperty));
            if (def.ValueIsSet()) mauiObject.Source = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            Microsoft.Maui.Thickness? padding)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Thickness>(padding);
            if (padding != null) mauiObject.Padding = mauiValue;
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            Microsoft.Maui.Thickness? padding,
            System.Func<BindableDef<Microsoft.Maui.Thickness>, BindableDef<Microsoft.Maui.Thickness>> definition)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Thickness>(padding);
            if (padding != null) mauiObject.Padding = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.Thickness>(mauiObject, Microsoft.Maui.Controls.ImageButton.PaddingProperty));
            if (def.ValueIsSet()) mauiObject.Padding = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Thickness>, BindableDef<Microsoft.Maui.Thickness>> definition)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Thickness>(mauiObject, Microsoft.Maui.Controls.ImageButton.PaddingProperty));
            if (def.ValueIsSet()) mauiObject.Padding = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnClicked<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            mauiObject.Clicked += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnPressed<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            mauiObject.Pressed += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnReleased<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IImageButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ImageButton>(obj);
            mauiObject.Released += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
