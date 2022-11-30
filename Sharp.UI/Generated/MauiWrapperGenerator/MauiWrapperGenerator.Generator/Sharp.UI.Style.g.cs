﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class Style : Sharp.UI.IStyle, ISealedMauiWrapper, IList<Microsoft.Maui.Controls.Setter>
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.Style MauiObject { get => (Microsoft.Maui.Controls.Style)_maui_RawObject; set => _maui_RawObject = value; }

        // ----- constructors -----
        

        public Style(Microsoft.Maui.Controls.Style style)
        {
            MauiObject = style;
        }

        // ----- operators -----

        public static implicit operator Style(Microsoft.Maui.Controls.Style mauiObject) => new Style(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.Style(Style obj) => obj.MauiObject;

        // ----- collection container -----

        public int Count => this.MauiObject.Setters.Count;
        public Microsoft.Maui.Controls.Setter this[int index] { get => this.MauiObject.Setters[index]; set => this.MauiObject.Setters[index] = value; }
        public bool IsReadOnly => false;
        public void Add(Microsoft.Maui.Controls.Setter item) => this.MauiObject.Setters.Add(item);
        public void Clear() => this.MauiObject.Setters.Clear();
        public bool Contains(Microsoft.Maui.Controls.Setter item) => this.MauiObject.Setters.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.Setter[] array, int arrayIndex) => this.MauiObject.Setters.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.Setter> GetEnumerator() => this.MauiObject.Setters.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.Setter item) => this.MauiObject.Setters.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.Setter item) => this.MauiObject.Setters.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.Setter item) => this.MauiObject.Setters.Remove(item);
        public void RemoveAt(int index) => this.MauiObject.Setters.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.MauiObject.Setters.GetEnumerator();

        // ----- bindable properties -----


        // ----- properties / events -----

        public bool ApplyToDerivedTypes { get => MauiObject.ApplyToDerivedTypes; set => MauiObject.ApplyToDerivedTypes = value; }
        public Microsoft.Maui.Controls.Style BasedOn { get => MauiObject.BasedOn; set => MauiObject.BasedOn = value; }
        public string BaseResourceKey { get => MauiObject.BaseResourceKey; set => MauiObject.BaseResourceKey = value; }
        public System.Collections.Generic.IList<Microsoft.Maui.Controls.Behavior> Behaviors { get => MauiObject.Behaviors; }
        public bool CanCascade { get => MauiObject.CanCascade; set => MauiObject.CanCascade = value; }
        public string Class { get => MauiObject.Class; set => MauiObject.Class = value; }
        public System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter> Setters { get => MauiObject.Setters; }
        public System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerBase> Triggers { get => MauiObject.Triggers; }
        public System.Type TargetType { get => MauiObject.TargetType; }
    }
    
    public static class IStyleGeneratedContainerExtension
    {
        // ----- collection container extension -----
        public static T Setters<T>(this T obj, params Microsoft.Maui.Controls.Setter[] setters) where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            foreach (var item in setters) mauiObject.Setters.Add(item);
            return obj;
        }

        public static T Setters<T>(this T obj,
            Func<CollectionDef<Microsoft.Maui.Controls.Setter>, CollectionDef<Microsoft.Maui.Controls.Setter>> definition)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Style>(obj);
            var def = definition(new CollectionDef<Microsoft.Maui.Controls.Setter>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) mauiObject.Setters.Add(item);
            }
            return obj;
        }
    }

}

#pragma warning restore CS0108
#pragma warning restore CS8625
#pragma warning restore CS8669