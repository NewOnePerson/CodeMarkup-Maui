﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ShellContentGeneratedExtension
    {
        public static T MenuItems<T>(this T obj,
            Microsoft.Maui.Controls.MenuItemCollection menuItems)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ShellContent>(obj);
            foreach (var item in menuItems)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(item);
                mauiObject.MenuItems.Add(mauiItem);
            }
            return obj;
        }

        public static T MenuItems<T>(this T obj,
            params Microsoft.Maui.Controls.MenuItem[] menuItems)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ShellContent>(obj);
            foreach (var item in menuItems)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(item);
                mauiObject.MenuItems.Add(mauiItem);
            }
            return obj;
        }

        public static T MenuItems<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.MenuItemCollection>, LazyValueBuilder<Microsoft.Maui.Controls.MenuItemCollection>> buildValue)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ShellContent>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Controls.MenuItemCollection>());
            if (builder.ValueIsSet())
            {
                var items = builder.GetValue();
                foreach (var item in items) 
                {
                    var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(item);
                    mauiObject.MenuItems.Add(mauiItem);
                }
            }
            return obj;
        }
        
        public static T Content<T>(this T obj,
            object content)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ShellContent>(obj);
            mauiObject.Content = (object)content;
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ShellContent>(obj);
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) mauiObject.Content = builder.GetValue();
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<LazyValueBuilder<object>, LazyValueBuilder<object>> buildValue)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ShellContent>(obj);
            var builder = buildValue(new LazyValueBuilder<object>());
            if (builder.ValueIsSet()) mauiObject.Content = builder.GetValue();
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ShellContent>(obj);
            var builder = buildBinding(new BindingBuilder<object>(mauiObject, Microsoft.Maui.Controls.ShellContent.ContentProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ContentTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate contentTemplate)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ShellContent>(obj);
            mauiObject.ContentTemplate = (Microsoft.Maui.Controls.DataTemplate)contentTemplate;
            return obj;
        }
        
        public static T ContentTemplate<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.DataTemplate>, ValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buildValue)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ShellContent>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) mauiObject.ContentTemplate = builder.GetValue();
            return obj;
        }
        
        public static T ContentTemplate<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.DataTemplate>, LazyValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buildValue)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ShellContent>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) mauiObject.ContentTemplate = builder.GetValue();
            return obj;
        }
        
        public static T ContentTemplate<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.DataTemplate>, BindingBuilder<Microsoft.Maui.Controls.DataTemplate>> buildBinding)
            where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ShellContent>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.DataTemplate>(mauiObject, Microsoft.Maui.Controls.ShellContent.ContentTemplateProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T ContentTemplate<T>(this T obj, System.Func<object> loadTemplate) where T : Sharp.UI.IShellContent
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ShellContent>(obj);
            mauiObject.ContentTemplate = new Microsoft.Maui.Controls.DataTemplate(loadTemplate);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
