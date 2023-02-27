﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class UriImageSourceExtension
    {
        public static Microsoft.Maui.Controls.UriImageSource CacheValidity(this Microsoft.Maui.Controls.UriImageSource self,
            System.TimeSpan cacheValidity)
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.UriImageSource.CacheValidityProperty, cacheValidity);
            return self;
        }
        
        public static Microsoft.Maui.Controls.UriImageSource CacheValidity(this Microsoft.Maui.Controls.UriImageSource self, Func<PropertyContext<System.TimeSpan>, IPropertyBuilder<System.TimeSpan>> configure)
        {
            var context = new PropertyContext<System.TimeSpan>(self, Microsoft.Maui.Controls.UriImageSource.CacheValidityProperty);
            configure(context).Build();
            return self;
        }
        
        public static Microsoft.Maui.Controls.UriImageSource CachingEnabled(this Microsoft.Maui.Controls.UriImageSource self,
            bool cachingEnabled)
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.UriImageSource.CachingEnabledProperty, cachingEnabled);
            return self;
        }
        
        public static Microsoft.Maui.Controls.UriImageSource CachingEnabled(this Microsoft.Maui.Controls.UriImageSource self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.UriImageSource.CachingEnabledProperty);
            configure(context).Build();
            return self;
        }
        
        public static Microsoft.Maui.Controls.UriImageSource Uri(this Microsoft.Maui.Controls.UriImageSource self,
            System.Uri uri)
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.UriImageSource.UriProperty, uri);
            return self;
        }
        
        public static Microsoft.Maui.Controls.UriImageSource Uri(this Microsoft.Maui.Controls.UriImageSource self, Func<PropertyContext<System.Uri>, IPropertyBuilder<System.Uri>> configure)
        {
            var context = new PropertyContext<System.Uri>(self, Microsoft.Maui.Controls.UriImageSource.UriProperty);
            configure(context).Build();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
