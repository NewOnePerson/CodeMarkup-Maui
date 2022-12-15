﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class ActivityIndicator : Microsoft.Maui.Controls.ActivityIndicator, Sharp.UI.IActivityIndicator, IWrappedBindableObject
    {
        // ----- constructors -----

        public ActivityIndicator() { }

        public ActivityIndicator(out ActivityIndicator activityIndicator) 
        {
            activityIndicator = this;
        }

        public ActivityIndicator(System.Action<ActivityIndicator> configure) 
        {
            configure(this);
        }

        public ActivityIndicator(out ActivityIndicator activityIndicator, System.Action<ActivityIndicator> configure) 
        {
            activityIndicator = this;
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
