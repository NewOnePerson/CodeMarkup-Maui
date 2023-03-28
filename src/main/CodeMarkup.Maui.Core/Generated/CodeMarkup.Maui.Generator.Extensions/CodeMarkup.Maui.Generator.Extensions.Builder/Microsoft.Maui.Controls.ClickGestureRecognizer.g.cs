﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class ClickGestureRecognizerExtension
    {
        public static Microsoft.Maui.Controls.ClickGestureRecognizer Command(this Microsoft.Maui.Controls.ClickGestureRecognizer self,
            System.Windows.Input.ICommand command)
        {
            self.SetValue(Microsoft.Maui.Controls.ClickGestureRecognizer.CommandProperty, command);
            return self;
        }
        
        public static Microsoft.Maui.Controls.ClickGestureRecognizer Command(this Microsoft.Maui.Controls.ClickGestureRecognizer self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        {
            var context = new PropertyContext<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.ClickGestureRecognizer.CommandProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.ClickGestureRecognizer> Command(this SettersContext<Microsoft.Maui.Controls.ClickGestureRecognizer> self,
            System.Windows.Input.ICommand command)
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.ClickGestureRecognizer.CommandProperty, Value = command });
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.ClickGestureRecognizer> Command(this SettersContext<Microsoft.Maui.Controls.ClickGestureRecognizer> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        {
            var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, Microsoft.Maui.Controls.ClickGestureRecognizer.CommandProperty);
            configure(context).Build();
            return self;
        }
        
        public static Microsoft.Maui.Controls.ClickGestureRecognizer CommandParameter(this Microsoft.Maui.Controls.ClickGestureRecognizer self,
            object commandParameter)
        {
            self.SetValue(Microsoft.Maui.Controls.ClickGestureRecognizer.CommandParameterProperty, commandParameter);
            return self;
        }
        
        public static Microsoft.Maui.Controls.ClickGestureRecognizer CommandParameter(this Microsoft.Maui.Controls.ClickGestureRecognizer self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        {
            var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.ClickGestureRecognizer.CommandParameterProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.ClickGestureRecognizer> CommandParameter(this SettersContext<Microsoft.Maui.Controls.ClickGestureRecognizer> self,
            object commandParameter)
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.ClickGestureRecognizer.CommandParameterProperty, Value = commandParameter });
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.ClickGestureRecognizer> CommandParameter(this SettersContext<Microsoft.Maui.Controls.ClickGestureRecognizer> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        {
            var context = new PropertySettersContext<object>(self.XamlSetters, Microsoft.Maui.Controls.ClickGestureRecognizer.CommandParameterProperty);
            configure(context).Build();
            return self;
        }
        
        public static Microsoft.Maui.Controls.ClickGestureRecognizer NumberOfClicksRequired(this Microsoft.Maui.Controls.ClickGestureRecognizer self,
            int numberOfClicksRequired)
        {
            self.SetValue(Microsoft.Maui.Controls.ClickGestureRecognizer.NumberOfClicksRequiredProperty, numberOfClicksRequired);
            return self;
        }
        
        public static Microsoft.Maui.Controls.ClickGestureRecognizer NumberOfClicksRequired(this Microsoft.Maui.Controls.ClickGestureRecognizer self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        {
            var context = new PropertyContext<int>(self, Microsoft.Maui.Controls.ClickGestureRecognizer.NumberOfClicksRequiredProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.ClickGestureRecognizer> NumberOfClicksRequired(this SettersContext<Microsoft.Maui.Controls.ClickGestureRecognizer> self,
            int numberOfClicksRequired)
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.ClickGestureRecognizer.NumberOfClicksRequiredProperty, Value = numberOfClicksRequired });
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.ClickGestureRecognizer> NumberOfClicksRequired(this SettersContext<Microsoft.Maui.Controls.ClickGestureRecognizer> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        {
            var context = new PropertySettersContext<int>(self.XamlSetters, Microsoft.Maui.Controls.ClickGestureRecognizer.NumberOfClicksRequiredProperty);
            configure(context).Build();
            return self;
        }
        
        public static Microsoft.Maui.Controls.ClickGestureRecognizer Buttons(this Microsoft.Maui.Controls.ClickGestureRecognizer self,
            Microsoft.Maui.Controls.ButtonsMask buttons)
        {
            self.SetValue(Microsoft.Maui.Controls.ClickGestureRecognizer.ButtonsProperty, buttons);
            return self;
        }
        
        public static Microsoft.Maui.Controls.ClickGestureRecognizer Buttons(this Microsoft.Maui.Controls.ClickGestureRecognizer self, Func<PropertyContext<Microsoft.Maui.Controls.ButtonsMask>, IPropertyBuilder<Microsoft.Maui.Controls.ButtonsMask>> configure)
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.ButtonsMask>(self, Microsoft.Maui.Controls.ClickGestureRecognizer.ButtonsProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.ClickGestureRecognizer> Buttons(this SettersContext<Microsoft.Maui.Controls.ClickGestureRecognizer> self,
            Microsoft.Maui.Controls.ButtonsMask buttons)
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.ClickGestureRecognizer.ButtonsProperty, Value = buttons });
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.ClickGestureRecognizer> Buttons(this SettersContext<Microsoft.Maui.Controls.ClickGestureRecognizer> self, Func<PropertySettersContext<Microsoft.Maui.Controls.ButtonsMask>, IPropertySettersBuilder<Microsoft.Maui.Controls.ButtonsMask>> configure)
        {
            var context = new PropertySettersContext<Microsoft.Maui.Controls.ButtonsMask>(self.XamlSetters, Microsoft.Maui.Controls.ClickGestureRecognizer.ButtonsProperty);
            configure(context).Build();
            return self;
        }
        
        public static Microsoft.Maui.Controls.ClickGestureRecognizer OnClicked(this Microsoft.Maui.Controls.ClickGestureRecognizer self, System.EventHandler handler)
        {
            self.Clicked += handler;
            return self;
        }
        
        public static Microsoft.Maui.Controls.ClickGestureRecognizer OnClicked(this Microsoft.Maui.Controls.ClickGestureRecognizer self, System.Action<Microsoft.Maui.Controls.ClickGestureRecognizer> action)
        {
            self.Clicked += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
