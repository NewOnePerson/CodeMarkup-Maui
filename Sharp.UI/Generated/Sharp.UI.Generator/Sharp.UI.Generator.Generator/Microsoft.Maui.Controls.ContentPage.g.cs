﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ContentPageGeneratedExtension
    {
        public static T Content<T>(this T obj,
            Microsoft.Maui.Controls.View content)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            mauiObject.Content = (Microsoft.Maui.Controls.View)content;
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.View>, ValueBuilder<Microsoft.Maui.Controls.View>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.View>());
            if (builder.ValueIsSet()) mauiObject.Content = builder.GetValue();
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.View>, LazyValueBuilder<Microsoft.Maui.Controls.View>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Controls.View>());
            if (builder.ValueIsSet()) mauiObject.Content = builder.GetValue();
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.View>, BindingBuilder<Microsoft.Maui.Controls.View>> buildBinding)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.View>(mauiObject, Microsoft.Maui.Controls.ContentPage.ContentProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
