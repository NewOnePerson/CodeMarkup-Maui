﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class Label : Microsoft.Maui.Controls.Label, Sharp.UI.ILabel, IEnumerable, IWrappedBindableObject
    {
        // ----- constructors -----

        public Label() { }

        public Label(out Label label) 
        {
            label = this;
        }

        public Label(System.Action<Label> configure) 
        {
            configure(this);
        }

        public Label(out Label label, System.Action<Label> configure) 
        {
            label = this;
            configure(this);
        }

        public Label(string text) 
        {  
            this.Text = text;
        }

        public Label(string text, out Label label) 
        {  
            this.Text = text;;
            label = this;
        }

        public Label(string text, System.Action<Label> configure) 
        {  
            this.Text = text;
            configure(this);
        }

        public Label(string text, out Label label, System.Action<Label> configure) 
        {  
            this.Text = text;
            label = this;
            configure(this);
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { yield return this.Text; }

        public void Add(string text) => this.Text = text;

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
