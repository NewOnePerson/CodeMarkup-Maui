﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class SearchBarExtension
    {
        public static T CancelButtonColor<T>(this T self,
            Microsoft.Maui.Graphics.Color cancelButtonColor)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.CancelButtonColorProperty, cancelButtonColor);
            return self;
        }
        
        public static T CancelButtonColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.SearchBar.CancelButtonColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateCancelButtonColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            Microsoft.Maui.Graphics.Color fromValue = self.CancelButtonColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.CancelButtonColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateCancelButtonColorTo", transform, callback, length, easing);
        }
        
        public static T HorizontalTextAlignment<T>(this T self,
            Microsoft.Maui.TextAlignment horizontalTextAlignment)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.HorizontalTextAlignmentProperty, horizontalTextAlignment);
            return self;
        }
        
        public static T HorizontalTextAlignment<T>(this T self, Func<PropertyContext<Microsoft.Maui.TextAlignment>, IPropertyBuilder<Microsoft.Maui.TextAlignment>> configure)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            var context = new PropertyContext<Microsoft.Maui.TextAlignment>(self, Microsoft.Maui.Controls.SearchBar.HorizontalTextAlignmentProperty);
            configure(context).Build();
            return self;
        }
        
        public static T VerticalTextAlignment<T>(this T self,
            Microsoft.Maui.TextAlignment verticalTextAlignment)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.VerticalTextAlignmentProperty, verticalTextAlignment);
            return self;
        }
        
        public static T VerticalTextAlignment<T>(this T self, Func<PropertyContext<Microsoft.Maui.TextAlignment>, IPropertyBuilder<Microsoft.Maui.TextAlignment>> configure)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            var context = new PropertyContext<Microsoft.Maui.TextAlignment>(self, Microsoft.Maui.Controls.SearchBar.VerticalTextAlignmentProperty);
            configure(context).Build();
            return self;
        }
        
        public static T SearchCommand<T>(this T self,
            System.Windows.Input.ICommand searchCommand)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.SearchCommandProperty, searchCommand);
            return self;
        }
        
        public static T SearchCommand<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            var context = new PropertyContext<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.SearchBar.SearchCommandProperty);
            configure(context).Build();
            return self;
        }
        
        public static T SearchCommandParameter<T>(this T self,
            object searchCommandParameter)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.SearchCommandParameterProperty, searchCommandParameter);
            return self;
        }
        
        public static T SearchCommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.SearchBar.SearchCommandParameterProperty);
            configure(context).Build();
            return self;
        }
        
        public static T FontAttributes<T>(this T self,
            Microsoft.Maui.Controls.FontAttributes fontAttributes)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.FontAttributesProperty, fontAttributes);
            return self;
        }
        
        public static T FontAttributes<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.FontAttributes>, IPropertyBuilder<Microsoft.Maui.Controls.FontAttributes>> configure)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.FontAttributes>(self, Microsoft.Maui.Controls.SearchBar.FontAttributesProperty);
            configure(context).Build();
            return self;
        }
        
        public static T IsTextPredictionEnabled<T>(this T self,
            bool isTextPredictionEnabled)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.IsTextPredictionEnabledProperty, isTextPredictionEnabled);
            return self;
        }
        
        public static T IsTextPredictionEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.SearchBar.IsTextPredictionEnabledProperty);
            configure(context).Build();
            return self;
        }
        
        public static T CursorPosition<T>(this T self,
            int cursorPosition)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.CursorPositionProperty, cursorPosition);
            return self;
        }
        
        public static T CursorPosition<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            var context = new PropertyContext<int>(self, Microsoft.Maui.Controls.SearchBar.CursorPositionProperty);
            configure(context).Build();
            return self;
        }
        
        public static T SelectionLength<T>(this T self,
            int selectionLength)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.SelectionLengthProperty, selectionLength);
            return self;
        }
        
        public static T SelectionLength<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            var context = new PropertyContext<int>(self, Microsoft.Maui.Controls.SearchBar.SelectionLengthProperty);
            configure(context).Build();
            return self;
        }
        
        public static T FontFamily<T>(this T self,
            string fontFamily)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.FontFamilyProperty, fontFamily);
            return self;
        }
        
        public static T FontFamily<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.SearchBar.FontFamilyProperty);
            configure(context).Build();
            return self;
        }
        
        public static T FontSize<T>(this T self,
            double fontSize)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.FontSizeProperty, fontSize);
            return self;
        }
        
        public static T FontSize<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.SearchBar.FontSizeProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateFontSizeTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            double fromValue = self.FontSize;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.FontSize = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
        }
        
        public static T FontAutoScalingEnabled<T>(this T self,
            bool fontAutoScalingEnabled)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
            return self;
        }
        
        public static T FontAutoScalingEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.SearchBar.FontAutoScalingEnabledProperty);
            configure(context).Build();
            return self;
        }
        
        public static T OnSearchButtonPressed<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SearchButtonPressed += handler;
            return self;
        }
        
        public static T OnSearchButtonPressed<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SearchButtonPressed += (o, arg) => action(self);
            return self;
        }
        

        public static T TextCenterHorizontal<T>(this T self)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }

        public static T TextCenterVertical<T>(this T self)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.VerticalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }

        public static T TextCenter<T>(this T self)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Center);
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.VerticalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }

        public static T TextTop<T>(this T self)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.VerticalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextBottom<T>(this T self)
            where T : Microsoft.Maui.Controls.SearchBar, Microsoft.Maui.ITextAlignment
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.VerticalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        public static T TextTopStart<T>(this T self)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.VerticalTextAlignmentProperty, TextAlignment.Start);
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextBottomStart<T>(this T self)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.VerticalTextAlignmentProperty, TextAlignment.End);
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextTopEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.VerticalTextAlignmentProperty, TextAlignment.Start);
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        public static T TextBottomEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.VerticalTextAlignmentProperty, TextAlignment.End);
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        public static T TextStart<T>(this T self)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.SearchBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.SearchBar.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        
    }
}

#pragma warning restore CS8601
#nullable restore
