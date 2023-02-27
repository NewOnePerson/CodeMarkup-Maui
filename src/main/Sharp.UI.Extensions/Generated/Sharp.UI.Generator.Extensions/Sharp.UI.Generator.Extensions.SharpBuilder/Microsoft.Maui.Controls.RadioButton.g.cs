﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class RadioButtonExtension
    {
        public static T Content<T>(this T self,
            object content)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.RadioButton.ContentProperty, content);
            return self;
        }
        
        public static T Content<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.RadioButton.ContentProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Value<T>(this T self,
            object value)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.RadioButton.ValueProperty, value);
            return self;
        }
        
        public static T Value<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.RadioButton.ValueProperty);
            configure(context).Build();
            return self;
        }
        
        public static T IsChecked<T>(this T self,
            bool isChecked)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.RadioButton.IsCheckedProperty, isChecked);
            return self;
        }
        
        public static T IsChecked<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.RadioButton.IsCheckedProperty);
            configure(context).Build();
            return self;
        }
        
        public static T GroupName<T>(this T self,
            string groupName)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.RadioButton.GroupNameProperty, groupName);
            return self;
        }
        
        public static T GroupName<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.RadioButton.GroupNameProperty);
            configure(context).Build();
            return self;
        }
        
        public static T TextColor<T>(this T self,
            Microsoft.Maui.Graphics.Color textColor)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.RadioButton.TextColorProperty, textColor);
            return self;
        }
        
        public static T TextColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.RadioButton.TextColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateTextColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            Microsoft.Maui.Graphics.Color fromValue = self.TextColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.TextColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateTextColorTo", transform, callback, length, easing);
        }
        
        public static T CharacterSpacing<T>(this T self,
            double characterSpacing)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.RadioButton.CharacterSpacingProperty, characterSpacing);
            return self;
        }
        
        public static T CharacterSpacing<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.RadioButton.CharacterSpacingProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateCharacterSpacingTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            double fromValue = self.CharacterSpacing;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.CharacterSpacing = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateCharacterSpacingTo", transform, callback, length, easing);
        }
        
        public static T TextTransform<T>(this T self,
            Microsoft.Maui.TextTransform textTransform)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.RadioButton.TextTransformProperty, textTransform);
            return self;
        }
        
        public static T TextTransform<T>(this T self, Func<PropertyContext<Microsoft.Maui.TextTransform>, IPropertyBuilder<Microsoft.Maui.TextTransform>> configure)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var context = new PropertyContext<Microsoft.Maui.TextTransform>(self, Microsoft.Maui.Controls.RadioButton.TextTransformProperty);
            configure(context).Build();
            return self;
        }
        
        public static T FontAttributes<T>(this T self,
            Microsoft.Maui.Controls.FontAttributes fontAttributes)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.RadioButton.FontAttributesProperty, fontAttributes);
            return self;
        }
        
        public static T FontAttributes<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.FontAttributes>, IPropertyBuilder<Microsoft.Maui.Controls.FontAttributes>> configure)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.FontAttributes>(self, Microsoft.Maui.Controls.RadioButton.FontAttributesProperty);
            configure(context).Build();
            return self;
        }
        
        public static T FontFamily<T>(this T self,
            string fontFamily)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.RadioButton.FontFamilyProperty, fontFamily);
            return self;
        }
        
        public static T FontFamily<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.RadioButton.FontFamilyProperty);
            configure(context).Build();
            return self;
        }
        
        public static T FontSize<T>(this T self,
            double fontSize)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.RadioButton.FontSizeProperty, fontSize);
            return self;
        }
        
        public static T FontSize<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.RadioButton.FontSizeProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateFontSizeTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            double fromValue = self.FontSize;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.FontSize = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
        }
        
        public static T FontAutoScalingEnabled<T>(this T self,
            bool fontAutoScalingEnabled)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.RadioButton.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
            return self;
        }
        
        public static T FontAutoScalingEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.RadioButton.FontAutoScalingEnabledProperty);
            configure(context).Build();
            return self;
        }
        
        public static T BorderWidth<T>(this T self,
            double borderWidth)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.RadioButton.BorderWidthProperty, borderWidth);
            return self;
        }
        
        public static T BorderWidth<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.RadioButton.BorderWidthProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateBorderWidthTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            double fromValue = self.BorderWidth;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.BorderWidth = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateBorderWidthTo", transform, callback, length, easing);
        }
        
        public static T BorderColor<T>(this T self,
            Microsoft.Maui.Graphics.Color borderColor)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.RadioButton.BorderColorProperty, borderColor);
            return self;
        }
        
        public static T BorderColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.RadioButton.BorderColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateBorderColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            Microsoft.Maui.Graphics.Color fromValue = self.BorderColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.BorderColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateBorderColorTo", transform, callback, length, easing);
        }
        
        public static T CornerRadius<T>(this T self,
            int cornerRadius)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.RadioButton.CornerRadiusProperty, cornerRadius);
            return self;
        }
        
        public static T CornerRadius<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            var context = new PropertyContext<int>(self, Microsoft.Maui.Controls.RadioButton.CornerRadiusProperty);
            configure(context).Build();
            return self;
        }
        
        public static T OnCheckedChanged<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.CheckedChangedEventArgs> handler)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            self.CheckedChanged += handler;
            return self;
        }
        
        public static T OnCheckedChanged<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.RadioButton
        {
            self.CheckedChanged += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
