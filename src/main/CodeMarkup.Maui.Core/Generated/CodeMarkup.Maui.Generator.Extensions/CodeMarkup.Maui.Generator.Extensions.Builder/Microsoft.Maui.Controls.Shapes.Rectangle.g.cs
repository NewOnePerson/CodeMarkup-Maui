﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class RectangleExtension
    {
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusX(this Microsoft.Maui.Controls.Shapes.Rectangle self,
            double radiusX)
        {
            self.SetValue(Microsoft.Maui.Controls.Shapes.Rectangle.RadiusXProperty, radiusX);
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusX(this Microsoft.Maui.Controls.Shapes.Rectangle self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        {
            var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.Rectangle.RadiusXProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.Shapes.Rectangle> RadiusX(this SettersContext<Microsoft.Maui.Controls.Shapes.Rectangle> self,
            double radiusX)
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.Rectangle.RadiusXProperty, Value = radiusX });
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.Shapes.Rectangle> RadiusX(this SettersContext<Microsoft.Maui.Controls.Shapes.Rectangle> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        {
            var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.Rectangle.RadiusXProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateRadiusXTo(this Microsoft.Maui.Controls.Shapes.Rectangle self, double value, uint length = 250, Easing? easing = null)
        {
            double fromValue = self.RadiusX;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.RadiusX = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateRadiusXTo", transform, callback, length, easing);
        }
        
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusY(this Microsoft.Maui.Controls.Shapes.Rectangle self,
            double radiusY)
        {
            self.SetValue(Microsoft.Maui.Controls.Shapes.Rectangle.RadiusYProperty, radiusY);
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusY(this Microsoft.Maui.Controls.Shapes.Rectangle self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        {
            var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.Rectangle.RadiusYProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.Shapes.Rectangle> RadiusY(this SettersContext<Microsoft.Maui.Controls.Shapes.Rectangle> self,
            double radiusY)
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.Rectangle.RadiusYProperty, Value = radiusY });
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.Shapes.Rectangle> RadiusY(this SettersContext<Microsoft.Maui.Controls.Shapes.Rectangle> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        {
            var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.Rectangle.RadiusYProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateRadiusYTo(this Microsoft.Maui.Controls.Shapes.Rectangle self, double value, uint length = 250, Easing? easing = null)
        {
            double fromValue = self.RadiusY;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.RadiusY = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateRadiusYTo", transform, callback, length, easing);
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
