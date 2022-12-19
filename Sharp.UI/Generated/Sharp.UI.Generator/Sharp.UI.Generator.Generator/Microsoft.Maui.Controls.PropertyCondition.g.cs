﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class PropertyConditionGeneratedExtension
    {
        public static T Property<T>(this T obj,
            Microsoft.Maui.Controls.BindableProperty? property)
            where T : Sharp.UI.IPropertyCondition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.PropertyCondition>(obj);
            if (property != null) mauiObject.Property = (Microsoft.Maui.Controls.BindableProperty)property;
            return obj;
        }
        
        public static T Property<T>(this T obj,
            Microsoft.Maui.Controls.BindableProperty? property,
            System.Func<ValueDef<Microsoft.Maui.Controls.BindableProperty>, ValueDef<Microsoft.Maui.Controls.BindableProperty>> definition)
            where T : Sharp.UI.IPropertyCondition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.PropertyCondition>(obj);
            if (property != null) mauiObject.Property = (Microsoft.Maui.Controls.BindableProperty)property;
            var def = definition(new ValueDef<Microsoft.Maui.Controls.BindableProperty>());
            if (def.ValueIsSet()) mauiObject.Property = def.GetValue();
            return obj;
        }
        
        public static T Property<T>(this T obj,
            System.Func<ValueDef<Microsoft.Maui.Controls.BindableProperty>, ValueDef<Microsoft.Maui.Controls.BindableProperty>> definition)
            where T : Sharp.UI.IPropertyCondition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.PropertyCondition>(obj);
            var def = definition(new ValueDef<Microsoft.Maui.Controls.BindableProperty>());
            if (def.ValueIsSet()) mauiObject.Property = def.GetValue();
            return obj;
        }
        
        public static T Value<T>(this T obj,
            object? value)
            where T : Sharp.UI.IPropertyCondition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.PropertyCondition>(obj);
            if (value != null) mauiObject.Value = (object)value;
            return obj;
        }
        
        public static T Value<T>(this T obj,
            object? value,
            System.Func<ValueDef<object>, ValueDef<object>> definition)
            where T : Sharp.UI.IPropertyCondition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.PropertyCondition>(obj);
            if (value != null) mauiObject.Value = (object)value;
            var def = definition(new ValueDef<object>());
            if (def.ValueIsSet()) mauiObject.Value = def.GetValue();
            return obj;
        }
        
        public static T Value<T>(this T obj,
            System.Func<ValueDef<object>, ValueDef<object>> definition)
            where T : Sharp.UI.IPropertyCondition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.PropertyCondition>(obj);
            var def = definition(new ValueDef<object>());
            if (def.ValueIsSet()) mauiObject.Value = def.GetValue();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669