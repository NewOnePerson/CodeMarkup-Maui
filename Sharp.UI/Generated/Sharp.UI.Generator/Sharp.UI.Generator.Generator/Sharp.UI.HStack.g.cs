﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class HStack : Microsoft.Maui.Controls.HorizontalStackLayout, Sharp.UI.IHorizontalStackLayout, IWrappedBindableObject
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

        // ----- binding context -----

        public new object BindingContext
        {
            get => base.BindingContext;
            set
            {
                var mauiObject = MauiWrapper.Value<object>(value);
                base.BindingContext = mauiObject;
            }
        }
        

    }
}

#pragma warning restore CS8669
