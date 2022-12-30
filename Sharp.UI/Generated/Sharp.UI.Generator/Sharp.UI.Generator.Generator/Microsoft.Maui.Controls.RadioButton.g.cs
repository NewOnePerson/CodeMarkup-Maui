﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class RadioButtonGeneratedExtension
    {
        public static T Content<T>(this T obj,
            object content)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            mauiObject.Content = (object)content;
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) mauiObject.Content = builder.GetValue();
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<LazyValueBuilder<object>, LazyValueBuilder<object>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new LazyValueBuilder<object>());
            if (builder.ValueIsSet()) mauiObject.Content = builder.GetValue();
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildBinding(new BindingBuilder<object>(mauiObject, Microsoft.Maui.Controls.RadioButton.ContentProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Value<T>(this T obj,
            object value)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            mauiObject.Value = (object)value;
            return obj;
        }
        
        public static T Value<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) mauiObject.Value = builder.GetValue();
            return obj;
        }
        
        public static T Value<T>(this T obj,
            System.Func<LazyValueBuilder<object>, LazyValueBuilder<object>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new LazyValueBuilder<object>());
            if (builder.ValueIsSet()) mauiObject.Value = builder.GetValue();
            return obj;
        }
        
        public static T Value<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildBinding(new BindingBuilder<object>(mauiObject, Microsoft.Maui.Controls.RadioButton.ValueProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            bool isChecked)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            mauiObject.IsChecked = (bool)isChecked;
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.IsChecked = builder.GetValue();
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            System.Func<LazyValueBuilder<bool>, LazyValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new LazyValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.IsChecked = builder.GetValue();
            return obj;
        }
        
        public static T IsChecked<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildBinding(new BindingBuilder<bool>(mauiObject, Microsoft.Maui.Controls.RadioButton.IsCheckedProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T GroupName<T>(this T obj,
            string groupName)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            mauiObject.GroupName = (string)groupName;
            return obj;
        }
        
        public static T GroupName<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) mauiObject.GroupName = builder.GetValue();
            return obj;
        }
        
        public static T GroupName<T>(this T obj,
            System.Func<LazyValueBuilder<string>, LazyValueBuilder<string>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new LazyValueBuilder<string>());
            if (builder.ValueIsSet()) mauiObject.GroupName = builder.GetValue();
            return obj;
        }
        
        public static T GroupName<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildBinding(new BindingBuilder<string>(mauiObject, Microsoft.Maui.Controls.RadioButton.GroupNameProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color textColor)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            mauiObject.TextColor = (Microsoft.Maui.Graphics.Color)textColor;
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.TextColor = builder.GetValue();
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Graphics.Color>, LazyValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.TextColor = builder.GetValue();
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.RadioButton.TextColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            double characterSpacing)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            mauiObject.CharacterSpacing = (double)characterSpacing;
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) mauiObject.CharacterSpacing = builder.GetValue();
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            System.Func<LazyValueBuilder<double>, LazyValueBuilder<double>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new LazyValueBuilder<double>());
            if (builder.ValueIsSet()) mauiObject.CharacterSpacing = builder.GetValue();
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildBinding(new BindingBuilder<double>(mauiObject, Microsoft.Maui.Controls.RadioButton.CharacterSpacingProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T TextTransform<T>(this T obj,
            Microsoft.Maui.TextTransform textTransform)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            mauiObject.TextTransform = (Microsoft.Maui.TextTransform)textTransform;
            return obj;
        }
        
        public static T TextTransform<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.TextTransform>, ValueBuilder<Microsoft.Maui.TextTransform>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.TextTransform>());
            if (builder.ValueIsSet()) mauiObject.TextTransform = builder.GetValue();
            return obj;
        }
        
        public static T TextTransform<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.TextTransform>, LazyValueBuilder<Microsoft.Maui.TextTransform>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.TextTransform>());
            if (builder.ValueIsSet()) mauiObject.TextTransform = builder.GetValue();
            return obj;
        }
        
        public static T TextTransform<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.TextTransform>, BindingBuilder<Microsoft.Maui.TextTransform>> buildBinding)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.TextTransform>(mauiObject, Microsoft.Maui.Controls.RadioButton.TextTransformProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            Microsoft.Maui.Controls.FontAttributes fontAttributes)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            mauiObject.FontAttributes = (Microsoft.Maui.Controls.FontAttributes)fontAttributes;
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.FontAttributes>, ValueBuilder<Microsoft.Maui.Controls.FontAttributes>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.FontAttributes>());
            if (builder.ValueIsSet()) mauiObject.FontAttributes = builder.GetValue();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.FontAttributes>, LazyValueBuilder<Microsoft.Maui.Controls.FontAttributes>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Controls.FontAttributes>());
            if (builder.ValueIsSet()) mauiObject.FontAttributes = builder.GetValue();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.FontAttributes>, BindingBuilder<Microsoft.Maui.Controls.FontAttributes>> buildBinding)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.FontAttributes>(mauiObject, Microsoft.Maui.Controls.RadioButton.FontAttributesProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            string fontFamily)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            mauiObject.FontFamily = (string)fontFamily;
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) mauiObject.FontFamily = builder.GetValue();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            System.Func<LazyValueBuilder<string>, LazyValueBuilder<string>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new LazyValueBuilder<string>());
            if (builder.ValueIsSet()) mauiObject.FontFamily = builder.GetValue();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildBinding(new BindingBuilder<string>(mauiObject, Microsoft.Maui.Controls.RadioButton.FontFamilyProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            double fontSize)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            mauiObject.FontSize = (double)fontSize;
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) mauiObject.FontSize = builder.GetValue();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            System.Func<LazyValueBuilder<double>, LazyValueBuilder<double>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new LazyValueBuilder<double>());
            if (builder.ValueIsSet()) mauiObject.FontSize = builder.GetValue();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildBinding(new BindingBuilder<double>(mauiObject, Microsoft.Maui.Controls.RadioButton.FontSizeProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            bool fontAutoScalingEnabled)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            mauiObject.FontAutoScalingEnabled = (bool)fontAutoScalingEnabled;
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.FontAutoScalingEnabled = builder.GetValue();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            System.Func<LazyValueBuilder<bool>, LazyValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new LazyValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.FontAutoScalingEnabled = builder.GetValue();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildBinding(new BindingBuilder<bool>(mauiObject, Microsoft.Maui.Controls.RadioButton.FontAutoScalingEnabledProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T BorderWidth<T>(this T obj,
            double borderWidth)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            mauiObject.BorderWidth = (double)borderWidth;
            return obj;
        }
        
        public static T BorderWidth<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) mauiObject.BorderWidth = builder.GetValue();
            return obj;
        }
        
        public static T BorderWidth<T>(this T obj,
            System.Func<LazyValueBuilder<double>, LazyValueBuilder<double>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new LazyValueBuilder<double>());
            if (builder.ValueIsSet()) mauiObject.BorderWidth = builder.GetValue();
            return obj;
        }
        
        public static T BorderWidth<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildBinding(new BindingBuilder<double>(mauiObject, Microsoft.Maui.Controls.RadioButton.BorderWidthProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color borderColor)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            mauiObject.BorderColor = (Microsoft.Maui.Graphics.Color)borderColor;
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.BorderColor = builder.GetValue();
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Graphics.Color>, LazyValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.BorderColor = builder.GetValue();
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.RadioButton.BorderColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            int cornerRadius)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            mauiObject.CornerRadius = (int)cornerRadius;
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) mauiObject.CornerRadius = builder.GetValue();
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            System.Func<LazyValueBuilder<int>, LazyValueBuilder<int>> buildValue)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildValue(new LazyValueBuilder<int>());
            if (builder.ValueIsSet()) mauiObject.CornerRadius = builder.GetValue();
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buildBinding)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            var builder = buildBinding(new BindingBuilder<int>(mauiObject, Microsoft.Maui.Controls.RadioButton.CornerRadiusProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnCheckedChanged<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.CheckedChangedEventArgs> handler)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            mauiObject.CheckedChanged += handler;
            return obj;
        }
        
        public static T OnCheckedChanged<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IRadioButton
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RadioButton>(obj);
            mauiObject.CheckedChanged += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
