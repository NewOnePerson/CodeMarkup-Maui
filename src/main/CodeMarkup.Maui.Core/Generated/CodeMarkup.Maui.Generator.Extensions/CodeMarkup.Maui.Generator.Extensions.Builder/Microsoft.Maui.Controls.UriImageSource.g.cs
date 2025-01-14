﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class UriImageSourceExtension
    {
        public static Microsoft.Maui.Controls.UriImageSource CacheValidity(this Microsoft.Maui.Controls.UriImageSource self,
            System.TimeSpan cacheValidity)
        {
            self.SetValue(Microsoft.Maui.Controls.UriImageSource.CacheValidityProperty, cacheValidity);
            return self;
        }
        
        public static Microsoft.Maui.Controls.UriImageSource CacheValidity(this Microsoft.Maui.Controls.UriImageSource self, Func<PropertyContext<System.TimeSpan>, IPropertyBuilder<System.TimeSpan>> configure)
        {
            var context = new PropertyContext<System.TimeSpan>(self, Microsoft.Maui.Controls.UriImageSource.CacheValidityProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.UriImageSource> CacheValidity(this SettersContext<Microsoft.Maui.Controls.UriImageSource> self,
            System.TimeSpan cacheValidity)
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.UriImageSource.CacheValidityProperty, Value = cacheValidity });
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.UriImageSource> CacheValidity(this SettersContext<Microsoft.Maui.Controls.UriImageSource> self, Func<PropertySettersContext<System.TimeSpan>, IPropertySettersBuilder<System.TimeSpan>> configure)
        {
            var context = new PropertySettersContext<System.TimeSpan>(self.XamlSetters, Microsoft.Maui.Controls.UriImageSource.CacheValidityProperty);
            configure(context).Build();
            return self;
        }
        
        public static Microsoft.Maui.Controls.UriImageSource CachingEnabled(this Microsoft.Maui.Controls.UriImageSource self,
            bool cachingEnabled)
        {
            self.SetValue(Microsoft.Maui.Controls.UriImageSource.CachingEnabledProperty, cachingEnabled);
            return self;
        }
        
        public static Microsoft.Maui.Controls.UriImageSource CachingEnabled(this Microsoft.Maui.Controls.UriImageSource self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.UriImageSource.CachingEnabledProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.UriImageSource> CachingEnabled(this SettersContext<Microsoft.Maui.Controls.UriImageSource> self,
            bool cachingEnabled)
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.UriImageSource.CachingEnabledProperty, Value = cachingEnabled });
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.UriImageSource> CachingEnabled(this SettersContext<Microsoft.Maui.Controls.UriImageSource> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        {
            var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.UriImageSource.CachingEnabledProperty);
            configure(context).Build();
            return self;
        }
        
        public static Microsoft.Maui.Controls.UriImageSource Uri(this Microsoft.Maui.Controls.UriImageSource self,
            System.Uri uri)
        {
            self.SetValue(Microsoft.Maui.Controls.UriImageSource.UriProperty, uri);
            return self;
        }
        
        public static Microsoft.Maui.Controls.UriImageSource Uri(this Microsoft.Maui.Controls.UriImageSource self, Func<PropertyContext<System.Uri>, IPropertyBuilder<System.Uri>> configure)
        {
            var context = new PropertyContext<System.Uri>(self, Microsoft.Maui.Controls.UriImageSource.UriProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.UriImageSource> Uri(this SettersContext<Microsoft.Maui.Controls.UriImageSource> self,
            System.Uri uri)
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.UriImageSource.UriProperty, Value = uri });
            return self;
        }
        
        public static SettersContext<Microsoft.Maui.Controls.UriImageSource> Uri(this SettersContext<Microsoft.Maui.Controls.UriImageSource> self, Func<PropertySettersContext<System.Uri>, IPropertySettersBuilder<System.Uri>> configure)
        {
            var context = new PropertySettersContext<System.Uri>(self.XamlSetters, Microsoft.Maui.Controls.UriImageSource.UriProperty);
            configure(context).Build();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
