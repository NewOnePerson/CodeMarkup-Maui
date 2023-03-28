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

    public partial class IndicatorView : IEnumerable
	{

        // ----- constructors -----

        public IndicatorView() { }

        public IndicatorView(out IndicatorView indicatorView) 
        {
            indicatorView = this;
        }

        public IndicatorView(System.Func<IndicatorView, IndicatorView> configure) 
        {
            configure(this);
        }

        public IndicatorView(out IndicatorView indicatorView, System.Func<IndicatorView, IndicatorView> configure) 
        {
            indicatorView = this;
            configure(this);
        }

        // ----- single item container -----

        IEnumerator IEnumerable.GetEnumerator() { yield return this.IndicatorLayout; }
        public void Add(Microsoft.Maui.Controls.IBindableLayout indicatorlayout) => this.IndicatorLayout = indicatorlayout;

    }
}

#nullable restore