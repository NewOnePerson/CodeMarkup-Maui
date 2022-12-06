﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class IShellContentGeneratedExtension
    {
        public static T MenuItems<T>(this T obj,
            Microsoft.Maui.Controls.MenuItemCollection menuItems)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.ShellContent>(obj);
            foreach (var item in menuItems) mauiObject.MenuItems.Add(item);
            return obj;
        }

        public static T MenuItems<T>(this T obj,
            params Microsoft.Maui.Controls.MenuItem[] menuItems)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.ShellContent>(obj);
            foreach (var item in menuItems) mauiObject.MenuItems.Add(item);
            return obj;
        }

        public static T MenuItems<T>(this T obj,
            Func<Def<Microsoft.Maui.Controls.MenuItemCollection>, Def<Microsoft.Maui.Controls.MenuItemCollection>> definition)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.ShellContent>(obj);
            var def = definition(new Def<Microsoft.Maui.Controls.MenuItemCollection>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) mauiObject.MenuItems.Add(item);
            }
            return obj;
        }
        
        public static T Content<T>(this T obj,
            object? content)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.ShellContent>(obj);
            if (content != null) mauiObject.Content = (object)content;
            return obj;
        }
        
        public static T Content<T>(this T obj,
            object? content,
            Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.ShellContent>(obj);
            if (content != null) mauiObject.Content = (object)content;
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.ShellContent.ContentProperty));
            if (def.ValueIsSet()) mauiObject.Content = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Content<T>(this T obj,
            Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.ShellContent>(obj);
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.ShellContent.ContentProperty));
            if (def.ValueIsSet()) mauiObject.Content = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ContentTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate? contentTemplate)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.ShellContent>(obj);
            if (contentTemplate != null) mauiObject.ContentTemplate = (Microsoft.Maui.Controls.DataTemplate)contentTemplate;
            return obj;
        }
        
        public static T ContentTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate? contentTemplate,
            Func<BindableDef<Microsoft.Maui.Controls.DataTemplate>, BindableDef<Microsoft.Maui.Controls.DataTemplate>> definition)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.ShellContent>(obj);
            if (contentTemplate != null) mauiObject.ContentTemplate = (Microsoft.Maui.Controls.DataTemplate)contentTemplate;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.DataTemplate>(mauiObject, Microsoft.Maui.Controls.ShellContent.ContentTemplateProperty));
            if (def.ValueIsSet()) mauiObject.ContentTemplate = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ContentTemplate<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Controls.DataTemplate>, BindableDef<Microsoft.Maui.Controls.DataTemplate>> definition)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.ShellContent>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.DataTemplate>(mauiObject, Microsoft.Maui.Controls.ShellContent.ContentTemplateProperty));
            if (def.ValueIsSet()) mauiObject.ContentTemplate = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ContentTemplate<T>(this T obj, Func<object> loadTemplate) where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.ShellContent>(obj);
            mauiObject.ContentTemplate = new Microsoft.Maui.Controls.DataTemplate(loadTemplate);
            return obj;
        }

        public static T ContentTemplate<T>(this T obj, Type type) where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.ShellContent>(obj);
            mauiObject.ContentTemplate = new Microsoft.Maui.Controls.DataTemplate(type);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
