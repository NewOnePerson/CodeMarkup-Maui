﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class PolygonExtension
    {
        public static Microsoft.Maui.Controls.Shapes.Polygon Points(this Microsoft.Maui.Controls.Shapes.Polygon self,
            IList<Microsoft.Maui.Graphics.Point> points)
        {
            foreach (var item in points)
                self.Points.Add(item);
            return self;
        }

        public static Microsoft.Maui.Controls.Shapes.Polygon Points(this Microsoft.Maui.Controls.Shapes.Polygon self,
            params Microsoft.Maui.Graphics.Point[] points)
        {
            foreach (var item in points)
                self.Points.Add(item);
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Polygon Points(this Microsoft.Maui.Controls.Shapes.Polygon self, Func<PropertyContext<Microsoft.Maui.Controls.PointCollection>, IPropertyBuilder<Microsoft.Maui.Controls.PointCollection>> configure)
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.PointCollection>(self, Microsoft.Maui.Controls.Shapes.Polygon.PointsProperty);
            configure(context).Build();
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Polygon FillRule(this Microsoft.Maui.Controls.Shapes.Polygon self,
            Microsoft.Maui.Controls.Shapes.FillRule fillRule)
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Polygon.FillRuleProperty, fillRule);
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Polygon FillRule(this Microsoft.Maui.Controls.Shapes.Polygon self, Func<PropertyContext<Microsoft.Maui.Controls.Shapes.FillRule>, IPropertyBuilder<Microsoft.Maui.Controls.Shapes.FillRule>> configure)
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.Shapes.FillRule>(self, Microsoft.Maui.Controls.Shapes.Polygon.FillRuleProperty);
            configure(context).Build();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
