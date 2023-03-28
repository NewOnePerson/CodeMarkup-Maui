﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class PageExtension
    {
        public static T BackgroundImageSource<T>(this T self,
            Microsoft.Maui.Controls.ImageSource backgroundImageSource)
            where T : Microsoft.Maui.Controls.Page
        {
            self.SetValue(Microsoft.Maui.Controls.Page.BackgroundImageSourceProperty, backgroundImageSource);
            return self;
        }
        
        public static T BackgroundImageSource<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.ImageSource>, IPropertyBuilder<Microsoft.Maui.Controls.ImageSource>> configure)
            where T : Microsoft.Maui.Controls.Page
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.ImageSource>(self, Microsoft.Maui.Controls.Page.BackgroundImageSourceProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> BackgroundImageSource<T>(this SettersContext<T> self,
            Microsoft.Maui.Controls.ImageSource backgroundImageSource)
            where T : Microsoft.Maui.Controls.Page
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Page.BackgroundImageSourceProperty, Value = backgroundImageSource });
            return self;
        }
        
        public static SettersContext<T> BackgroundImageSource<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.ImageSource>, IPropertySettersBuilder<Microsoft.Maui.Controls.ImageSource>> configure)
            where T : Microsoft.Maui.Controls.Page
        {
            var context = new PropertySettersContext<Microsoft.Maui.Controls.ImageSource>(self.XamlSetters, Microsoft.Maui.Controls.Page.BackgroundImageSourceProperty);
            configure(context).Build();
            return self;
        }
        
        public static T IconImageSource<T>(this T self,
            Microsoft.Maui.Controls.ImageSource iconImageSource)
            where T : Microsoft.Maui.Controls.Page
        {
            self.SetValue(Microsoft.Maui.Controls.Page.IconImageSourceProperty, iconImageSource);
            return self;
        }
        
        public static T IconImageSource<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.ImageSource>, IPropertyBuilder<Microsoft.Maui.Controls.ImageSource>> configure)
            where T : Microsoft.Maui.Controls.Page
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.ImageSource>(self, Microsoft.Maui.Controls.Page.IconImageSourceProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> IconImageSource<T>(this SettersContext<T> self,
            Microsoft.Maui.Controls.ImageSource iconImageSource)
            where T : Microsoft.Maui.Controls.Page
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Page.IconImageSourceProperty, Value = iconImageSource });
            return self;
        }
        
        public static SettersContext<T> IconImageSource<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.ImageSource>, IPropertySettersBuilder<Microsoft.Maui.Controls.ImageSource>> configure)
            where T : Microsoft.Maui.Controls.Page
        {
            var context = new PropertySettersContext<Microsoft.Maui.Controls.ImageSource>(self.XamlSetters, Microsoft.Maui.Controls.Page.IconImageSourceProperty);
            configure(context).Build();
            return self;
        }
        
        public static T IsBusy<T>(this T self,
            bool isBusy)
            where T : Microsoft.Maui.Controls.Page
        {
            self.SetValue(Microsoft.Maui.Controls.Page.IsBusyProperty, isBusy);
            return self;
        }
        
        public static T IsBusy<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.Page
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.Page.IsBusyProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> IsBusy<T>(this SettersContext<T> self,
            bool isBusy)
            where T : Microsoft.Maui.Controls.Page
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Page.IsBusyProperty, Value = isBusy });
            return self;
        }
        
        public static SettersContext<T> IsBusy<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.Page
        {
            var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.Page.IsBusyProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Padding<T>(this T self,
            Microsoft.Maui.Thickness padding)
            where T : Microsoft.Maui.Controls.Page
        {
            self.SetValue(Microsoft.Maui.Controls.Page.PaddingProperty, padding);
            return self;
        }
        
        public static T Padding<T>(this T self, Func<PropertyContext<Microsoft.Maui.Thickness>, IPropertyBuilder<Microsoft.Maui.Thickness>> configure)
            where T : Microsoft.Maui.Controls.Page
        {
            var context = new PropertyContext<Microsoft.Maui.Thickness>(self, Microsoft.Maui.Controls.Page.PaddingProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Padding<T>(this SettersContext<T> self,
            Microsoft.Maui.Thickness padding)
            where T : Microsoft.Maui.Controls.Page
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Page.PaddingProperty, Value = padding });
            return self;
        }
        
        public static SettersContext<T> Padding<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Thickness>, IPropertySettersBuilder<Microsoft.Maui.Thickness>> configure)
            where T : Microsoft.Maui.Controls.Page
        {
            var context = new PropertySettersContext<Microsoft.Maui.Thickness>(self.XamlSetters, Microsoft.Maui.Controls.Page.PaddingProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Title<T>(this T self,
            string title)
            where T : Microsoft.Maui.Controls.Page
        {
            self.SetValue(Microsoft.Maui.Controls.Page.TitleProperty, title);
            return self;
        }
        
        public static T Title<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.Page
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.Page.TitleProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Title<T>(this SettersContext<T> self,
            string title)
            where T : Microsoft.Maui.Controls.Page
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Page.TitleProperty, Value = title });
            return self;
        }
        
        public static SettersContext<T> Title<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.Page
        {
            var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.Page.TitleProperty);
            configure(context).Build();
            return self;
        }
        
        public static T ToolbarItems<T>(this T self,
            IList<Microsoft.Maui.Controls.ToolbarItem> toolbarItems)
            where T : Microsoft.Maui.Controls.Page
        {
            foreach (var item in toolbarItems)
                self.ToolbarItems.Add(item);
            return self;
        }

        public static T ToolbarItems<T>(this T self,
            params Microsoft.Maui.Controls.ToolbarItem[] toolbarItems)
            where T : Microsoft.Maui.Controls.Page
        {
            foreach (var item in toolbarItems)
                self.ToolbarItems.Add(item);
            return self;
        }
        
        public static T MenuBarItems<T>(this T self,
            IList<Microsoft.Maui.Controls.MenuBarItem> menuBarItems)
            where T : Microsoft.Maui.Controls.Page
        {
            foreach (var item in menuBarItems)
                self.MenuBarItems.Add(item);
            return self;
        }

        public static T MenuBarItems<T>(this T self,
            params Microsoft.Maui.Controls.MenuBarItem[] menuBarItems)
            where T : Microsoft.Maui.Controls.Page
        {
            foreach (var item in menuBarItems)
                self.MenuBarItems.Add(item);
            return self;
        }
        
        public static T ContainerArea<T>(this T self,
            Microsoft.Maui.Graphics.Rect containerArea)
            where T : Microsoft.Maui.Controls.Page
        {
            self.ContainerArea = containerArea;
            return self;
        }
        
        public static T IgnoresContainerArea<T>(this T self,
            bool ignoresContainerArea)
            where T : Microsoft.Maui.Controls.Page
        {
            self.IgnoresContainerArea = ignoresContainerArea;
            return self;
        }
        
        public static T InternalChildren<T>(this T self,
            IList<Microsoft.Maui.Controls.Element> internalChildren)
            where T : Microsoft.Maui.Controls.Page
        {
            foreach (var item in internalChildren)
                self.InternalChildren.Add(item);
            return self;
        }

        public static T InternalChildren<T>(this T self,
            params Microsoft.Maui.Controls.Element[] internalChildren)
            where T : Microsoft.Maui.Controls.Page
        {
            foreach (var item in internalChildren)
                self.InternalChildren.Add(item);
            return self;
        }
        
        public static T OnNavigatedTo<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.NavigatedToEventArgs> handler)
            where T : Microsoft.Maui.Controls.Page
        {
            self.NavigatedTo += handler;
            return self;
        }
        
        public static T OnNavigatedTo<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Page
        {
            self.NavigatedTo += (o, arg) => action(self);
            return self;
        }
        
        public static T OnNavigatingFrom<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.NavigatingFromEventArgs> handler)
            where T : Microsoft.Maui.Controls.Page
        {
            self.NavigatingFrom += handler;
            return self;
        }
        
        public static T OnNavigatingFrom<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Page
        {
            self.NavigatingFrom += (o, arg) => action(self);
            return self;
        }
        
        public static T OnNavigatedFrom<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.NavigatedFromEventArgs> handler)
            where T : Microsoft.Maui.Controls.Page
        {
            self.NavigatedFrom += handler;
            return self;
        }
        
        public static T OnNavigatedFrom<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Page
        {
            self.NavigatedFrom += (o, arg) => action(self);
            return self;
        }
        
        public static T OnLayoutChanged<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Page
        {
            self.LayoutChanged += handler;
            return self;
        }
        
        public static T OnLayoutChanged<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Page
        {
            self.LayoutChanged += (o, arg) => action(self);
            return self;
        }
        
        public static T OnAppearing<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Page
        {
            self.Appearing += handler;
            return self;
        }
        
        public static T OnAppearing<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Page
        {
            self.Appearing += (o, arg) => action(self);
            return self;
        }
        
        public static T OnDisappearing<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Page
        {
            self.Disappearing += handler;
            return self;
        }
        
        public static T OnDisappearing<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Page
        {
            self.Disappearing += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
