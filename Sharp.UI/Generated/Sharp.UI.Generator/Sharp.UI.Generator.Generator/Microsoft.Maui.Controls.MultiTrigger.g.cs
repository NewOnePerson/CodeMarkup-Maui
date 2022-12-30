﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class MultiTriggerGeneratedExtension
    {
        public static T Conditions<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.Condition> conditions)
            where T : Sharp.UI.IMultiTrigger
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MultiTrigger>(obj);
            foreach (var item in conditions)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Condition>(item);
                mauiObject.Conditions.Add(mauiItem);
            }
            return obj;
        }

        public static T Conditions<T>(this T obj,
            params Microsoft.Maui.Controls.Condition[] conditions)
            where T : Sharp.UI.IMultiTrigger
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MultiTrigger>(obj);
            foreach (var item in conditions)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Condition>(item);
                mauiObject.Conditions.Add(mauiItem);
            }
            return obj;
        }

        public static T Conditions<T>(this T obj,
            System.Func<LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Condition>>, LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Condition>>> buildValue)
            where T : Sharp.UI.IMultiTrigger
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MultiTrigger>(obj);
            var builder = buildValue(new LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Condition>>());
            if (builder.ValueIsSet())
            {
                var items = builder.GetValue();
                foreach (var item in items) 
                {
                    var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Condition>(item);
                    mauiObject.Conditions.Add(mauiItem);
                }
            }
            return obj;
        }
        
        public static T Setters<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter> setters)
            where T : Sharp.UI.IMultiTrigger
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MultiTrigger>(obj);
            foreach (var item in setters)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Setter>(item);
                mauiObject.Setters.Add(mauiItem);
            }
            return obj;
        }

        public static T Setters<T>(this T obj,
            params Microsoft.Maui.Controls.Setter[] setters)
            where T : Sharp.UI.IMultiTrigger
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MultiTrigger>(obj);
            foreach (var item in setters)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Setter>(item);
                mauiObject.Setters.Add(mauiItem);
            }
            return obj;
        }

        public static T Setters<T>(this T obj,
            System.Func<LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>, LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>> buildValue)
            where T : Sharp.UI.IMultiTrigger
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MultiTrigger>(obj);
            var builder = buildValue(new LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>());
            if (builder.ValueIsSet())
            {
                var items = builder.GetValue();
                foreach (var item in items) 
                {
                    var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Setter>(item);
                    mauiObject.Setters.Add(mauiItem);
                }
            }
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
