﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class IMultiTriggerGeneratedExtension
    {
        public static T Conditions<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.Condition> conditions)
            where T : Sharp.UI.IMultiTrigger
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MultiTrigger>(obj);
            foreach (var item in conditions) mauiObject.Conditions.Add(item);
            return obj;
        }

        public static T Conditions<T>(this T obj,
            Func<Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Condition>>, Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Condition>>> definition)
            where T : Sharp.UI.IMultiTrigger
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MultiTrigger>(obj);
            var def = definition(new Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Condition>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) mauiObject.Conditions.Add(item);
            }
            return obj;
        }
        
        public static T Setters<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter> setters)
            where T : Sharp.UI.IMultiTrigger
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MultiTrigger>(obj);
            foreach (var item in setters) mauiObject.Setters.Add(item);
            return obj;
        }

        public static T Setters<T>(this T obj,
            Func<Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>, Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>> definition)
            where T : Sharp.UI.IMultiTrigger
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MultiTrigger>(obj);
            var def = definition(new Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) mauiObject.Setters.Add(item);
            }
            return obj;
        }
        
        public static T OnPropertyChanged<T>(this T obj, OnEventAction<T, System.ComponentModel.PropertyChangedEventArgs> action)
            where T : Sharp.UI.IMultiTrigger
        {            
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MultiTrigger>(obj);
            mauiObject.PropertyChanged += (o, arg) => action(obj, arg);
            return obj;
        }
        
        public static T OnPropertyChanging<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.PropertyChangingEventArgs> action)
            where T : Sharp.UI.IMultiTrigger
        {            
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MultiTrigger>(obj);
            mauiObject.PropertyChanging += (o, arg) => action(obj, arg);
            return obj;
        }
        
        public static T OnBindingContextChanged<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IMultiTrigger
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.MultiTrigger>(obj);
            mauiObject.BindingContextChanged += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669