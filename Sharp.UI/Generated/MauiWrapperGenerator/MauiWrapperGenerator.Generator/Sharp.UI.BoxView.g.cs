﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class BoxView : Microsoft.Maui.Controls.BoxView, Sharp.UI.IBoxView, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public BoxView() { }


        public BoxView(out BoxView boxView) 
        {
            boxView = this;
        }

        public BoxView(Action<BoxView> configure) 
        {
            configure(this);
        }

        public BoxView(out BoxView boxView, Action<BoxView> configure) 
        {
            boxView = this;
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
