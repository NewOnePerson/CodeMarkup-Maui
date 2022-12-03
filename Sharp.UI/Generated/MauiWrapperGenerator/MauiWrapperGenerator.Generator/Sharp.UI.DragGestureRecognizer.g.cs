﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class DragGestureRecognizer : Microsoft.Maui.Controls.DragGestureRecognizer, Sharp.UI.IDragGestureRecognizer, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public DragGestureRecognizer() { }


        public DragGestureRecognizer(out DragGestureRecognizer dragGestureRecognizer) 
        {
            dragGestureRecognizer = this;
        }

        public DragGestureRecognizer(Action<DragGestureRecognizer> configure) 
        {
            configure(this);
        }

        public DragGestureRecognizer(out DragGestureRecognizer dragGestureRecognizer, Action<DragGestureRecognizer> configure) 
        {
            dragGestureRecognizer = this;
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
