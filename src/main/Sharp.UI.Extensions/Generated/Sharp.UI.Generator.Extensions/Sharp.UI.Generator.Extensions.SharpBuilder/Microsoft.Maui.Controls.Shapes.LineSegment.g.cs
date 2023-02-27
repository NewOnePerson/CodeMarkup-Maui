﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class LineSegmentExtension
    {
        public static T Point<T>(this T self,
            Microsoft.Maui.Graphics.Point point)
            where T : Microsoft.Maui.Controls.Shapes.LineSegment
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.LineSegment.PointProperty, point);
            return self;
        }
        
        public static T Point<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Point>, IPropertyBuilder<Microsoft.Maui.Graphics.Point>> configure)
            where T : Microsoft.Maui.Controls.Shapes.LineSegment
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Point>(self, Microsoft.Maui.Controls.Shapes.LineSegment.PointProperty);
            configure(context).Build();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
