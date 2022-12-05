﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class ContentPresenter : Microsoft.Maui.Controls.ContentPresenter, Sharp.UI.IContentPresenter, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public ContentPresenter() { }


        public ContentPresenter(out ContentPresenter contentPresenter) 
        {
            contentPresenter = this;
        }

        public ContentPresenter(Action<ContentPresenter> configure) 
        {
            configure(this);
        }

        public ContentPresenter(out ContentPresenter contentPresenter, Action<ContentPresenter> configure) 
        {
            contentPresenter = this;
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
