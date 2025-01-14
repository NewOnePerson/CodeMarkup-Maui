﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class ScrollViewExtension
    {
        public static T LayoutAreaOverride<T>(this T self,
            Microsoft.Maui.Graphics.Rect layoutAreaOverride)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            self.LayoutAreaOverride = layoutAreaOverride;
            return self;
        }
        
        public static T Content<T>(this T self,
            Microsoft.Maui.Controls.View content)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            self.Content = content;
            return self;
        }
        
        public static T Orientation<T>(this T self,
            Microsoft.Maui.ScrollOrientation orientation)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            self.SetValue(Microsoft.Maui.Controls.ScrollView.OrientationProperty, orientation);
            return self;
        }
        
        public static T Orientation<T>(this T self, Func<PropertyContext<Microsoft.Maui.ScrollOrientation>, IPropertyBuilder<Microsoft.Maui.ScrollOrientation>> configure)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            var context = new PropertyContext<Microsoft.Maui.ScrollOrientation>(self, Microsoft.Maui.Controls.ScrollView.OrientationProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Orientation<T>(this SettersContext<T> self,
            Microsoft.Maui.ScrollOrientation orientation)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.ScrollView.OrientationProperty, Value = orientation });
            return self;
        }
        
        public static SettersContext<T> Orientation<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.ScrollOrientation>, IPropertySettersBuilder<Microsoft.Maui.ScrollOrientation>> configure)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            var context = new PropertySettersContext<Microsoft.Maui.ScrollOrientation>(self.XamlSetters, Microsoft.Maui.Controls.ScrollView.OrientationProperty);
            configure(context).Build();
            return self;
        }
        
        public static T HorizontalScrollBarVisibility<T>(this T self,
            Microsoft.Maui.ScrollBarVisibility horizontalScrollBarVisibility)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            self.SetValue(Microsoft.Maui.Controls.ScrollView.HorizontalScrollBarVisibilityProperty, horizontalScrollBarVisibility);
            return self;
        }
        
        public static T HorizontalScrollBarVisibility<T>(this T self, Func<PropertyContext<Microsoft.Maui.ScrollBarVisibility>, IPropertyBuilder<Microsoft.Maui.ScrollBarVisibility>> configure)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            var context = new PropertyContext<Microsoft.Maui.ScrollBarVisibility>(self, Microsoft.Maui.Controls.ScrollView.HorizontalScrollBarVisibilityProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> HorizontalScrollBarVisibility<T>(this SettersContext<T> self,
            Microsoft.Maui.ScrollBarVisibility horizontalScrollBarVisibility)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.ScrollView.HorizontalScrollBarVisibilityProperty, Value = horizontalScrollBarVisibility });
            return self;
        }
        
        public static SettersContext<T> HorizontalScrollBarVisibility<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.ScrollBarVisibility>, IPropertySettersBuilder<Microsoft.Maui.ScrollBarVisibility>> configure)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            var context = new PropertySettersContext<Microsoft.Maui.ScrollBarVisibility>(self.XamlSetters, Microsoft.Maui.Controls.ScrollView.HorizontalScrollBarVisibilityProperty);
            configure(context).Build();
            return self;
        }
        
        public static T VerticalScrollBarVisibility<T>(this T self,
            Microsoft.Maui.ScrollBarVisibility verticalScrollBarVisibility)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            self.SetValue(Microsoft.Maui.Controls.ScrollView.VerticalScrollBarVisibilityProperty, verticalScrollBarVisibility);
            return self;
        }
        
        public static T VerticalScrollBarVisibility<T>(this T self, Func<PropertyContext<Microsoft.Maui.ScrollBarVisibility>, IPropertyBuilder<Microsoft.Maui.ScrollBarVisibility>> configure)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            var context = new PropertyContext<Microsoft.Maui.ScrollBarVisibility>(self, Microsoft.Maui.Controls.ScrollView.VerticalScrollBarVisibilityProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> VerticalScrollBarVisibility<T>(this SettersContext<T> self,
            Microsoft.Maui.ScrollBarVisibility verticalScrollBarVisibility)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.ScrollView.VerticalScrollBarVisibilityProperty, Value = verticalScrollBarVisibility });
            return self;
        }
        
        public static SettersContext<T> VerticalScrollBarVisibility<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.ScrollBarVisibility>, IPropertySettersBuilder<Microsoft.Maui.ScrollBarVisibility>> configure)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            var context = new PropertySettersContext<Microsoft.Maui.ScrollBarVisibility>(self.XamlSetters, Microsoft.Maui.Controls.ScrollView.VerticalScrollBarVisibilityProperty);
            configure(context).Build();
            return self;
        }
        
        public static T OnScrollToRequested<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.ScrollToRequestedEventArgs> handler)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            self.ScrollToRequested += handler;
            return self;
        }
        
        public static T OnScrollToRequested<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            self.ScrollToRequested += (o, arg) => action(self);
            return self;
        }
        
        public static T OnScrolled<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.ScrolledEventArgs> handler)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            self.Scrolled += handler;
            return self;
        }
        
        public static T OnScrolled<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ScrollView
        {
            self.Scrolled += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
