﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class IShellItemGeneratedExtension
    {
        public static T CurrentItem<T>(this T obj,
            Microsoft.Maui.Controls.ShellSection? currentItem)
            where T : Sharp.UI.IShellItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.ShellItem>(obj);
            if (currentItem != null) mauiObject.CurrentItem = (Microsoft.Maui.Controls.ShellSection)currentItem;
            return obj;
        }
        
        public static T CurrentItem<T>(this T obj,
            Microsoft.Maui.Controls.ShellSection? currentItem,
            Func<BindableDef<Microsoft.Maui.Controls.ShellSection>, BindableDef<Microsoft.Maui.Controls.ShellSection>> definition)
            where T : Sharp.UI.IShellItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.ShellItem>(obj);
            if (currentItem != null) mauiObject.CurrentItem = (Microsoft.Maui.Controls.ShellSection)currentItem;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ShellSection>(mauiObject, Microsoft.Maui.Controls.ShellItem.CurrentItemProperty));
            if (def.ValueIsSet()) mauiObject.CurrentItem = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CurrentItem<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Controls.ShellSection>, BindableDef<Microsoft.Maui.Controls.ShellSection>> definition)
            where T : Sharp.UI.IShellItem
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.ShellItem>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.ShellSection>(mauiObject, Microsoft.Maui.Controls.ShellItem.CurrentItemProperty));
            if (def.ValueIsSet()) mauiObject.CurrentItem = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669