﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class IMenuItemGeneratedExtension
    {
        public static T Command<T>(this T obj,
            System.Windows.Input.ICommand? command)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            if (command != null) mauiObject.Command = (System.Windows.Input.ICommand)command;
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Windows.Input.ICommand? command,
            Func<BindableDef<System.Windows.Input.ICommand>, BindableDef<System.Windows.Input.ICommand>> definition)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            if (command != null) mauiObject.Command = (System.Windows.Input.ICommand)command;
            var def = definition(new BindableDef<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.MenuItem.CommandProperty));
            if (def.ValueIsSet()) mauiObject.Command = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Command<T>(this T obj,
            Func<BindableDef<System.Windows.Input.ICommand>, BindableDef<System.Windows.Input.ICommand>> definition)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            var def = definition(new BindableDef<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.MenuItem.CommandProperty));
            if (def.ValueIsSet()) mauiObject.Command = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            object? commandParameter)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            if (commandParameter != null) mauiObject.CommandParameter = (object)commandParameter;
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            object? commandParameter,
            Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            if (commandParameter != null) mauiObject.CommandParameter = (object)commandParameter;
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.MenuItem.CommandParameterProperty));
            if (def.ValueIsSet()) mauiObject.CommandParameter = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.MenuItem.CommandParameterProperty));
            if (def.ValueIsSet()) mauiObject.CommandParameter = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IconImageSource<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource? iconImageSource)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            if (iconImageSource != null) mauiObject.IconImageSource = (Microsoft.Maui.Controls.ImageSource)iconImageSource;
            return obj;
        }
        
        public static T IconImageSource<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource? iconImageSource,
            Func<BindableDef<Microsoft.Maui.Controls.ImageSource>, BindableDef<Microsoft.Maui.Controls.ImageSource>> definition)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            if (iconImageSource != null) mauiObject.IconImageSource = (Microsoft.Maui.Controls.ImageSource)iconImageSource;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ImageSource>(mauiObject, Microsoft.Maui.Controls.MenuItem.IconImageSourceProperty));
            if (def.ValueIsSet()) mauiObject.IconImageSource = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IconImageSource<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Controls.ImageSource>, BindableDef<Microsoft.Maui.Controls.ImageSource>> definition)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ImageSource>(mauiObject, Microsoft.Maui.Controls.MenuItem.IconImageSourceProperty));
            if (def.ValueIsSet()) mauiObject.IconImageSource = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsDestructive<T>(this T obj,
            bool? isDestructive)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            if (isDestructive != null) mauiObject.IsDestructive = (bool)isDestructive;
            return obj;
        }
        
        public static T IsDestructive<T>(this T obj,
            bool? isDestructive,
            Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            if (isDestructive != null) mauiObject.IsDestructive = (bool)isDestructive;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.MenuItem.IsDestructiveProperty));
            if (def.ValueIsSet()) mauiObject.IsDestructive = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsDestructive<T>(this T obj,
            Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.MenuItem.IsDestructiveProperty));
            if (def.ValueIsSet()) mauiObject.IsDestructive = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Text<T>(this T obj,
            string? text)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            if (text != null) mauiObject.Text = (string)text;
            return obj;
        }
        
        public static T Text<T>(this T obj,
            string? text,
            Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            if (text != null) mauiObject.Text = (string)text;
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.MenuItem.TextProperty));
            if (def.ValueIsSet()) mauiObject.Text = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Text<T>(this T obj,
            Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.MenuItem.TextProperty));
            if (def.ValueIsSet()) mauiObject.Text = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            bool? isEnabled)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            if (isEnabled != null) mauiObject.IsEnabled = (bool)isEnabled;
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            bool? isEnabled,
            Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            if (isEnabled != null) mauiObject.IsEnabled = (bool)isEnabled;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.MenuItem.IsEnabledProperty));
            if (def.ValueIsSet()) mauiObject.IsEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.MenuItem.IsEnabledProperty));
            if (def.ValueIsSet()) mauiObject.IsEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T StyleClass<T>(this T obj,
            System.Collections.Generic.IList<string>? styleClass)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            if (styleClass != null) mauiObject.StyleClass = (System.Collections.Generic.IList<string>)styleClass;
            return obj;
        }
        
        public static T StyleClass<T>(this T obj,
            System.Collections.Generic.IList<string>? styleClass,
            Func<ValueDef<System.Collections.Generic.IList<string>>, ValueDef<System.Collections.Generic.IList<string>>> definition)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            if (styleClass != null) mauiObject.StyleClass = (System.Collections.Generic.IList<string>)styleClass;
            var def = definition(new ValueDef<System.Collections.Generic.IList<string>>());
            if (def.ValueIsSet()) mauiObject.StyleClass = def.GetValue();
            return obj;
        }
        
        public static T StyleClass<T>(this T obj,
            Func<ValueDef<System.Collections.Generic.IList<string>>, ValueDef<System.Collections.Generic.IList<string>>> definition)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            var def = definition(new ValueDef<System.Collections.Generic.IList<string>>());
            if (def.ValueIsSet()) mauiObject.StyleClass = def.GetValue();
            return obj;
        }
        
        public static T @class<T>(this T obj,
            System.Collections.Generic.IList<string>? @class)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            if (@class != null) mauiObject.@class = (System.Collections.Generic.IList<string>)@class;
            return obj;
        }
        
        public static T @class<T>(this T obj,
            System.Collections.Generic.IList<string>? @class,
            Func<ValueDef<System.Collections.Generic.IList<string>>, ValueDef<System.Collections.Generic.IList<string>>> definition)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            if (@class != null) mauiObject.@class = (System.Collections.Generic.IList<string>)@class;
            var def = definition(new ValueDef<System.Collections.Generic.IList<string>>());
            if (def.ValueIsSet()) mauiObject.@class = def.GetValue();
            return obj;
        }
        
        public static T @class<T>(this T obj,
            Func<ValueDef<System.Collections.Generic.IList<string>>, ValueDef<System.Collections.Generic.IList<string>>> definition)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            var def = definition(new ValueDef<System.Collections.Generic.IList<string>>());
            if (def.ValueIsSet()) mauiObject.@class = def.GetValue();
            return obj;
        }
        
        public static T OnClicked<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MenuItem>(obj);
            mauiObject.Clicked += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669