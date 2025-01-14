﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class ItemsViewOfCellExtension
    {
        public static T ItemsSource<T>(this T self,
            System.Collections.IEnumerable itemsSource)
            where T : Microsoft.Maui.Controls.ItemsView<Microsoft.Maui.Controls.Cell>
        {
            self.SetValue(Microsoft.Maui.Controls.ItemsView<Microsoft.Maui.Controls.Cell>.ItemsSourceProperty, itemsSource);
            return self;
        }
        
        public static T ItemsSource<T>(this T self, Func<PropertyContext<System.Collections.IEnumerable>, IPropertyBuilder<System.Collections.IEnumerable>> configure)
            where T : Microsoft.Maui.Controls.ItemsView<Microsoft.Maui.Controls.Cell>
        {
            var context = new PropertyContext<System.Collections.IEnumerable>(self, Microsoft.Maui.Controls.ItemsView<Microsoft.Maui.Controls.Cell>.ItemsSourceProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> ItemsSource<T>(this SettersContext<T> self,
            System.Collections.IEnumerable itemsSource)
            where T : Microsoft.Maui.Controls.ItemsView<Microsoft.Maui.Controls.Cell>
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.ItemsView<Microsoft.Maui.Controls.Cell>.ItemsSourceProperty, Value = itemsSource });
            return self;
        }
        
        public static SettersContext<T> ItemsSource<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Collections.IEnumerable>, IPropertySettersBuilder<System.Collections.IEnumerable>> configure)
            where T : Microsoft.Maui.Controls.ItemsView<Microsoft.Maui.Controls.Cell>
        {
            var context = new PropertySettersContext<System.Collections.IEnumerable>(self.XamlSetters, Microsoft.Maui.Controls.ItemsView<Microsoft.Maui.Controls.Cell>.ItemsSourceProperty);
            configure(context).Build();
            return self;
        }
        
        public static T ItemTemplate<T>(this T self,
            Microsoft.Maui.Controls.DataTemplate itemTemplate)
            where T : Microsoft.Maui.Controls.ItemsView<Microsoft.Maui.Controls.Cell>
        {
            self.SetValue(Microsoft.Maui.Controls.ItemsView<Microsoft.Maui.Controls.Cell>.ItemTemplateProperty, itemTemplate);
            return self;
        }
        
        public static T ItemTemplate<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.DataTemplate>, IPropertyBuilder<Microsoft.Maui.Controls.DataTemplate>> configure)
            where T : Microsoft.Maui.Controls.ItemsView<Microsoft.Maui.Controls.Cell>
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.DataTemplate>(self, Microsoft.Maui.Controls.ItemsView<Microsoft.Maui.Controls.Cell>.ItemTemplateProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> ItemTemplate<T>(this SettersContext<T> self,
            Microsoft.Maui.Controls.DataTemplate itemTemplate)
            where T : Microsoft.Maui.Controls.ItemsView<Microsoft.Maui.Controls.Cell>
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.ItemsView<Microsoft.Maui.Controls.Cell>.ItemTemplateProperty, Value = itemTemplate });
            return self;
        }
        
        public static SettersContext<T> ItemTemplate<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.DataTemplate>, IPropertySettersBuilder<Microsoft.Maui.Controls.DataTemplate>> configure)
            where T : Microsoft.Maui.Controls.ItemsView<Microsoft.Maui.Controls.Cell>
        {
            var context = new PropertySettersContext<Microsoft.Maui.Controls.DataTemplate>(self.XamlSetters, Microsoft.Maui.Controls.ItemsView<Microsoft.Maui.Controls.Cell>.ItemTemplateProperty);
            configure(context).Build();
            return self;
        }
        
        public static T ItemTemplate<T>(this T self, System.Func<object> loadTemplate)
            where T : Microsoft.Maui.Controls.ItemsView<Microsoft.Maui.Controls.Cell>
        {
            self.SetValue(Microsoft.Maui.Controls.ItemsView<Microsoft.Maui.Controls.Cell>.ItemTemplateProperty, new DataTemplate(loadTemplate));
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
