﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class SearchBar : Microsoft.Maui.Controls.SearchBar, Sharp.UI.ISearchBar, IWrappedBindableObject
    {
        // ----- constructors -----

        public SearchBar() { }

        public SearchBar(out SearchBar searchBar) 
        {
            searchBar = this;
        }

        public SearchBar(System.Action<SearchBar> configure) 
        {
            configure(this);
        }

        public SearchBar(out SearchBar searchBar, System.Action<SearchBar> configure) 
        {
            searchBar = this;
            configure(this);
        }

        public SearchBar(string placeholder) 
        {  
            this.Placeholder = placeholder;
        }

        public SearchBar(string placeholder, out SearchBar searchBar) 
        {  
            this.Placeholder = placeholder;;
            searchBar = this;
        }

        public SearchBar(string placeholder, System.Action<SearchBar> configure) 
        {  
            this.Placeholder = placeholder;
            configure(this);
        }

        public SearchBar(string placeholder, out SearchBar searchBar, System.Action<SearchBar> configure) 
        {  
            this.Placeholder = placeholder;
            searchBar = this;
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
