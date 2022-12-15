﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class NavigationPageGeneratedExtension
    {
        public static T BarBackgroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? barBackgroundColor)
            where T : Sharp.UI.INavigationPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.NavigationPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(barBackgroundColor);
            if (barBackgroundColor != null) mauiObject.BarBackgroundColor = mauiValue;
            return obj;
        }
        
        public static T BarBackgroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? barBackgroundColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.INavigationPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.NavigationPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(barBackgroundColor);
            if (barBackgroundColor != null) mauiObject.BarBackgroundColor = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.NavigationPage.BarBackgroundColorProperty));
            if (def.ValueIsSet()) mauiObject.BarBackgroundColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BarBackgroundColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.INavigationPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.NavigationPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.NavigationPage.BarBackgroundColorProperty));
            if (def.ValueIsSet()) mauiObject.BarBackgroundColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BarBackground<T>(this T obj,
            Microsoft.Maui.Controls.Brush? barBackground)
            where T : Sharp.UI.INavigationPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.NavigationPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.Brush>(barBackground);
            if (barBackground != null) mauiObject.BarBackground = mauiValue;
            return obj;
        }
        
        public static T BarBackground<T>(this T obj,
            Microsoft.Maui.Controls.Brush? barBackground,
            System.Func<BindableDef<Microsoft.Maui.Controls.Brush>, BindableDef<Microsoft.Maui.Controls.Brush>> definition)
            where T : Sharp.UI.INavigationPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.NavigationPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.Brush>(barBackground);
            if (barBackground != null) mauiObject.BarBackground = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.Brush>(mauiObject, Microsoft.Maui.Controls.NavigationPage.BarBackgroundProperty));
            if (def.ValueIsSet()) mauiObject.BarBackground = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BarBackground<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.Brush>, BindableDef<Microsoft.Maui.Controls.Brush>> definition)
            where T : Sharp.UI.INavigationPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.NavigationPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.Brush>(mauiObject, Microsoft.Maui.Controls.NavigationPage.BarBackgroundProperty));
            if (def.ValueIsSet()) mauiObject.BarBackground = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BarTextColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? barTextColor)
            where T : Sharp.UI.INavigationPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.NavigationPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(barTextColor);
            if (barTextColor != null) mauiObject.BarTextColor = mauiValue;
            return obj;
        }
        
        public static T BarTextColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? barTextColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.INavigationPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.NavigationPage>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(barTextColor);
            if (barTextColor != null) mauiObject.BarTextColor = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.NavigationPage.BarTextColorProperty));
            if (def.ValueIsSet()) mauiObject.BarTextColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BarTextColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.INavigationPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.NavigationPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.NavigationPage.BarTextColorProperty));
            if (def.ValueIsSet()) mauiObject.BarTextColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnPopped<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.NavigationEventArgs> action)
            where T : Sharp.UI.INavigationPage
        {            
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.NavigationPage>(obj);
            mauiObject.Popped += (o, arg) => action(obj, arg);
            return obj;
        }
        
        public static T OnPoppedToRoot<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.NavigationEventArgs> action)
            where T : Sharp.UI.INavigationPage
        {            
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.NavigationPage>(obj);
            mauiObject.PoppedToRoot += (o, arg) => action(obj, arg);
            return obj;
        }
        
        public static T OnPushed<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.NavigationEventArgs> action)
            where T : Sharp.UI.INavigationPage
        {            
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.NavigationPage>(obj);
            mauiObject.Pushed += (o, arg) => action(obj, arg);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
