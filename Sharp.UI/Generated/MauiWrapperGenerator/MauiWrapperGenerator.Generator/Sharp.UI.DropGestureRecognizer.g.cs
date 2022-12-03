﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class DropGestureRecognizer : Microsoft.Maui.Controls.DropGestureRecognizer, Sharp.UI.IDropGestureRecognizer, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public DropGestureRecognizer() { }


        public DropGestureRecognizer(out DropGestureRecognizer dropGestureRecognizer) 
        {
            dropGestureRecognizer = this;
        }

        public DropGestureRecognizer(Action<DropGestureRecognizer> configure) 
        {
            configure(this);
        }

        public DropGestureRecognizer(out DropGestureRecognizer dropGestureRecognizer, Action<DropGestureRecognizer> configure) 
        {
            dropGestureRecognizer = this;
            configure(this);
        }

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

#pragma warning restore CS0108
#pragma warning restore CS8625
#pragma warning restore CS8669
