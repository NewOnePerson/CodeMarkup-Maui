﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace ExampleApp
{
    using CodeMarkup.Maui.Internal;
    using CodeMarkup.Maui;
    
    public static partial class AngleViewModelExtension
    {
        public static T RawAngle<T>(this T self,
            double rawAngle)
            where T : ExampleApp.AngleViewModel
        {
            self.SetValue(ExampleApp.AngleViewModel.RawAngleProperty, rawAngle);
            return self;
        }
        
        public static T RawAngle<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
            where T : ExampleApp.AngleViewModel
        {
            var context = new PropertyContext<double>(self, ExampleApp.AngleViewModel.RawAngleProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> RawAngle<T>(this SettersContext<T> self,
            double rawAngle)
            where T : ExampleApp.AngleViewModel
        {
            self.XamlSetters.Add(new Setter { Property = ExampleApp.AngleViewModel.RawAngleProperty, Value = rawAngle });
            return self;
        }
        
        public static SettersContext<T> RawAngle<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
            where T : ExampleApp.AngleViewModel
        {
            var context = new PropertySettersContext<double>(self.XamlSetters, ExampleApp.AngleViewModel.RawAngleProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Angle<T>(this T self,
            double angle)
            where T : ExampleApp.AngleViewModel
        {
            self.SetValue(ExampleApp.AngleViewModel.AngleProperty, angle);
            return self;
        }
        
        public static T Angle<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
            where T : ExampleApp.AngleViewModel
        {
            var context = new PropertyContext<double>(self, ExampleApp.AngleViewModel.AngleProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Angle<T>(this SettersContext<T> self,
            double angle)
            where T : ExampleApp.AngleViewModel
        {
            self.XamlSetters.Add(new Setter { Property = ExampleApp.AngleViewModel.AngleProperty, Value = angle });
            return self;
        }
        
        public static SettersContext<T> Angle<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
            where T : ExampleApp.AngleViewModel
        {
            var context = new PropertySettersContext<double>(self.XamlSetters, ExampleApp.AngleViewModel.AngleProperty);
            configure(context).Build();
            return self;
        }
        
        public static T MaximumAngle<T>(this T self,
            double maximumAngle)
            where T : ExampleApp.AngleViewModel
        {
            self.SetValue(ExampleApp.AngleViewModel.MaximumAngleProperty, maximumAngle);
            return self;
        }
        
        public static T MaximumAngle<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
            where T : ExampleApp.AngleViewModel
        {
            var context = new PropertyContext<double>(self, ExampleApp.AngleViewModel.MaximumAngleProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> MaximumAngle<T>(this SettersContext<T> self,
            double maximumAngle)
            where T : ExampleApp.AngleViewModel
        {
            self.XamlSetters.Add(new Setter { Property = ExampleApp.AngleViewModel.MaximumAngleProperty, Value = maximumAngle });
            return self;
        }
        
        public static SettersContext<T> MaximumAngle<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
            where T : ExampleApp.AngleViewModel
        {
            var context = new PropertySettersContext<double>(self.XamlSetters, ExampleApp.AngleViewModel.MaximumAngleProperty);
            configure(context).Build();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
