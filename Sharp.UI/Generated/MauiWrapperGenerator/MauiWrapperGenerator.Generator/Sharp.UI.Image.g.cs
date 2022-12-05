﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class Image : Microsoft.Maui.Controls.Image, Sharp.UI.IImage, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public Image() { }


        public Image(out Image image) 
        {
            image = this;
        }

        public Image(Action<Image> configure) 
        {
            configure(this);
        }

        public Image(out Image image, Action<Image> configure) 
        {
            image = this;
            configure(this);
        }

        public Image(Microsoft.Maui.Controls.ImageSource source) 
        {  
            this.Source = source;
        }

        public Image(Microsoft.Maui.Controls.ImageSource source, out Image image) 
        {  
            this.Source = source;;
            image = this;
        }

        public Image(Microsoft.Maui.Controls.ImageSource source, Action<Image> configure) 
        {  
            this.Source = source;
            configure(this);
        }

        public Image(Microsoft.Maui.Controls.ImageSource source, out Image image, Action<Image> configure) 
        {  
            this.Source = source;
            image = this;
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
