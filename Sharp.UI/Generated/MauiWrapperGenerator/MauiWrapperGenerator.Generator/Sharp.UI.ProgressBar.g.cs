﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class ProgressBar : Microsoft.Maui.Controls.ProgressBar, Sharp.UI.IProgressBar, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public ProgressBar() { }


        public ProgressBar(out ProgressBar progressBar) 
        {
            progressBar = this;
        }

        public ProgressBar(Action<ProgressBar> configure) 
        {
            configure(this);
        }

        public ProgressBar(out ProgressBar progressBar, Action<ProgressBar> configure) 
        {
            progressBar = this;
            configure(this);
        }

        public ProgressBar(double progress) 
        {  
            this.Progress = progress;
        }

        public ProgressBar(double progress, out ProgressBar progressBar) 
        {  
            this.Progress = progress;;
            progressBar = this;
        }

        public ProgressBar(double progress, Action<ProgressBar> configure) 
        {  
            this.Progress = progress;
            configure(this);
        }

        public ProgressBar(double progress, out ProgressBar progressBar, Action<ProgressBar> configure) 
        {  
            this.Progress = progress;
            progressBar = this;
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
