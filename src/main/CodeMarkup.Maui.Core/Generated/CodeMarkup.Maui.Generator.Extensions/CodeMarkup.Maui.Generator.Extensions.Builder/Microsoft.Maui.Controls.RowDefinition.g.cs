﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class RowDefinitionExtension
    {
        public static Microsoft.Maui.Controls.RowDefinition Height(this Microsoft.Maui.Controls.RowDefinition self,
            Microsoft.Maui.GridLength height)
        {
            self.SetValue(Microsoft.Maui.Controls.RowDefinition.HeightProperty, height);
            return self;
        }
        
        public static Microsoft.Maui.Controls.RowDefinition Height(this Microsoft.Maui.Controls.RowDefinition self, Func<PropertyContext<Microsoft.Maui.GridLength>, IPropertyBuilder<Microsoft.Maui.GridLength>> configure)
        {
            var context = new PropertyContext<Microsoft.Maui.GridLength>(self, Microsoft.Maui.Controls.RowDefinition.HeightProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.RowDefinition> Height(this SettersContext<Microsoft.Maui.Controls.RowDefinition> self,
            Microsoft.Maui.GridLength height)
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.RowDefinition.HeightProperty, Value = height });
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.RowDefinition> Height(this SettersContext<Microsoft.Maui.Controls.RowDefinition> self, Func<PropertySettersContext<Microsoft.Maui.GridLength>, IPropertySettersBuilder<Microsoft.Maui.GridLength>> configure)
        {
            var context = new PropertySettersContext<Microsoft.Maui.GridLength>(self.XamlSetters, Microsoft.Maui.Controls.RowDefinition.HeightProperty);
            configure(context).Build();
            return self;
        }
        
        public static Microsoft.Maui.Controls.RowDefinition OnSizeChanged(this Microsoft.Maui.Controls.RowDefinition self, System.EventHandler handler)
        {
            self.SizeChanged += handler;
            return self;
        }
        
        public static Microsoft.Maui.Controls.RowDefinition OnSizeChanged(this Microsoft.Maui.Controls.RowDefinition self, System.Action<Microsoft.Maui.Controls.RowDefinition> action)
        {
            self.SizeChanged += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
