﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class LinearGradientBrush : Microsoft.Maui.Controls.LinearGradientBrush, Sharp.UI.ILinearGradientBrush, IList<Microsoft.Maui.Controls.GradientStop>, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public LinearGradientBrush() { }

        // ----- collection container -----

        public int Count => this.GradientStops.Count;
        public Microsoft.Maui.Controls.GradientStop this[int index] { get => this.GradientStops[index]; set => this.GradientStops[index] = value; }
        public bool IsReadOnly => false;
        public void Add(Microsoft.Maui.Controls.GradientStop item) => this.GradientStops.Add(item);
        public void Clear() => this.GradientStops.Clear();
        public bool Contains(Microsoft.Maui.Controls.GradientStop item) => this.GradientStops.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.GradientStop[] array, int arrayIndex) => this.GradientStops.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.GradientStop> GetEnumerator() => this.GradientStops.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.GradientStop item) => this.GradientStops.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.GradientStop item) => this.GradientStops.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.GradientStop item) => this.GradientStops.Remove(item);
        public void RemoveAt(int index) => this.GradientStops.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.GradientStops.GetEnumerator();

        // ----- binding context -----

        public new object BindingContext
        {
            get => base.BindingContext;
            set
            {
                var mauiObject = MauiWrapper.GetObject<object>(value);
                base.BindingContext = mauiObject;
            }
        }
        

    }
}

#pragma warning restore CS8669
