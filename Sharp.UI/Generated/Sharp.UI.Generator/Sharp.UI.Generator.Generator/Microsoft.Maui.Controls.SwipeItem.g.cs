﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class SwipeItemGeneratedExtension
    {
        public static T BackgroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? backgroundColor)
            where T : Sharp.UI.ISwipeItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItem>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(backgroundColor);
            if (backgroundColor != null) mauiObject.BackgroundColor = mauiValue;
            return obj;
        }
        
        public static T BackgroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? backgroundColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ISwipeItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItem>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Graphics.Color>(backgroundColor);
            if (backgroundColor != null) mauiObject.BackgroundColor = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.SwipeItem.BackgroundColorProperty));
            if (def.ValueIsSet()) mauiObject.BackgroundColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BackgroundColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ISwipeItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItem>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.SwipeItem.BackgroundColorProperty));
            if (def.ValueIsSet()) mauiObject.BackgroundColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsVisible<T>(this T obj,
            bool? isVisible)
            where T : Sharp.UI.ISwipeItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItem>(obj);
            var mauiValue = MauiWrapper.Value<bool>(isVisible);
            if (isVisible != null) mauiObject.IsVisible = mauiValue;
            return obj;
        }
        
        public static T IsVisible<T>(this T obj,
            bool? isVisible,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ISwipeItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItem>(obj);
            var mauiValue = MauiWrapper.Value<bool>(isVisible);
            if (isVisible != null) mauiObject.IsVisible = mauiValue;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.SwipeItem.IsVisibleProperty));
            if (def.ValueIsSet()) mauiObject.IsVisible = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsVisible<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ISwipeItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItem>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.SwipeItem.IsVisibleProperty));
            if (def.ValueIsSet()) mauiObject.IsVisible = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnInvoked<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISwipeItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItem>(obj);
            mauiObject.Invoked += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
