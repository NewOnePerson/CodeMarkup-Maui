﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class SwitchExtension
    {
        public static T OnColor<T>(this T self,
            Microsoft.Maui.Graphics.Color onColor)
            where T : Microsoft.Maui.Controls.Switch
        {
            self.SetValue(Microsoft.Maui.Controls.Switch.OnColorProperty, onColor);
            return self;
        }
        
        public static T OnColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.Switch
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.Switch.OnColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> OnColor<T>(this SettersContext<T> self,
            Microsoft.Maui.Graphics.Color onColor)
            where T : Microsoft.Maui.Controls.Switch
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Switch.OnColorProperty, Value = onColor });
            return self;
        }
        
        public static SettersContext<T> OnColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.Switch
        {
            var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, Microsoft.Maui.Controls.Switch.OnColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateOnColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Switch
        {
            Microsoft.Maui.Graphics.Color fromValue = self.OnColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.OnColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateOnColorTo", transform, callback, length, easing);
        }
        
        public static T ThumbColor<T>(this T self,
            Microsoft.Maui.Graphics.Color thumbColor)
            where T : Microsoft.Maui.Controls.Switch
        {
            self.SetValue(Microsoft.Maui.Controls.Switch.ThumbColorProperty, thumbColor);
            return self;
        }
        
        public static T ThumbColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.Switch
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.Switch.ThumbColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> ThumbColor<T>(this SettersContext<T> self,
            Microsoft.Maui.Graphics.Color thumbColor)
            where T : Microsoft.Maui.Controls.Switch
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Switch.ThumbColorProperty, Value = thumbColor });
            return self;
        }
        
        public static SettersContext<T> ThumbColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.Switch
        {
            var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, Microsoft.Maui.Controls.Switch.ThumbColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateThumbColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Switch
        {
            Microsoft.Maui.Graphics.Color fromValue = self.ThumbColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.ThumbColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateThumbColorTo", transform, callback, length, easing);
        }
        
        public static T IsToggled<T>(this T self,
            bool isToggled)
            where T : Microsoft.Maui.Controls.Switch
        {
            self.SetValue(Microsoft.Maui.Controls.Switch.IsToggledProperty, isToggled);
            return self;
        }
        
        public static T IsToggled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.Switch
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.Switch.IsToggledProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> IsToggled<T>(this SettersContext<T> self,
            bool isToggled)
            where T : Microsoft.Maui.Controls.Switch
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Switch.IsToggledProperty, Value = isToggled });
            return self;
        }
        
        public static SettersContext<T> IsToggled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.Switch
        {
            var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.Switch.IsToggledProperty);
            configure(context).Build();
            return self;
        }
        
        public static T OnToggled<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.ToggledEventArgs> handler)
            where T : Microsoft.Maui.Controls.Switch
        {
            self.Toggled += handler;
            return self;
        }
        
        public static T OnToggled<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Switch
        {
            self.Toggled += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
