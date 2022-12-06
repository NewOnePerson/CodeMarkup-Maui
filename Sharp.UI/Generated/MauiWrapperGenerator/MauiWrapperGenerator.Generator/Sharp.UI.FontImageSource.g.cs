﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class FontImageSource : Microsoft.Maui.Controls.FontImageSource, Sharp.UI.IFontImageSource, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public FontImageSource() { }


        public FontImageSource(out FontImageSource fontImageSource) 
        {
            fontImageSource = this;
        }

        public FontImageSource(Action<FontImageSource> configure) 
        {
            configure(this);
        }

        public FontImageSource(out FontImageSource fontImageSource, Action<FontImageSource> configure) 
        {
            fontImageSource = this;
            configure(this);
        }

        public FontImageSource(string glyph, string fontfamily) 
        {  
            this.Glyph = glyph;
            this.FontFamily = fontfamily;
        }

        public FontImageSource(string glyph, string fontfamily, out FontImageSource fontImageSource) 
        {  
            this.Glyph = glyph;
            this.FontFamily = fontfamily;;
            fontImageSource = this;
        }

        public FontImageSource(string glyph, string fontfamily, Action<FontImageSource> configure) 
        {  
            this.Glyph = glyph;
            this.FontFamily = fontfamily;
            configure(this);
        }

        public FontImageSource(string glyph, string fontfamily, out FontImageSource fontImageSource, Action<FontImageSource> configure) 
        {  
            this.Glyph = glyph;
            this.FontFamily = fontfamily;
            fontImageSource = this;
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