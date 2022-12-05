﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class LineGeometry : Microsoft.Maui.Controls.Shapes.LineGeometry, Sharp.UI.ILineGeometry, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public LineGeometry() { }


        public LineGeometry(out LineGeometry lineGeometry) 
        {
            lineGeometry = this;
        }

        public LineGeometry(Action<LineGeometry> configure) 
        {
            configure(this);
        }

        public LineGeometry(out LineGeometry lineGeometry, Action<LineGeometry> configure) 
        {
            lineGeometry = this;
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

#pragma warning restore CS8669
