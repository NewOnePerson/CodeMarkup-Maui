﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ContentPageGeneratedExtension
    {
        public static T Content<T>(this T obj,
            Microsoft.Maui.Controls.View? content)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.View>(content);
            if (content != null) mauiObject.Content = mauiValue;
            return obj;
        }
        
        public static T Content<T>(this T obj,
            Microsoft.Maui.Controls.View? content,
            System.Func<BindableDef<Microsoft.Maui.Controls.View>, BindableDef<Microsoft.Maui.Controls.View>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.View>(content);
            if (content != null) mauiObject.Content = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.View>(mauiObject, Microsoft.Maui.Controls.ContentPage.ContentProperty));
            if (def.ValueIsSet()) mauiObject.Content = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.View>, BindableDef<Microsoft.Maui.Controls.View>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.View>(mauiObject, Microsoft.Maui.Controls.ContentPage.ContentProperty));
            if (def.ValueIsSet()) mauiObject.Content = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ShellPresentationMode<T>(this T obj,
            Microsoft.Maui.Controls.PresentationMode? presentationMode)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.PresentationMode>(presentationMode);
            if (presentationMode != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.PresentationModeProperty, mauiValue);
            return obj;
        }
        
        public static T ShellPresentationMode<T>(this T obj,
            Microsoft.Maui.Controls.PresentationMode? presentationMode,
            System.Func<BindableDef<Microsoft.Maui.Controls.PresentationMode>, BindableDef<Microsoft.Maui.Controls.PresentationMode>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.PresentationMode>(presentationMode);
            if (presentationMode != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.PresentationModeProperty, mauiValue);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.PresentationMode>(mauiObject, Microsoft.Maui.Controls.Shell.PresentationModeProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.PresentationModeProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellPresentationMode<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.PresentationMode>, BindableDef<Microsoft.Maui.Controls.PresentationMode>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.PresentationMode>(mauiObject, Microsoft.Maui.Controls.Shell.PresentationModeProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.PresentationModeProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellBackgroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? backgroundColor)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(backgroundColor);
            if (backgroundColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.BackgroundColorProperty, mauiValue);
            return obj;
        }
        
        public static T ShellBackgroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? backgroundColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(backgroundColor);
            if (backgroundColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.BackgroundColorProperty, mauiValue);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.BackgroundColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.BackgroundColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellBackgroundColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.BackgroundColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.BackgroundColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellForegroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? foregroundColor)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(foregroundColor);
            if (foregroundColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.ForegroundColorProperty, mauiValue);
            return obj;
        }
        
        public static T ShellForegroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? foregroundColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(foregroundColor);
            if (foregroundColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.ForegroundColorProperty, mauiValue);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.ForegroundColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.ForegroundColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellForegroundColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.ForegroundColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.ForegroundColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellTitleColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? titleColor)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(titleColor);
            if (titleColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleColorProperty, mauiValue);
            return obj;
        }
        
        public static T ShellTitleColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? titleColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(titleColor);
            if (titleColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleColorProperty, mauiValue);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.TitleColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellTitleColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.TitleColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellDisabledColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? disabledColor)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(disabledColor);
            if (disabledColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.DisabledColorProperty, mauiValue);
            return obj;
        }
        
        public static T ShellDisabledColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? disabledColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(disabledColor);
            if (disabledColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.DisabledColorProperty, mauiValue);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.DisabledColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.DisabledColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellDisabledColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.DisabledColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.DisabledColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellUnselectedColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? unselectedColor)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(unselectedColor);
            if (unselectedColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.UnselectedColorProperty, mauiValue);
            return obj;
        }
        
        public static T ShellUnselectedColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? unselectedColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(unselectedColor);
            if (unselectedColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.UnselectedColorProperty, mauiValue);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.UnselectedColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.UnselectedColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellUnselectedColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.UnselectedColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.UnselectedColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellNavBarHasShadow<T>(this T obj,
            bool? navBarHasShadow)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<bool>(navBarHasShadow);
            if (navBarHasShadow != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarHasShadowProperty, mauiValue);
            return obj;
        }
        
        public static T ShellNavBarHasShadow<T>(this T obj,
            bool? navBarHasShadow,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<bool>(navBarHasShadow);
            if (navBarHasShadow != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarHasShadowProperty, mauiValue);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Shell.NavBarHasShadowProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarHasShadowProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellNavBarHasShadow<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Shell.NavBarHasShadowProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarHasShadowProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellNavBarIsVisible<T>(this T obj,
            bool? navBarIsVisible)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<bool>(navBarIsVisible);
            if (navBarIsVisible != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarIsVisibleProperty, mauiValue);
            return obj;
        }
        
        public static T ShellNavBarIsVisible<T>(this T obj,
            bool? navBarIsVisible,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<bool>(navBarIsVisible);
            if (navBarIsVisible != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarIsVisibleProperty, mauiValue);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Shell.NavBarIsVisibleProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarIsVisibleProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellNavBarIsVisible<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Shell.NavBarIsVisibleProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarIsVisibleProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellTitleView<T>(this T obj,
            Microsoft.Maui.Controls.View? titleView)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.View>(titleView);
            if (titleView != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleViewProperty, mauiValue);
            return obj;
        }
        
        public static T ShellTitleView<T>(this T obj,
            Microsoft.Maui.Controls.View? titleView,
            System.Func<BindableDef<Microsoft.Maui.Controls.View>, BindableDef<Microsoft.Maui.Controls.View>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.View>(titleView);
            if (titleView != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleViewProperty, mauiValue);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.View>(mauiObject, Microsoft.Maui.Controls.Shell.TitleViewProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleViewProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellTitleView<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.View>, BindableDef<Microsoft.Maui.Controls.View>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.View>(mauiObject, Microsoft.Maui.Controls.Shell.TitleViewProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleViewProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
