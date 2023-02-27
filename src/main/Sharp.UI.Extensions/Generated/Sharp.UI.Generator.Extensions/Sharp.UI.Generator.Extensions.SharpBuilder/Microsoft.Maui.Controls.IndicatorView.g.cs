﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class IndicatorViewExtension
    {
        public static T IndicatorsShape<T>(this T self,
            Microsoft.Maui.Controls.IndicatorShape indicatorsShape)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorsShapeProperty, indicatorsShape);
            return self;
        }
        
        public static T IndicatorsShape<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.IndicatorShape>, IPropertyBuilder<Microsoft.Maui.Controls.IndicatorShape>> configure)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.IndicatorShape>(self, Microsoft.Maui.Controls.IndicatorView.IndicatorsShapeProperty);
            configure(context).Build();
            return self;
        }
        
        public static T IndicatorLayout<T>(this T self,
            Microsoft.Maui.Controls.IBindableLayout indicatorLayout)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property IndicatorLayout");
            self.IndicatorLayout = indicatorLayout;
            return self;
        }
        
        public static T IndicatorLayout<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.IBindableLayout>, ValueBuilder<Microsoft.Maui.Controls.IBindableLayout>> buildValue)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property IndicatorLayout");
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.IBindableLayout>());
            if (builder.ValueIsSet()) self.IndicatorLayout = builder.GetValue();
            return self;
        }
        
        public static T Position<T>(this T self,
            int position)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.IndicatorView.PositionProperty, position);
            return self;
        }
        
        public static T Position<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var context = new PropertyContext<int>(self, Microsoft.Maui.Controls.IndicatorView.PositionProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Count<T>(this T self,
            int count)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.IndicatorView.CountProperty, count);
            return self;
        }
        
        public static T Count<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var context = new PropertyContext<int>(self, Microsoft.Maui.Controls.IndicatorView.CountProperty);
            configure(context).Build();
            return self;
        }
        
        public static T MaximumVisible<T>(this T self,
            int maximumVisible)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.IndicatorView.MaximumVisibleProperty, maximumVisible);
            return self;
        }
        
        public static T MaximumVisible<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var context = new PropertyContext<int>(self, Microsoft.Maui.Controls.IndicatorView.MaximumVisibleProperty);
            configure(context).Build();
            return self;
        }
        
        public static T IndicatorTemplate<T>(this T self,
            Microsoft.Maui.Controls.DataTemplate indicatorTemplate)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorTemplateProperty, indicatorTemplate);
            return self;
        }
        
        public static T IndicatorTemplate<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.DataTemplate>, IPropertyBuilder<Microsoft.Maui.Controls.DataTemplate>> configure)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.DataTemplate>(self, Microsoft.Maui.Controls.IndicatorView.IndicatorTemplateProperty);
            configure(context).Build();
            return self;
        }
        
        public static T IndicatorTemplate<T>(this T self, System.Func<object> loadTemplate)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorTemplateProperty, new DataTemplate(loadTemplate));
            return self;
        }
        
        public static T HideSingle<T>(this T self,
            bool hideSingle)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.IndicatorView.HideSingleProperty, hideSingle);
            return self;
        }
        
        public static T HideSingle<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.IndicatorView.HideSingleProperty);
            configure(context).Build();
            return self;
        }
        
        public static T IndicatorColor<T>(this T self,
            Microsoft.Maui.Graphics.Color indicatorColor)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorColorProperty, indicatorColor);
            return self;
        }
        
        public static T IndicatorColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.IndicatorView.IndicatorColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateIndicatorColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            Microsoft.Maui.Graphics.Color fromValue = self.IndicatorColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.IndicatorColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateIndicatorColorTo", transform, callback, length, easing);
        }
        
        public static T SelectedIndicatorColor<T>(this T self,
            Microsoft.Maui.Graphics.Color selectedIndicatorColor)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.IndicatorView.SelectedIndicatorColorProperty, selectedIndicatorColor);
            return self;
        }
        
        public static T SelectedIndicatorColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.IndicatorView.SelectedIndicatorColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateSelectedIndicatorColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            Microsoft.Maui.Graphics.Color fromValue = self.SelectedIndicatorColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.SelectedIndicatorColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateSelectedIndicatorColorTo", transform, callback, length, easing);
        }
        
        public static T IndicatorSize<T>(this T self,
            double indicatorSize)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.IndicatorView.IndicatorSizeProperty, indicatorSize);
            return self;
        }
        
        public static T IndicatorSize<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.IndicatorView.IndicatorSizeProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateIndicatorSizeTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            double fromValue = self.IndicatorSize;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.IndicatorSize = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateIndicatorSizeTo", transform, callback, length, easing);
        }
        
        public static T ItemsSource<T>(this T self,
            System.Collections.IEnumerable itemsSource)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.IndicatorView.ItemsSourceProperty, itemsSource);
            return self;
        }
        
        public static T ItemsSource<T>(this T self, Func<PropertyContext<System.Collections.IEnumerable>, IPropertyBuilder<System.Collections.IEnumerable>> configure)
            where T : Microsoft.Maui.Controls.IndicatorView
        {
            var context = new PropertyContext<System.Collections.IEnumerable>(self, Microsoft.Maui.Controls.IndicatorView.ItemsSourceProperty);
            configure(context).Build();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
