﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class TextCellExtension
    {
        public static T Command<T>(this T self,
            System.Windows.Input.ICommand command)
            where T : Microsoft.Maui.Controls.TextCell
        {
            self.SetValue(Microsoft.Maui.Controls.TextCell.CommandProperty, command);
            return self;
        }
        
        public static T Command<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var context = new PropertyContext<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.TextCell.CommandProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Command<T>(this SettersContext<T> self,
            System.Windows.Input.ICommand command)
            where T : Microsoft.Maui.Controls.TextCell
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.TextCell.CommandProperty, Value = command });
            return self;
        }
        
        public static SettersContext<T> Command<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, Microsoft.Maui.Controls.TextCell.CommandProperty);
            configure(context).Build();
            return self;
        }
        
        public static T CommandParameter<T>(this T self,
            object commandParameter)
            where T : Microsoft.Maui.Controls.TextCell
        {
            self.SetValue(Microsoft.Maui.Controls.TextCell.CommandParameterProperty, commandParameter);
            return self;
        }
        
        public static T CommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.TextCell.CommandParameterProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self,
            object commandParameter)
            where T : Microsoft.Maui.Controls.TextCell
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.TextCell.CommandParameterProperty, Value = commandParameter });
            return self;
        }
        
        public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var context = new PropertySettersContext<object>(self.XamlSetters, Microsoft.Maui.Controls.TextCell.CommandParameterProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Detail<T>(this T self,
            string detail)
            where T : Microsoft.Maui.Controls.TextCell
        {
            self.SetValue(Microsoft.Maui.Controls.TextCell.DetailProperty, detail);
            return self;
        }
        
        public static T Detail<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.TextCell.DetailProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Detail<T>(this SettersContext<T> self,
            string detail)
            where T : Microsoft.Maui.Controls.TextCell
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.TextCell.DetailProperty, Value = detail });
            return self;
        }
        
        public static SettersContext<T> Detail<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.TextCell.DetailProperty);
            configure(context).Build();
            return self;
        }
        
        public static T DetailColor<T>(this T self,
            Microsoft.Maui.Graphics.Color detailColor)
            where T : Microsoft.Maui.Controls.TextCell
        {
            self.SetValue(Microsoft.Maui.Controls.TextCell.DetailColorProperty, detailColor);
            return self;
        }
        
        public static T DetailColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.TextCell.DetailColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> DetailColor<T>(this SettersContext<T> self,
            Microsoft.Maui.Graphics.Color detailColor)
            where T : Microsoft.Maui.Controls.TextCell
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.TextCell.DetailColorProperty, Value = detailColor });
            return self;
        }
        
        public static SettersContext<T> DetailColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, Microsoft.Maui.Controls.TextCell.DetailColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Text<T>(this T self,
            string text)
            where T : Microsoft.Maui.Controls.TextCell
        {
            self.SetValue(Microsoft.Maui.Controls.TextCell.TextProperty, text);
            return self;
        }
        
        public static T Text<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.TextCell.TextProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Text<T>(this SettersContext<T> self,
            string text)
            where T : Microsoft.Maui.Controls.TextCell
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.TextCell.TextProperty, Value = text });
            return self;
        }
        
        public static SettersContext<T> Text<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.TextCell.TextProperty);
            configure(context).Build();
            return self;
        }
        
        public static T TextColor<T>(this T self,
            Microsoft.Maui.Graphics.Color textColor)
            where T : Microsoft.Maui.Controls.TextCell
        {
            self.SetValue(Microsoft.Maui.Controls.TextCell.TextColorProperty, textColor);
            return self;
        }
        
        public static T TextColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.TextCell.TextColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> TextColor<T>(this SettersContext<T> self,
            Microsoft.Maui.Graphics.Color textColor)
            where T : Microsoft.Maui.Controls.TextCell
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.TextCell.TextColorProperty, Value = textColor });
            return self;
        }
        
        public static SettersContext<T> TextColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, Microsoft.Maui.Controls.TextCell.TextColorProperty);
            configure(context).Build();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore