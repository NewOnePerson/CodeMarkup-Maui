﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class StackLayoutGeneratedExtension
    {
        public static T Orientation<T>(this T obj,
            Microsoft.Maui.Controls.StackOrientation orientation)
            where T : Sharp.UI.IStackLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.StackLayout>(obj);
            mauiObject.Orientation = (Microsoft.Maui.Controls.StackOrientation)orientation;
            return obj;
        }
        
        public static T Orientation<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.StackOrientation>, ValueBuilder<Microsoft.Maui.Controls.StackOrientation>> buildValue)
            where T : Sharp.UI.IStackLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.StackLayout>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.StackOrientation>());
            if (builder.ValueIsSet()) mauiObject.Orientation = builder.GetValue();
            return obj;
        }
        
        public static T Orientation<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.StackOrientation>, LazyValueBuilder<Microsoft.Maui.Controls.StackOrientation>> buildValue)
            where T : Sharp.UI.IStackLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.StackLayout>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Controls.StackOrientation>());
            if (builder.ValueIsSet()) mauiObject.Orientation = builder.GetValue();
            return obj;
        }
        
        public static T Orientation<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.StackOrientation>, BindingBuilder<Microsoft.Maui.Controls.StackOrientation>> buildBinding)
            where T : Sharp.UI.IStackLayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.StackLayout>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.StackOrientation>(mauiObject, Microsoft.Maui.Controls.StackLayout.OrientationProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
