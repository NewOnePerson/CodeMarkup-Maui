﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class LabelExtension
    {
        public static T TextTransform<T>(this T self,
            Microsoft.Maui.TextTransform textTransform)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.TextTransformProperty, textTransform);
            return self;
        }
        
        public static T TextTransform<T>(this T self, Func<PropertyContext<Microsoft.Maui.TextTransform>, IPropertyBuilder<Microsoft.Maui.TextTransform>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertyContext<Microsoft.Maui.TextTransform>(self, Microsoft.Maui.Controls.Label.TextTransformProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> TextTransform<T>(this SettersContext<T> self,
            Microsoft.Maui.TextTransform textTransform)
            where T : Microsoft.Maui.Controls.Label
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Label.TextTransformProperty, Value = textTransform });
            return self;
        }
        
        public static SettersContext<T> TextTransform<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.TextTransform>, IPropertySettersBuilder<Microsoft.Maui.TextTransform>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertySettersContext<Microsoft.Maui.TextTransform>(self.XamlSetters, Microsoft.Maui.Controls.Label.TextTransformProperty);
            configure(context).Build();
            return self;
        }
        
        public static T FormattedText<T>(this T self,
            Microsoft.Maui.Controls.FormattedString formattedText)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.FormattedTextProperty, formattedText);
            return self;
        }
        
        public static T FormattedText<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.FormattedString>, IPropertyBuilder<Microsoft.Maui.Controls.FormattedString>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.FormattedString>(self, Microsoft.Maui.Controls.Label.FormattedTextProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> FormattedText<T>(this SettersContext<T> self,
            Microsoft.Maui.Controls.FormattedString formattedText)
            where T : Microsoft.Maui.Controls.Label
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Label.FormattedTextProperty, Value = formattedText });
            return self;
        }
        
        public static SettersContext<T> FormattedText<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.FormattedString>, IPropertySettersBuilder<Microsoft.Maui.Controls.FormattedString>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertySettersContext<Microsoft.Maui.Controls.FormattedString>(self.XamlSetters, Microsoft.Maui.Controls.Label.FormattedTextProperty);
            configure(context).Build();
            return self;
        }
        
        public static T HorizontalTextAlignment<T>(this T self,
            Microsoft.Maui.TextAlignment horizontalTextAlignment)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.HorizontalTextAlignmentProperty, horizontalTextAlignment);
            return self;
        }
        
        public static T HorizontalTextAlignment<T>(this T self, Func<PropertyContext<Microsoft.Maui.TextAlignment>, IPropertyBuilder<Microsoft.Maui.TextAlignment>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertyContext<Microsoft.Maui.TextAlignment>(self, Microsoft.Maui.Controls.Label.HorizontalTextAlignmentProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> HorizontalTextAlignment<T>(this SettersContext<T> self,
            Microsoft.Maui.TextAlignment horizontalTextAlignment)
            where T : Microsoft.Maui.Controls.Label
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Label.HorizontalTextAlignmentProperty, Value = horizontalTextAlignment });
            return self;
        }
        
        public static SettersContext<T> HorizontalTextAlignment<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.TextAlignment>, IPropertySettersBuilder<Microsoft.Maui.TextAlignment>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertySettersContext<Microsoft.Maui.TextAlignment>(self.XamlSetters, Microsoft.Maui.Controls.Label.HorizontalTextAlignmentProperty);
            configure(context).Build();
            return self;
        }
        
        public static T LineBreakMode<T>(this T self,
            Microsoft.Maui.LineBreakMode lineBreakMode)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.LineBreakModeProperty, lineBreakMode);
            return self;
        }
        
        public static T LineBreakMode<T>(this T self, Func<PropertyContext<Microsoft.Maui.LineBreakMode>, IPropertyBuilder<Microsoft.Maui.LineBreakMode>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertyContext<Microsoft.Maui.LineBreakMode>(self, Microsoft.Maui.Controls.Label.LineBreakModeProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> LineBreakMode<T>(this SettersContext<T> self,
            Microsoft.Maui.LineBreakMode lineBreakMode)
            where T : Microsoft.Maui.Controls.Label
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Label.LineBreakModeProperty, Value = lineBreakMode });
            return self;
        }
        
        public static SettersContext<T> LineBreakMode<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.LineBreakMode>, IPropertySettersBuilder<Microsoft.Maui.LineBreakMode>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertySettersContext<Microsoft.Maui.LineBreakMode>(self.XamlSetters, Microsoft.Maui.Controls.Label.LineBreakModeProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Text<T>(this T self,
            string text)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.TextProperty, text);
            return self;
        }
        
        public static T Text<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.Label.TextProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Text<T>(this SettersContext<T> self,
            string text)
            where T : Microsoft.Maui.Controls.Label
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Label.TextProperty, Value = text });
            return self;
        }
        
        public static SettersContext<T> Text<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.Label.TextProperty);
            configure(context).Build();
            return self;
        }
        
        public static T TextColor<T>(this T self,
            Microsoft.Maui.Graphics.Color textColor)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.TextColorProperty, textColor);
            return self;
        }
        
        public static T TextColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.Label.TextColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> TextColor<T>(this SettersContext<T> self,
            Microsoft.Maui.Graphics.Color textColor)
            where T : Microsoft.Maui.Controls.Label
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Label.TextColorProperty, Value = textColor });
            return self;
        }
        
        public static SettersContext<T> TextColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, Microsoft.Maui.Controls.Label.TextColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateTextColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Label
        {
            Microsoft.Maui.Graphics.Color fromValue = self.TextColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.TextColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateTextColorTo", transform, callback, length, easing);
        }
        
        public static T CharacterSpacing<T>(this T self,
            double characterSpacing)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.CharacterSpacingProperty, characterSpacing);
            return self;
        }
        
        public static T CharacterSpacing<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Label.CharacterSpacingProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self,
            double characterSpacing)
            where T : Microsoft.Maui.Controls.Label
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Label.CharacterSpacingProperty, Value = characterSpacing });
            return self;
        }
        
        public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Label.CharacterSpacingProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateCharacterSpacingTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Label
        {
            double fromValue = self.CharacterSpacing;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.CharacterSpacing = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateCharacterSpacingTo", transform, callback, length, easing);
        }
        
        public static T VerticalTextAlignment<T>(this T self,
            Microsoft.Maui.TextAlignment verticalTextAlignment)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.VerticalTextAlignmentProperty, verticalTextAlignment);
            return self;
        }
        
        public static T VerticalTextAlignment<T>(this T self, Func<PropertyContext<Microsoft.Maui.TextAlignment>, IPropertyBuilder<Microsoft.Maui.TextAlignment>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertyContext<Microsoft.Maui.TextAlignment>(self, Microsoft.Maui.Controls.Label.VerticalTextAlignmentProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> VerticalTextAlignment<T>(this SettersContext<T> self,
            Microsoft.Maui.TextAlignment verticalTextAlignment)
            where T : Microsoft.Maui.Controls.Label
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Label.VerticalTextAlignmentProperty, Value = verticalTextAlignment });
            return self;
        }
        
        public static SettersContext<T> VerticalTextAlignment<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.TextAlignment>, IPropertySettersBuilder<Microsoft.Maui.TextAlignment>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertySettersContext<Microsoft.Maui.TextAlignment>(self.XamlSetters, Microsoft.Maui.Controls.Label.VerticalTextAlignmentProperty);
            configure(context).Build();
            return self;
        }
        
        public static T FontAttributes<T>(this T self,
            Microsoft.Maui.Controls.FontAttributes fontAttributes)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.FontAttributesProperty, fontAttributes);
            return self;
        }
        
        public static T FontAttributes<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.FontAttributes>, IPropertyBuilder<Microsoft.Maui.Controls.FontAttributes>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.FontAttributes>(self, Microsoft.Maui.Controls.Label.FontAttributesProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self,
            Microsoft.Maui.Controls.FontAttributes fontAttributes)
            where T : Microsoft.Maui.Controls.Label
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Label.FontAttributesProperty, Value = fontAttributes });
            return self;
        }
        
        public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.FontAttributes>, IPropertySettersBuilder<Microsoft.Maui.Controls.FontAttributes>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertySettersContext<Microsoft.Maui.Controls.FontAttributes>(self.XamlSetters, Microsoft.Maui.Controls.Label.FontAttributesProperty);
            configure(context).Build();
            return self;
        }
        
        public static T TextDecorations<T>(this T self,
            Microsoft.Maui.TextDecorations textDecorations)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.TextDecorationsProperty, textDecorations);
            return self;
        }
        
        public static T TextDecorations<T>(this T self, Func<PropertyContext<Microsoft.Maui.TextDecorations>, IPropertyBuilder<Microsoft.Maui.TextDecorations>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertyContext<Microsoft.Maui.TextDecorations>(self, Microsoft.Maui.Controls.Label.TextDecorationsProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> TextDecorations<T>(this SettersContext<T> self,
            Microsoft.Maui.TextDecorations textDecorations)
            where T : Microsoft.Maui.Controls.Label
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Label.TextDecorationsProperty, Value = textDecorations });
            return self;
        }
        
        public static SettersContext<T> TextDecorations<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.TextDecorations>, IPropertySettersBuilder<Microsoft.Maui.TextDecorations>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertySettersContext<Microsoft.Maui.TextDecorations>(self.XamlSetters, Microsoft.Maui.Controls.Label.TextDecorationsProperty);
            configure(context).Build();
            return self;
        }
        
        public static T FontFamily<T>(this T self,
            string fontFamily)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.FontFamilyProperty, fontFamily);
            return self;
        }
        
        public static T FontFamily<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.Label.FontFamilyProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> FontFamily<T>(this SettersContext<T> self,
            string fontFamily)
            where T : Microsoft.Maui.Controls.Label
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Label.FontFamilyProperty, Value = fontFamily });
            return self;
        }
        
        public static SettersContext<T> FontFamily<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.Label.FontFamilyProperty);
            configure(context).Build();
            return self;
        }
        
        public static T FontSize<T>(this T self,
            double fontSize)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.FontSizeProperty, fontSize);
            return self;
        }
        
        public static T FontSize<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Label.FontSizeProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> FontSize<T>(this SettersContext<T> self,
            double fontSize)
            where T : Microsoft.Maui.Controls.Label
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Label.FontSizeProperty, Value = fontSize });
            return self;
        }
        
        public static SettersContext<T> FontSize<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Label.FontSizeProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateFontSizeTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Label
        {
            double fromValue = self.FontSize;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.FontSize = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
        }
        
        public static T FontAutoScalingEnabled<T>(this T self,
            bool fontAutoScalingEnabled)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
            return self;
        }
        
        public static T FontAutoScalingEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.Label.FontAutoScalingEnabledProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self,
            bool fontAutoScalingEnabled)
            where T : Microsoft.Maui.Controls.Label
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Label.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
            return self;
        }
        
        public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.Label.FontAutoScalingEnabledProperty);
            configure(context).Build();
            return self;
        }
        
        public static T LineHeight<T>(this T self,
            double lineHeight)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.LineHeightProperty, lineHeight);
            return self;
        }
        
        public static T LineHeight<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Label.LineHeightProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> LineHeight<T>(this SettersContext<T> self,
            double lineHeight)
            where T : Microsoft.Maui.Controls.Label
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Label.LineHeightProperty, Value = lineHeight });
            return self;
        }
        
        public static SettersContext<T> LineHeight<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Label.LineHeightProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateLineHeightTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Label
        {
            double fromValue = self.LineHeight;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.LineHeight = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateLineHeightTo", transform, callback, length, easing);
        }
        
        public static T MaxLines<T>(this T self,
            int maxLines)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.MaxLinesProperty, maxLines);
            return self;
        }
        
        public static T MaxLines<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertyContext<int>(self, Microsoft.Maui.Controls.Label.MaxLinesProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> MaxLines<T>(this SettersContext<T> self,
            int maxLines)
            where T : Microsoft.Maui.Controls.Label
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Label.MaxLinesProperty, Value = maxLines });
            return self;
        }
        
        public static SettersContext<T> MaxLines<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertySettersContext<int>(self.XamlSetters, Microsoft.Maui.Controls.Label.MaxLinesProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Padding<T>(this T self,
            Microsoft.Maui.Thickness padding)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.PaddingProperty, padding);
            return self;
        }
        
        public static T Padding<T>(this T self, Func<PropertyContext<Microsoft.Maui.Thickness>, IPropertyBuilder<Microsoft.Maui.Thickness>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertyContext<Microsoft.Maui.Thickness>(self, Microsoft.Maui.Controls.Label.PaddingProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Padding<T>(this SettersContext<T> self,
            Microsoft.Maui.Thickness padding)
            where T : Microsoft.Maui.Controls.Label
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Label.PaddingProperty, Value = padding });
            return self;
        }
        
        public static SettersContext<T> Padding<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Thickness>, IPropertySettersBuilder<Microsoft.Maui.Thickness>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertySettersContext<Microsoft.Maui.Thickness>(self.XamlSetters, Microsoft.Maui.Controls.Label.PaddingProperty);
            configure(context).Build();
            return self;
        }
        
        public static T TextType<T>(this T self,
            Microsoft.Maui.TextType textType)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.TextTypeProperty, textType);
            return self;
        }
        
        public static T TextType<T>(this T self, Func<PropertyContext<Microsoft.Maui.TextType>, IPropertyBuilder<Microsoft.Maui.TextType>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertyContext<Microsoft.Maui.TextType>(self, Microsoft.Maui.Controls.Label.TextTypeProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> TextType<T>(this SettersContext<T> self,
            Microsoft.Maui.TextType textType)
            where T : Microsoft.Maui.Controls.Label
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Label.TextTypeProperty, Value = textType });
            return self;
        }
        
        public static SettersContext<T> TextType<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.TextType>, IPropertySettersBuilder<Microsoft.Maui.TextType>> configure)
            where T : Microsoft.Maui.Controls.Label
        {
            var context = new PropertySettersContext<Microsoft.Maui.TextType>(self.XamlSetters, Microsoft.Maui.Controls.Label.TextTypeProperty);
            configure(context).Build();
            return self;
        }
        

        public static T TextCenterHorizontal<T>(this T self)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.HorizontalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }

        public static T TextCenterVertical<T>(this T self)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.VerticalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }

        public static T TextCenter<T>(this T self)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.HorizontalTextAlignmentProperty, TextAlignment.Center);
            self.SetValue(Microsoft.Maui.Controls.Label.VerticalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }

        public static T TextTop<T>(this T self)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.VerticalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextBottom<T>(this T self)
            where T : Microsoft.Maui.Controls.Label, Microsoft.Maui.ITextAlignment
        {
            self.SetValue(Microsoft.Maui.Controls.Label.VerticalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        public static T TextTopStart<T>(this T self)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.VerticalTextAlignmentProperty, TextAlignment.Start);
            self.SetValue(Microsoft.Maui.Controls.Label.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextBottomStart<T>(this T self)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.VerticalTextAlignmentProperty, TextAlignment.End);
            self.SetValue(Microsoft.Maui.Controls.Label.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextTopEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.VerticalTextAlignmentProperty, TextAlignment.Start);
            self.SetValue(Microsoft.Maui.Controls.Label.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        public static T TextBottomEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.VerticalTextAlignmentProperty, TextAlignment.End);
            self.SetValue(Microsoft.Maui.Controls.Label.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        public static T TextStart<T>(this T self)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.Label
        {
            self.SetValue(Microsoft.Maui.Controls.Label.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        
    }
}

#pragma warning restore CS8601
#nullable restore
