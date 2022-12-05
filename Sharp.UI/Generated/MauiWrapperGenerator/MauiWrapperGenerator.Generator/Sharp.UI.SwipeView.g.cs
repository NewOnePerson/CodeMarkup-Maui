﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class SwipeView : Microsoft.Maui.Controls.SwipeView, Sharp.UI.ISwipeView, IEnumerable, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public SwipeView() { }


        public SwipeView(out SwipeView swipeView) 
        {
            swipeView = this;
        }

        public SwipeView(Action<SwipeView> configure) 
        {
            configure(this);
        }

        public SwipeView(out SwipeView swipeView, Action<SwipeView> configure) 
        {
            swipeView = this;
            configure(this);
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { yield return this.Content; }

        public void Add(Microsoft.Maui.Controls.View content) => this.Content = content;

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
