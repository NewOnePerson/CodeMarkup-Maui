﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.HorizontalStackLayout</c> class.
    /// </summary>
    public partial class HStack : Microsoft.Maui.Controls.HorizontalStackLayout, Sharp.UI.IHorizontalStackLayout, IMauiWrapper
    {
        // ----- constructors -----

        public HStack() { }

        public HStack(out HStack hStack) 
        {
            hStack = this;
        }

        public HStack(System.Action<HStack> configure) 
        {
            configure(this);
        }

        public HStack(out HStack hStack, System.Action<HStack> configure) 
        {
            hStack = this;
            configure(this);
        }

        // ----- properties / events -----

        public new Sharp.UI.Style Style { get => new Sharp.UI.Style(base.Style); set => base.Style = value.MauiObject; }
        public new object BindingContext { get => base.BindingContext; set => base.BindingContext = MauiWrapper.Value<object>(value); }

        // ----- set value method -----

        public new void SetValue(Microsoft.Maui.Controls.BindableProperty property, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            ((Microsoft.Maui.Controls.BindableObject)this).SetValue(property, mauiValue);
        }

        public new void SetValue(Microsoft.Maui.Controls.BindablePropertyKey propertyKey, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            ((Microsoft.Maui.Controls.BindableObject)this).SetValue(propertyKey, mauiValue);
        }
    }
}

#pragma warning restore CS8669