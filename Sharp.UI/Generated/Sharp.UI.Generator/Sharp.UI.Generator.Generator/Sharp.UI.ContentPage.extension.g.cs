﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ContentPageGeneratedSharpObjectExtension
    {
        public static T ShellPresentationMode<T>(this T obj,
            Microsoft.Maui.Controls.PresentationMode presentationMode)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            mauiObject.SetValue(Microsoft.Maui.Controls.Shell.PresentationModeProperty, (Microsoft.Maui.Controls.PresentationMode)presentationMode);
            return obj;
        }
        
        public static T ShellPresentationMode<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.PresentationMode>, ValueBuilder<Microsoft.Maui.Controls.PresentationMode>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.PresentationMode>());
            if (builder.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.PresentationModeProperty, builder.GetValue());
            return obj;
        }
        
        public static T ShellPresentationMode<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.PresentationMode>, LazyValueBuilder<Microsoft.Maui.Controls.PresentationMode>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Controls.PresentationMode>());
            if (builder.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.PresentationModeProperty, builder.GetValue());
            return obj;
        }
        
        public static T ShellPresentationMode<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.PresentationMode>, BindingBuilder<Microsoft.Maui.Controls.PresentationMode>> buildBinding)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.PresentationMode>(mauiObject, Microsoft.Maui.Controls.Shell.PresentationModeProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ShellBackgroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color backgroundColor)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            mauiObject.SetValue(Microsoft.Maui.Controls.Shell.BackgroundColorProperty, (Microsoft.Maui.Graphics.Color)backgroundColor);
            return obj;
        }
        
        public static T ShellBackgroundColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.BackgroundColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T ShellBackgroundColor<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Graphics.Color>, LazyValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.BackgroundColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T ShellBackgroundColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.BackgroundColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ShellForegroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color foregroundColor)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            mauiObject.SetValue(Microsoft.Maui.Controls.Shell.ForegroundColorProperty, (Microsoft.Maui.Graphics.Color)foregroundColor);
            return obj;
        }
        
        public static T ShellForegroundColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.ForegroundColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T ShellForegroundColor<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Graphics.Color>, LazyValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.ForegroundColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T ShellForegroundColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.ForegroundColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ShellTitleColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color titleColor)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleColorProperty, (Microsoft.Maui.Graphics.Color)titleColor);
            return obj;
        }
        
        public static T ShellTitleColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T ShellTitleColor<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Graphics.Color>, LazyValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T ShellTitleColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.TitleColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ShellDisabledColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color disabledColor)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            mauiObject.SetValue(Microsoft.Maui.Controls.Shell.DisabledColorProperty, (Microsoft.Maui.Graphics.Color)disabledColor);
            return obj;
        }
        
        public static T ShellDisabledColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.DisabledColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T ShellDisabledColor<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Graphics.Color>, LazyValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.DisabledColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T ShellDisabledColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.DisabledColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ShellUnselectedColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color unselectedColor)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            mauiObject.SetValue(Microsoft.Maui.Controls.Shell.UnselectedColorProperty, (Microsoft.Maui.Graphics.Color)unselectedColor);
            return obj;
        }
        
        public static T ShellUnselectedColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.UnselectedColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T ShellUnselectedColor<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Graphics.Color>, LazyValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.UnselectedColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T ShellUnselectedColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.UnselectedColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ShellNavBarHasShadow<T>(this T obj,
            bool navBarHasShadow)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarHasShadowProperty, (bool)navBarHasShadow);
            return obj;
        }
        
        public static T ShellNavBarHasShadow<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarHasShadowProperty, builder.GetValue());
            return obj;
        }
        
        public static T ShellNavBarHasShadow<T>(this T obj,
            System.Func<LazyValueBuilder<bool>, LazyValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildValue(new LazyValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarHasShadowProperty, builder.GetValue());
            return obj;
        }
        
        public static T ShellNavBarHasShadow<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildBinding(new BindingBuilder<bool>(mauiObject, Microsoft.Maui.Controls.Shell.NavBarHasShadowProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ShellNavBarIsVisible<T>(this T obj,
            bool navBarIsVisible)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarIsVisibleProperty, (bool)navBarIsVisible);
            return obj;
        }
        
        public static T ShellNavBarIsVisible<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarIsVisibleProperty, builder.GetValue());
            return obj;
        }
        
        public static T ShellNavBarIsVisible<T>(this T obj,
            System.Func<LazyValueBuilder<bool>, LazyValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildValue(new LazyValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarIsVisibleProperty, builder.GetValue());
            return obj;
        }
        
        public static T ShellNavBarIsVisible<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildBinding(new BindingBuilder<bool>(mauiObject, Microsoft.Maui.Controls.Shell.NavBarIsVisibleProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ShellTitleView<T>(this T obj,
            Microsoft.Maui.Controls.View titleView)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleViewProperty, (Microsoft.Maui.Controls.View)titleView);
            return obj;
        }
        
        public static T ShellTitleView<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.View>, ValueBuilder<Microsoft.Maui.Controls.View>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.View>());
            if (builder.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleViewProperty, builder.GetValue());
            return obj;
        }
        
        public static T ShellTitleView<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.View>, LazyValueBuilder<Microsoft.Maui.Controls.View>> buildValue)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Controls.View>());
            if (builder.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleViewProperty, builder.GetValue());
            return obj;
        }
        
        public static T ShellTitleView<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.View>, BindingBuilder<Microsoft.Maui.Controls.View>> buildBinding)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.ContentPage>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.View>(mauiObject, Microsoft.Maui.Controls.Shell.TitleViewProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
