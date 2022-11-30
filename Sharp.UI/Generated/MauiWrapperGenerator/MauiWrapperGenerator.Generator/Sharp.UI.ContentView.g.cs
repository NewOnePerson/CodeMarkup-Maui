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
    public partial class ContentView : Microsoft.Maui.Controls.ContentView, Sharp.UI.IContentView, IEnumerable, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public ContentView() { }


        public ContentView(out ContentView contentView) 
        {
            contentView = this;
        }

        public ContentView(Action<ContentView> configure) 
        {
            configure(this);
        }

        public ContentView(out ContentView contentView, Action<ContentView> configure) 
        {
            contentView = this;
            configure(this);
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { throw new NotImplementedException(); }

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

#pragma warning restore CS0108
#pragma warning restore CS8625
#pragma warning restore CS8669