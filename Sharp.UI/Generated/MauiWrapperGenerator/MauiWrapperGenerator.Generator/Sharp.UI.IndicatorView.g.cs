﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class IndicatorView : Microsoft.Maui.Controls.IndicatorView, Sharp.UI.IIndicatorView, IEnumerable, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public IndicatorView() { }


        public IndicatorView(out IndicatorView indicatorView) 
        {
            indicatorView = this;
        }

        public IndicatorView(Action<IndicatorView> configure) 
        {
            configure(this);
        }

        public IndicatorView(out IndicatorView indicatorView, Action<IndicatorView> configure) 
        {
            indicatorView = this;
            configure(this);
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { throw new NotImplementedException(); }

        public void Add(Microsoft.Maui.Controls.IBindableLayout indicatorlayout) => this.IndicatorLayout = indicatorlayout;

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