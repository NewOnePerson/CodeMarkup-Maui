﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class LineSegmentExtension
    {
        public static T Point<T>(this T self,
            Microsoft.Maui.Graphics.Point point)
            where T : Microsoft.Maui.Controls.Shapes.LineSegment
        {
            self.SetValue(Microsoft.Maui.Controls.Shapes.LineSegment.PointProperty, point);
            return self;
        }
        
        public static T Point<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Point>, IPropertyBuilder<Microsoft.Maui.Graphics.Point>> configure)
            where T : Microsoft.Maui.Controls.Shapes.LineSegment
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Point>(self, Microsoft.Maui.Controls.Shapes.LineSegment.PointProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Point<T>(this SettersContext<T> self,
            Microsoft.Maui.Graphics.Point point)
            where T : Microsoft.Maui.Controls.Shapes.LineSegment
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.LineSegment.PointProperty, Value = point });
            return self;
        }
        
        public static SettersContext<T> Point<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Point>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Point>> configure)
            where T : Microsoft.Maui.Controls.Shapes.LineSegment
        {
            var context = new PropertySettersContext<Microsoft.Maui.Graphics.Point>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.LineSegment.PointProperty);
            configure(context).Build();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore