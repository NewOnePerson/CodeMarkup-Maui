﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class LayoutGeneratedExtension
    {
        public static T Children<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.IView> children)
            where T : Sharp.UI.ILayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Layout>(obj);
            foreach (var item in children)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.IView>(item);
                mauiObject.Children.Add(mauiItem);
            }
            return obj;
        }

        public static T Children<T>(this T obj,
            params Microsoft.Maui.IView[] children)
            where T : Sharp.UI.ILayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Layout>(obj);
            foreach (var item in children)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.IView>(item);
                mauiObject.Children.Add(mauiItem);
            }
            return obj;
        }

        public static T Children<T>(this T obj,
            System.Func<Def<System.Collections.Generic.IList<Microsoft.Maui.IView>>, Def<System.Collections.Generic.IList<Microsoft.Maui.IView>>> definition)
            where T : Sharp.UI.ILayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Layout>(obj);
            var def = definition(new Def<System.Collections.Generic.IList<Microsoft.Maui.IView>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) 
                {
                    var mauiItem = MauiWrapper.Value<Microsoft.Maui.IView>(item);
                    mauiObject.Children.Add(mauiItem);
                }
            }
            return obj;
        }
        
        public static T IsClippedToBounds<T>(this T obj,
            bool? isClippedToBounds)
            where T : Sharp.UI.ILayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Layout>(obj);
            var mauiValue = MauiWrapper.Value<bool>(isClippedToBounds);
            if (isClippedToBounds != null) mauiObject.IsClippedToBounds = mauiValue;
            return obj;
        }
        
        public static T IsClippedToBounds<T>(this T obj,
            bool? isClippedToBounds,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ILayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Layout>(obj);
            var mauiValue = MauiWrapper.Value<bool>(isClippedToBounds);
            if (isClippedToBounds != null) mauiObject.IsClippedToBounds = mauiValue;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Layout.IsClippedToBoundsProperty));
            if (def.ValueIsSet()) mauiObject.IsClippedToBounds = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsClippedToBounds<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ILayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Layout>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Layout.IsClippedToBoundsProperty));
            if (def.ValueIsSet()) mauiObject.IsClippedToBounds = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            Microsoft.Maui.Thickness? padding)
            where T : Sharp.UI.ILayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Layout>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Thickness>(padding);
            if (padding != null) mauiObject.Padding = mauiValue;
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            Microsoft.Maui.Thickness? padding,
            System.Func<BindableDef<Microsoft.Maui.Thickness>, BindableDef<Microsoft.Maui.Thickness>> definition)
            where T : Sharp.UI.ILayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Layout>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Thickness>(padding);
            if (padding != null) mauiObject.Padding = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.Thickness>(mauiObject, Microsoft.Maui.Controls.Layout.PaddingProperty));
            if (def.ValueIsSet()) mauiObject.Padding = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Thickness>, BindableDef<Microsoft.Maui.Thickness>> definition)
            where T : Sharp.UI.ILayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Layout>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Thickness>(mauiObject, Microsoft.Maui.Controls.Layout.PaddingProperty));
            if (def.ValueIsSet()) mauiObject.Padding = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IgnoreSafeArea<T>(this T obj,
            bool? ignoreSafeArea)
            where T : Sharp.UI.ILayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Layout>(obj);
            var mauiValue = MauiWrapper.Value<bool>(ignoreSafeArea);
            if (ignoreSafeArea != null) mauiObject.IgnoreSafeArea = mauiValue;
            return obj;
        }
        
        public static T IgnoreSafeArea<T>(this T obj,
            bool? ignoreSafeArea,
            System.Func<ValueDef<bool>, ValueDef<bool>> definition)
            where T : Sharp.UI.ILayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Layout>(obj);
            var mauiValue = MauiWrapper.Value<bool>(ignoreSafeArea);
            if (ignoreSafeArea != null) mauiObject.IgnoreSafeArea = mauiValue;
            var def = definition(new ValueDef<bool>());
            if (def.ValueIsSet()) mauiObject.IgnoreSafeArea = def.GetValue();
            return obj;
        }
        
        public static T IgnoreSafeArea<T>(this T obj,
            System.Func<ValueDef<bool>, ValueDef<bool>> definition)
            where T : Sharp.UI.ILayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Layout>(obj);
            var def = definition(new ValueDef<bool>());
            if (def.ValueIsSet()) mauiObject.IgnoreSafeArea = def.GetValue();
            return obj;
        }
        
        public static T CascadeInputTransparent<T>(this T obj,
            bool? cascadeInputTransparent)
            where T : Sharp.UI.ILayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Layout>(obj);
            var mauiValue = MauiWrapper.Value<bool>(cascadeInputTransparent);
            if (cascadeInputTransparent != null) mauiObject.CascadeInputTransparent = mauiValue;
            return obj;
        }
        
        public static T CascadeInputTransparent<T>(this T obj,
            bool? cascadeInputTransparent,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ILayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Layout>(obj);
            var mauiValue = MauiWrapper.Value<bool>(cascadeInputTransparent);
            if (cascadeInputTransparent != null) mauiObject.CascadeInputTransparent = mauiValue;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Layout.CascadeInputTransparentProperty));
            if (def.ValueIsSet()) mauiObject.CascadeInputTransparent = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CascadeInputTransparent<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ILayout
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Layout>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Layout.CascadeInputTransparentProperty));
            if (def.ValueIsSet()) mauiObject.CascadeInputTransparent = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
