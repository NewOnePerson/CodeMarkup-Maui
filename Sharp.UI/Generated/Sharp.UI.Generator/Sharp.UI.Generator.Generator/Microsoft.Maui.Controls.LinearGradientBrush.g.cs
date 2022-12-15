﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class LinearGradientBrushGeneratedExtension
    {
        public static T StartPoint<T>(this T obj,
            Microsoft.Maui.Graphics.Point? startPoint)
            where T : Sharp.UI.ILinearGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.LinearGradientBrush>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Point>(startPoint);
            if (startPoint != null) mauiObject.StartPoint = mauiValue;
            return obj;
        }
        
        public static T StartPoint<T>(this T obj,
            Microsoft.Maui.Graphics.Point? startPoint,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Point>, BindableDef<Microsoft.Maui.Graphics.Point>> definition)
            where T : Sharp.UI.ILinearGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.LinearGradientBrush>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Point>(startPoint);
            if (startPoint != null) mauiObject.StartPoint = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.LinearGradientBrush.StartPointProperty));
            if (def.ValueIsSet()) mauiObject.StartPoint = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T StartPoint<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Point>, BindableDef<Microsoft.Maui.Graphics.Point>> definition)
            where T : Sharp.UI.ILinearGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.LinearGradientBrush>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.LinearGradientBrush.StartPointProperty));
            if (def.ValueIsSet()) mauiObject.StartPoint = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T EndPoint<T>(this T obj,
            Microsoft.Maui.Graphics.Point? endPoint)
            where T : Sharp.UI.ILinearGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.LinearGradientBrush>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Point>(endPoint);
            if (endPoint != null) mauiObject.EndPoint = mauiValue;
            return obj;
        }
        
        public static T EndPoint<T>(this T obj,
            Microsoft.Maui.Graphics.Point? endPoint,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Point>, BindableDef<Microsoft.Maui.Graphics.Point>> definition)
            where T : Sharp.UI.ILinearGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.LinearGradientBrush>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Point>(endPoint);
            if (endPoint != null) mauiObject.EndPoint = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.LinearGradientBrush.EndPointProperty));
            if (def.ValueIsSet()) mauiObject.EndPoint = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T EndPoint<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Point>, BindableDef<Microsoft.Maui.Graphics.Point>> definition)
            where T : Sharp.UI.ILinearGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.LinearGradientBrush>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Point>(mauiObject, Microsoft.Maui.Controls.LinearGradientBrush.EndPointProperty));
            if (def.ValueIsSet()) mauiObject.EndPoint = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
