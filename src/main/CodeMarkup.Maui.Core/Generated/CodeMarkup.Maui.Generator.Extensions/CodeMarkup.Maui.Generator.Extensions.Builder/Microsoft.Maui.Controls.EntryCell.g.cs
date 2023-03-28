﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class EntryCellExtension
    {
        public static T HorizontalTextAlignment<T>(this T self,
            Microsoft.Maui.TextAlignment horizontalTextAlignment)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.SetValue(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, horizontalTextAlignment);
            return self;
        }
        
        public static T HorizontalTextAlignment<T>(this T self, Func<PropertyContext<Microsoft.Maui.TextAlignment>, IPropertyBuilder<Microsoft.Maui.TextAlignment>> configure)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var context = new PropertyContext<Microsoft.Maui.TextAlignment>(self, Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> HorizontalTextAlignment<T>(this SettersContext<T> self,
            Microsoft.Maui.TextAlignment horizontalTextAlignment)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, Value = horizontalTextAlignment });
            return self;
        }
        
        public static SettersContext<T> HorizontalTextAlignment<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.TextAlignment>, IPropertySettersBuilder<Microsoft.Maui.TextAlignment>> configure)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var context = new PropertySettersContext<Microsoft.Maui.TextAlignment>(self.XamlSetters, Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty);
            configure(context).Build();
            return self;
        }
        
        public static T VerticalTextAlignment<T>(this T self,
            Microsoft.Maui.TextAlignment verticalTextAlignment)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.SetValue(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, verticalTextAlignment);
            return self;
        }
        
        public static T VerticalTextAlignment<T>(this T self, Func<PropertyContext<Microsoft.Maui.TextAlignment>, IPropertyBuilder<Microsoft.Maui.TextAlignment>> configure)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var context = new PropertyContext<Microsoft.Maui.TextAlignment>(self, Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> VerticalTextAlignment<T>(this SettersContext<T> self,
            Microsoft.Maui.TextAlignment verticalTextAlignment)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, Value = verticalTextAlignment });
            return self;
        }
        
        public static SettersContext<T> VerticalTextAlignment<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.TextAlignment>, IPropertySettersBuilder<Microsoft.Maui.TextAlignment>> configure)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var context = new PropertySettersContext<Microsoft.Maui.TextAlignment>(self.XamlSetters, Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Keyboard<T>(this T self,
            Microsoft.Maui.Keyboard keyboard)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.SetValue(Microsoft.Maui.Controls.EntryCell.KeyboardProperty, keyboard);
            return self;
        }
        
        public static T Keyboard<T>(this T self, Func<PropertyContext<Microsoft.Maui.Keyboard>, IPropertyBuilder<Microsoft.Maui.Keyboard>> configure)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var context = new PropertyContext<Microsoft.Maui.Keyboard>(self, Microsoft.Maui.Controls.EntryCell.KeyboardProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Keyboard<T>(this SettersContext<T> self,
            Microsoft.Maui.Keyboard keyboard)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.EntryCell.KeyboardProperty, Value = keyboard });
            return self;
        }
        
        public static SettersContext<T> Keyboard<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Keyboard>, IPropertySettersBuilder<Microsoft.Maui.Keyboard>> configure)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var context = new PropertySettersContext<Microsoft.Maui.Keyboard>(self.XamlSetters, Microsoft.Maui.Controls.EntryCell.KeyboardProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Label<T>(this T self,
            string label)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.SetValue(Microsoft.Maui.Controls.EntryCell.LabelProperty, label);
            return self;
        }
        
        public static T Label<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.EntryCell.LabelProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Label<T>(this SettersContext<T> self,
            string label)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.EntryCell.LabelProperty, Value = label });
            return self;
        }
        
        public static SettersContext<T> Label<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.EntryCell.LabelProperty);
            configure(context).Build();
            return self;
        }
        
        public static T LabelColor<T>(this T self,
            Microsoft.Maui.Graphics.Color labelColor)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.SetValue(Microsoft.Maui.Controls.EntryCell.LabelColorProperty, labelColor);
            return self;
        }
        
        public static T LabelColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.EntryCell.LabelColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> LabelColor<T>(this SettersContext<T> self,
            Microsoft.Maui.Graphics.Color labelColor)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.EntryCell.LabelColorProperty, Value = labelColor });
            return self;
        }
        
        public static SettersContext<T> LabelColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, Microsoft.Maui.Controls.EntryCell.LabelColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Placeholder<T>(this T self,
            string placeholder)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.SetValue(Microsoft.Maui.Controls.EntryCell.PlaceholderProperty, placeholder);
            return self;
        }
        
        public static T Placeholder<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.EntryCell.PlaceholderProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Placeholder<T>(this SettersContext<T> self,
            string placeholder)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.EntryCell.PlaceholderProperty, Value = placeholder });
            return self;
        }
        
        public static SettersContext<T> Placeholder<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.EntryCell.PlaceholderProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Text<T>(this T self,
            string text)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.SetValue(Microsoft.Maui.Controls.EntryCell.TextProperty, text);
            return self;
        }
        
        public static T Text<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.EntryCell.TextProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Text<T>(this SettersContext<T> self,
            string text)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.EntryCell.TextProperty, Value = text });
            return self;
        }
        
        public static SettersContext<T> Text<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.EntryCell.TextProperty);
            configure(context).Build();
            return self;
        }
        
        public static T OnCompleted<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.Completed += handler;
            return self;
        }
        
        public static T OnCompleted<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.Completed += (o, arg) => action(self);
            return self;
        }
        

        public static T TextCenterHorizontal<T>(this T self)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.SetValue(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }

        public static T TextCenterVertical<T>(this T self)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.SetValue(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }

        public static T TextCenter<T>(this T self)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.SetValue(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, TextAlignment.Center);
            self.SetValue(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }

        public static T TextTop<T>(this T self)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.SetValue(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextBottom<T>(this T self)
            where T : Microsoft.Maui.Controls.EntryCell, Microsoft.Maui.ITextAlignment
        {
            self.SetValue(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        public static T TextTopStart<T>(this T self)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.SetValue(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, TextAlignment.Start);
            self.SetValue(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextBottomStart<T>(this T self)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.SetValue(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, TextAlignment.End);
            self.SetValue(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextTopEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.SetValue(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, TextAlignment.Start);
            self.SetValue(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        public static T TextBottomEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.SetValue(Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, TextAlignment.End);
            self.SetValue(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        public static T TextStart<T>(this T self)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.SetValue(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.EntryCell
        {
            self.SetValue(Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        
    }
}

#pragma warning restore CS8601
#nullable restore
