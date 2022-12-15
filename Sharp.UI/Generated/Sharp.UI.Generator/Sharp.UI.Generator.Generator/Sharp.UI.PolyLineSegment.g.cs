﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class PolyLineSegment : Microsoft.Maui.Controls.Shapes.PolyLineSegment, Sharp.UI.IPolyLineSegment, IWrappedBindableObject
    {
        // ----- constructors -----

        public PolyLineSegment() { }

        public PolyLineSegment(out PolyLineSegment polyLineSegment) 
        {
            polyLineSegment = this;
        }

        public PolyLineSegment(System.Action<PolyLineSegment> configure) 
        {
            configure(this);
        }

        public PolyLineSegment(out PolyLineSegment polyLineSegment, System.Action<PolyLineSegment> configure) 
        {
            polyLineSegment = this;
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
