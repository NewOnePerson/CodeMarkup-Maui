﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class Editor : Microsoft.Maui.Controls.Editor, Sharp.UI.IEditor, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public Editor() { }


        public Editor(out Editor editor) 
        {
            editor = this;
        }

        public Editor(Action<Editor> configure) 
        {
            configure(this);
        }

        public Editor(out Editor editor, Action<Editor> configure) 
        {
            editor = this;
            configure(this);
        }

        public Editor(string placeholder) 
        {  
            this.Placeholder = placeholder;
        }

        public Editor(string placeholder, out Editor editor) 
        {  
            this.Placeholder = placeholder;;
            editor = this;
        }

        public Editor(string placeholder, Action<Editor> configure) 
        {  
            this.Placeholder = placeholder;
            configure(this);
        }

        public Editor(string placeholder, out Editor editor, Action<Editor> configure) 
        {  
            this.Placeholder = placeholder;
            editor = this;
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

#pragma warning restore CS0108
#pragma warning restore CS8625
#pragma warning restore CS8669