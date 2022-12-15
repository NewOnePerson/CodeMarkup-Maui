﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class VisualStateGeneratedExtension
    {
        public static T Name<T>(this T obj,
            string? name)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.VisualState>(obj);
            var mauiValue = MauiWrapper.Value<string>(name);
            if (name != null) mauiObject.Name = mauiValue;
            return obj;
        }
        
        public static T Name<T>(this T obj,
            string? name,
            System.Func<ValueDef<string>, ValueDef<string>> definition)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.VisualState>(obj);
            var mauiValue = MauiWrapper.Value<string>(name);
            if (name != null) mauiObject.Name = mauiValue;
            var def = definition(new ValueDef<string>());
            if (def.ValueIsSet()) mauiObject.Name = def.GetValue();
            return obj;
        }
        
        public static T Name<T>(this T obj,
            System.Func<ValueDef<string>, ValueDef<string>> definition)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.VisualState>(obj);
            var def = definition(new ValueDef<string>());
            if (def.ValueIsSet()) mauiObject.Name = def.GetValue();
            return obj;
        }
        
        public static T Setters<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter> setters)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.VisualState>(obj);
            foreach (var item in setters)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Setter>(item);
                mauiObject.Setters.Add(mauiItem);
            }
            return obj;
        }

        public static T Setters<T>(this T obj,
            params Microsoft.Maui.Controls.Setter[] setters)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.VisualState>(obj);
            foreach (var item in setters)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Setter>(item);
                mauiObject.Setters.Add(mauiItem);
            }
            return obj;
        }

        public static T Setters<T>(this T obj,
            System.Func<Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>, Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>> definition)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.VisualState>(obj);
            var def = definition(new Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) 
                {
                    var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Setter>(item);
                    mauiObject.Setters.Add(mauiItem);
                }
            }
            return obj;
        }
        
        public static T StateTriggers<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.StateTriggerBase> stateTriggers)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.VisualState>(obj);
            foreach (var item in stateTriggers)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.StateTriggerBase>(item);
                mauiObject.StateTriggers.Add(mauiItem);
            }
            return obj;
        }

        public static T StateTriggers<T>(this T obj,
            params Microsoft.Maui.Controls.StateTriggerBase[] stateTriggers)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.VisualState>(obj);
            foreach (var item in stateTriggers)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.StateTriggerBase>(item);
                mauiObject.StateTriggers.Add(mauiItem);
            }
            return obj;
        }

        public static T StateTriggers<T>(this T obj,
            System.Func<Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.StateTriggerBase>>, Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.StateTriggerBase>>> definition)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.VisualState>(obj);
            var def = definition(new Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.StateTriggerBase>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) 
                {
                    var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.StateTriggerBase>(item);
                    mauiObject.StateTriggers.Add(mauiItem);
                }
            }
            return obj;
        }
        
        public static T TargetType<T>(this T obj,
            System.Type? targetType)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.VisualState>(obj);
            var mauiValue = MauiWrapper.Value<System.Type>(targetType);
            if (targetType != null) mauiObject.TargetType = mauiValue;
            return obj;
        }
        
        public static T TargetType<T>(this T obj,
            System.Type? targetType,
            System.Func<ValueDef<System.Type>, ValueDef<System.Type>> definition)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.VisualState>(obj);
            var mauiValue = MauiWrapper.Value<System.Type>(targetType);
            if (targetType != null) mauiObject.TargetType = mauiValue;
            var def = definition(new ValueDef<System.Type>());
            if (def.ValueIsSet()) mauiObject.TargetType = def.GetValue();
            return obj;
        }
        
        public static T TargetType<T>(this T obj,
            System.Func<ValueDef<System.Type>, ValueDef<System.Type>> definition)
            where T : Sharp.UI.IVisualState
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.VisualState>(obj);
            var def = definition(new ValueDef<System.Type>());
            if (def.ValueIsSet()) mauiObject.TargetType = def.GetValue();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
