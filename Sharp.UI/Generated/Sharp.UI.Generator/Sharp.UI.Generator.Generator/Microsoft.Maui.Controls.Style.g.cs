﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class StyleGeneratedExtension
    {
        public static T ApplyToDerivedTypes<T>(this T obj,
            bool? applyToDerivedTypes)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var mauiValue = MauiWrapper.Value<bool>(applyToDerivedTypes);
            if (applyToDerivedTypes != null) mauiObject.ApplyToDerivedTypes = mauiValue;
            return obj;
        }
        
        public static T ApplyToDerivedTypes<T>(this T obj,
            bool? applyToDerivedTypes,
            System.Func<ValueDef<bool>, ValueDef<bool>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var mauiValue = MauiWrapper.Value<bool>(applyToDerivedTypes);
            if (applyToDerivedTypes != null) mauiObject.ApplyToDerivedTypes = mauiValue;
            var def = definition(new ValueDef<bool>());
            if (def.ValueIsSet()) mauiObject.ApplyToDerivedTypes = def.GetValue();
            return obj;
        }
        
        public static T ApplyToDerivedTypes<T>(this T obj,
            System.Func<ValueDef<bool>, ValueDef<bool>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var def = definition(new ValueDef<bool>());
            if (def.ValueIsSet()) mauiObject.ApplyToDerivedTypes = def.GetValue();
            return obj;
        }
        
        public static T BasedOn<T>(this T obj,
            Microsoft.Maui.Controls.Style? basedOn)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(basedOn);
            if (basedOn != null) mauiObject.BasedOn = mauiValue;
            return obj;
        }
        
        public static T BasedOn<T>(this T obj,
            Microsoft.Maui.Controls.Style? basedOn,
            System.Func<ValueDef<Microsoft.Maui.Controls.Style>, ValueDef<Microsoft.Maui.Controls.Style>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(basedOn);
            if (basedOn != null) mauiObject.BasedOn = mauiValue;
            var def = definition(new ValueDef<Microsoft.Maui.Controls.Style>());
            if (def.ValueIsSet()) mauiObject.BasedOn = def.GetValue();
            return obj;
        }
        
        public static T BasedOn<T>(this T obj,
            System.Func<ValueDef<Microsoft.Maui.Controls.Style>, ValueDef<Microsoft.Maui.Controls.Style>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var def = definition(new ValueDef<Microsoft.Maui.Controls.Style>());
            if (def.ValueIsSet()) mauiObject.BasedOn = def.GetValue();
            return obj;
        }
        
        public static T BaseResourceKey<T>(this T obj,
            string? baseResourceKey)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var mauiValue = MauiWrapper.Value<string>(baseResourceKey);
            if (baseResourceKey != null) mauiObject.BaseResourceKey = mauiValue;
            return obj;
        }
        
        public static T BaseResourceKey<T>(this T obj,
            string? baseResourceKey,
            System.Func<ValueDef<string>, ValueDef<string>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var mauiValue = MauiWrapper.Value<string>(baseResourceKey);
            if (baseResourceKey != null) mauiObject.BaseResourceKey = mauiValue;
            var def = definition(new ValueDef<string>());
            if (def.ValueIsSet()) mauiObject.BaseResourceKey = def.GetValue();
            return obj;
        }
        
        public static T BaseResourceKey<T>(this T obj,
            System.Func<ValueDef<string>, ValueDef<string>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var def = definition(new ValueDef<string>());
            if (def.ValueIsSet()) mauiObject.BaseResourceKey = def.GetValue();
            return obj;
        }
        
        public static T Behaviors<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.Behavior> behaviors)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            foreach (var item in behaviors)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Behavior>(item);
                mauiObject.Behaviors.Add(mauiItem);
            }
            return obj;
        }

        public static T Behaviors<T>(this T obj,
            params Microsoft.Maui.Controls.Behavior[] behaviors)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            foreach (var item in behaviors)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Behavior>(item);
                mauiObject.Behaviors.Add(mauiItem);
            }
            return obj;
        }

        public static T Behaviors<T>(this T obj,
            System.Func<Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Behavior>>, Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Behavior>>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var def = definition(new Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Behavior>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) 
                {
                    var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Behavior>(item);
                    mauiObject.Behaviors.Add(mauiItem);
                }
            }
            return obj;
        }
        
        public static T CanCascade<T>(this T obj,
            bool? canCascade)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var mauiValue = MauiWrapper.Value<bool>(canCascade);
            if (canCascade != null) mauiObject.CanCascade = mauiValue;
            return obj;
        }
        
        public static T CanCascade<T>(this T obj,
            bool? canCascade,
            System.Func<ValueDef<bool>, ValueDef<bool>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var mauiValue = MauiWrapper.Value<bool>(canCascade);
            if (canCascade != null) mauiObject.CanCascade = mauiValue;
            var def = definition(new ValueDef<bool>());
            if (def.ValueIsSet()) mauiObject.CanCascade = def.GetValue();
            return obj;
        }
        
        public static T CanCascade<T>(this T obj,
            System.Func<ValueDef<bool>, ValueDef<bool>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var def = definition(new ValueDef<bool>());
            if (def.ValueIsSet()) mauiObject.CanCascade = def.GetValue();
            return obj;
        }
        
        public static T Class<T>(this T obj,
            string? @class)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var mauiValue = MauiWrapper.Value<string>(@class);
            if (@class != null) mauiObject.Class = mauiValue;
            return obj;
        }
        
        public static T Class<T>(this T obj,
            string? @class,
            System.Func<ValueDef<string>, ValueDef<string>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var mauiValue = MauiWrapper.Value<string>(@class);
            if (@class != null) mauiObject.Class = mauiValue;
            var def = definition(new ValueDef<string>());
            if (def.ValueIsSet()) mauiObject.Class = def.GetValue();
            return obj;
        }
        
        public static T Class<T>(this T obj,
            System.Func<ValueDef<string>, ValueDef<string>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var def = definition(new ValueDef<string>());
            if (def.ValueIsSet()) mauiObject.Class = def.GetValue();
            return obj;
        }
        
        public static T Setters<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter> setters)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            foreach (var item in setters)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Setter>(item);
                mauiObject.Setters.Add(mauiItem);
            }
            return obj;
        }

        public static T Setters<T>(this T obj,
            params Microsoft.Maui.Controls.Setter[] setters)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            foreach (var item in setters)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Setter>(item);
                mauiObject.Setters.Add(mauiItem);
            }
            return obj;
        }

        public static T Setters<T>(this T obj,
            System.Func<Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>, Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
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
        
        public static T Triggers<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerBase> triggers)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            foreach (var item in triggers)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.TriggerBase>(item);
                mauiObject.Triggers.Add(mauiItem);
            }
            return obj;
        }

        public static T Triggers<T>(this T obj,
            params Microsoft.Maui.Controls.TriggerBase[] triggers)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            foreach (var item in triggers)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.TriggerBase>(item);
                mauiObject.Triggers.Add(mauiItem);
            }
            return obj;
        }

        public static T Triggers<T>(this T obj,
            System.Func<Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerBase>>, Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerBase>>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var def = definition(new Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerBase>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) 
                {
                    var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.TriggerBase>(item);
                    mauiObject.Triggers.Add(mauiItem);
                }
            }
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
