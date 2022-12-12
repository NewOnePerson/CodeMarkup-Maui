﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class CarouselView : Microsoft.Maui.Controls.CarouselView, Sharp.UI.ICarouselView, IWrappedBindableObject
    {
        // ----- constructors -----

        public CarouselView() { }

        public CarouselView(out CarouselView carouselView) 
        {
            carouselView = this;
        }

        public CarouselView(Action<CarouselView> configure) 
        {
            configure(this);
        }

        public CarouselView(out CarouselView carouselView, Action<CarouselView> configure) 
        {
            carouselView = this;
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