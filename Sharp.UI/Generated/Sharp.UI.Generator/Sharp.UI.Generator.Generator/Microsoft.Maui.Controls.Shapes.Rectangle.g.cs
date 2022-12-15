﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class RectangleGeneratedExtension
    {
        public static T RadiusX<T>(this T obj,
            double? radiusX)
            where T : Sharp.UI.IRectangle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.Rectangle>(obj);
            var mauiValue = MauiWrapper.Value<double>(radiusX);
            if (radiusX != null) mauiObject.RadiusX = mauiValue;
            return obj;
        }
        
        public static T RadiusX<T>(this T obj,
            double? radiusX,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IRectangle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.Rectangle>(obj);
            var mauiValue = MauiWrapper.Value<double>(radiusX);
            if (radiusX != null) mauiObject.RadiusX = mauiValue;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Shapes.Rectangle.RadiusXProperty));
            if (def.ValueIsSet()) mauiObject.RadiusX = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T RadiusX<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IRectangle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.Rectangle>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Shapes.Rectangle.RadiusXProperty));
            if (def.ValueIsSet()) mauiObject.RadiusX = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T RadiusY<T>(this T obj,
            double? radiusY)
            where T : Sharp.UI.IRectangle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.Rectangle>(obj);
            var mauiValue = MauiWrapper.Value<double>(radiusY);
            if (radiusY != null) mauiObject.RadiusY = mauiValue;
            return obj;
        }
        
        public static T RadiusY<T>(this T obj,
            double? radiusY,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IRectangle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.Rectangle>(obj);
            var mauiValue = MauiWrapper.Value<double>(radiusY);
            if (radiusY != null) mauiObject.RadiusY = mauiValue;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Shapes.Rectangle.RadiusYProperty));
            if (def.ValueIsSet()) mauiObject.RadiusY = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T RadiusY<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IRectangle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.Rectangle>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Shapes.Rectangle.RadiusYProperty));
            if (def.ValueIsSet()) mauiObject.RadiusY = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T @class<T>(this T obj,
            System.Collections.Generic.IList<string>? @class)
            where T : Sharp.UI.IRectangle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.Rectangle>(obj);
            var mauiValue = MauiWrapper.Value<System.Collections.Generic.IList<string>>(@class);
            if (@class != null) mauiObject.@class = mauiValue;
            return obj;
        }
        
        public static T @class<T>(this T obj,
            System.Collections.Generic.IList<string>? @class,
            System.Func<ValueDef<System.Collections.Generic.IList<string>>, ValueDef<System.Collections.Generic.IList<string>>> definition)
            where T : Sharp.UI.IRectangle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.Rectangle>(obj);
            var mauiValue = MauiWrapper.Value<System.Collections.Generic.IList<string>>(@class);
            if (@class != null) mauiObject.@class = mauiValue;
            var def = definition(new ValueDef<System.Collections.Generic.IList<string>>());
            if (def.ValueIsSet()) mauiObject.@class = def.GetValue();
            return obj;
        }
        
        public static T @class<T>(this T obj,
            System.Func<ValueDef<System.Collections.Generic.IList<string>>, ValueDef<System.Collections.Generic.IList<string>>> definition)
            where T : Sharp.UI.IRectangle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Shapes.Rectangle>(obj);
            var def = definition(new ValueDef<System.Collections.Generic.IList<string>>());
            if (def.ValueIsSet()) mauiObject.@class = def.GetValue();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
