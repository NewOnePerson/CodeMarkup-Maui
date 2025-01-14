﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Classes.Builder
//

#nullable enable


using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;


namespace CodeMarkup.Maui
{
	using CodeMarkup.Maui;

    public partial class RadioButton : IEnumerable
	{

        // ----- constructors -----

        public RadioButton() { }

        public RadioButton(out RadioButton radioButton) 
        {
            radioButton = this;
        }

        public RadioButton(System.Func<RadioButton, RadioButton> configure) 
        {
            configure(this);
        }

        public RadioButton(out RadioButton radioButton, System.Func<RadioButton, RadioButton> configure) 
        {
            radioButton = this;
            configure(this);
        }

        // ----- single item container -----

        IEnumerator IEnumerable.GetEnumerator() { yield return this.Content; }
        public void Add(object content) => this.Content = content;

    }
}

#nullable restore
