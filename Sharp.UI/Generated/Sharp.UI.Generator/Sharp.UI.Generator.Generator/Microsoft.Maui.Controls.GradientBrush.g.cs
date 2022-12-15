﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class GradientBrushGeneratedExtension
    {
        public static T GradientStops<T>(this T obj,
            Microsoft.Maui.Controls.GradientStopCollection? gradientStops)
            where T : Sharp.UI.IGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GradientBrush>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.GradientStopCollection>(gradientStops);
            if (gradientStops != null) mauiObject.GradientStops = mauiValue;
            return obj;
        }
        
        public static T GradientStops<T>(this T obj,
            Microsoft.Maui.Controls.GradientStopCollection? gradientStops,
            System.Func<BindableDef<Microsoft.Maui.Controls.GradientStopCollection>, BindableDef<Microsoft.Maui.Controls.GradientStopCollection>> definition)
            where T : Sharp.UI.IGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GradientBrush>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.GradientStopCollection>(gradientStops);
            if (gradientStops != null) mauiObject.GradientStops = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.GradientStopCollection>(mauiObject, Microsoft.Maui.Controls.GradientBrush.GradientStopsProperty));
            if (def.ValueIsSet()) mauiObject.GradientStops = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T GradientStops<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.GradientStopCollection>, BindableDef<Microsoft.Maui.Controls.GradientStopCollection>> definition)
            where T : Sharp.UI.IGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GradientBrush>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.GradientStopCollection>(mauiObject, Microsoft.Maui.Controls.GradientBrush.GradientStopsProperty));
            if (def.ValueIsSet()) mauiObject.GradientStops = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnInvalidateGradientBrushRequested<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IGradientBrush
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.GradientBrush>(obj);
            mauiObject.InvalidateGradientBrushRequested += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
