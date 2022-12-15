﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class StackBaseGeneratedExtension
    {
        public static T Spacing<T>(this T obj,
            double? spacing)
            where T : Sharp.UI.IStackBase
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.StackBase>(obj);
            var mauiValue = MauiWrapper.Value<double>(spacing);
            if (spacing != null) mauiObject.Spacing = mauiValue;
            return obj;
        }
        
        public static T Spacing<T>(this T obj,
            double? spacing,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IStackBase
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.StackBase>(obj);
            var mauiValue = MauiWrapper.Value<double>(spacing);
            if (spacing != null) mauiObject.Spacing = mauiValue;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.StackBase.SpacingProperty));
            if (def.ValueIsSet()) mauiObject.Spacing = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Spacing<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IStackBase
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.StackBase>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.StackBase.SpacingProperty));
            if (def.ValueIsSet()) mauiObject.Spacing = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
