﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class ViewExtension
    {
        public static T Column<T>(this T self,
            int column)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.Grid.ColumnProperty, column);
            return self;
        }
        
        public static T Column<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.View
        {
            var context = new PropertyContext<int>(self, Microsoft.Maui.Controls.Grid.ColumnProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Column<T>(this SettersContext<T> self,
            int column)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Grid.ColumnProperty, Value = column });
            return self;
        }
        
        public static SettersContext<T> Column<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.View
        {
            var context = new PropertySettersContext<int>(self.XamlSetters, Microsoft.Maui.Controls.Grid.ColumnProperty);
            configure(context).Build();
            return self;
        }
        
        public static int GetColumnValue<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            return (int)self.GetValue(Microsoft.Maui.Controls.Grid.ColumnProperty);
        }
        
        public static T Row<T>(this T self,
            int row)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.Grid.RowProperty, row);
            return self;
        }
        
        public static T Row<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.View
        {
            var context = new PropertyContext<int>(self, Microsoft.Maui.Controls.Grid.RowProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Row<T>(this SettersContext<T> self,
            int row)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Grid.RowProperty, Value = row });
            return self;
        }
        
        public static SettersContext<T> Row<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.View
        {
            var context = new PropertySettersContext<int>(self.XamlSetters, Microsoft.Maui.Controls.Grid.RowProperty);
            configure(context).Build();
            return self;
        }
        
        public static int GetRowValue<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            return (int)self.GetValue(Microsoft.Maui.Controls.Grid.RowProperty);
        }
        
        public static T ColumnSpan<T>(this T self,
            int columnSpan)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.Grid.ColumnSpanProperty, columnSpan);
            return self;
        }
        
        public static T ColumnSpan<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.View
        {
            var context = new PropertyContext<int>(self, Microsoft.Maui.Controls.Grid.ColumnSpanProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> ColumnSpan<T>(this SettersContext<T> self,
            int columnSpan)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Grid.ColumnSpanProperty, Value = columnSpan });
            return self;
        }
        
        public static SettersContext<T> ColumnSpan<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.View
        {
            var context = new PropertySettersContext<int>(self.XamlSetters, Microsoft.Maui.Controls.Grid.ColumnSpanProperty);
            configure(context).Build();
            return self;
        }
        
        public static int GetColumnSpanValue<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            return (int)self.GetValue(Microsoft.Maui.Controls.Grid.ColumnSpanProperty);
        }
        
        public static T RowSpan<T>(this T self,
            int rowSpan)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.Grid.RowSpanProperty, rowSpan);
            return self;
        }
        
        public static T RowSpan<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.View
        {
            var context = new PropertyContext<int>(self, Microsoft.Maui.Controls.Grid.RowSpanProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> RowSpan<T>(this SettersContext<T> self,
            int rowSpan)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Grid.RowSpanProperty, Value = rowSpan });
            return self;
        }
        
        public static SettersContext<T> RowSpan<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.View
        {
            var context = new PropertySettersContext<int>(self.XamlSetters, Microsoft.Maui.Controls.Grid.RowSpanProperty);
            configure(context).Build();
            return self;
        }
        
        public static int GetRowSpanValue<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            return (int)self.GetValue(Microsoft.Maui.Controls.Grid.RowSpanProperty);
        }
        
        public static T AbsoluteLayoutFlags<T>(this T self,
            Microsoft.Maui.Layouts.AbsoluteLayoutFlags absoluteLayoutFlags)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.AbsoluteLayout.LayoutFlagsProperty, absoluteLayoutFlags);
            return self;
        }
        
        public static T AbsoluteLayoutFlags<T>(this T self, Func<PropertyContext<Microsoft.Maui.Layouts.AbsoluteLayoutFlags>, IPropertyBuilder<Microsoft.Maui.Layouts.AbsoluteLayoutFlags>> configure)
            where T : Microsoft.Maui.Controls.View
        {
            var context = new PropertyContext<Microsoft.Maui.Layouts.AbsoluteLayoutFlags>(self, Microsoft.Maui.Controls.AbsoluteLayout.LayoutFlagsProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> AbsoluteLayoutFlags<T>(this SettersContext<T> self,
            Microsoft.Maui.Layouts.AbsoluteLayoutFlags absoluteLayoutFlags)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.AbsoluteLayout.LayoutFlagsProperty, Value = absoluteLayoutFlags });
            return self;
        }
        
        public static SettersContext<T> AbsoluteLayoutFlags<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Layouts.AbsoluteLayoutFlags>, IPropertySettersBuilder<Microsoft.Maui.Layouts.AbsoluteLayoutFlags>> configure)
            where T : Microsoft.Maui.Controls.View
        {
            var context = new PropertySettersContext<Microsoft.Maui.Layouts.AbsoluteLayoutFlags>(self.XamlSetters, Microsoft.Maui.Controls.AbsoluteLayout.LayoutFlagsProperty);
            configure(context).Build();
            return self;
        }
        
        public static Microsoft.Maui.Layouts.AbsoluteLayoutFlags GetAbsoluteLayoutFlagsValue<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            return (Microsoft.Maui.Layouts.AbsoluteLayoutFlags)self.GetValue(Microsoft.Maui.Controls.AbsoluteLayout.LayoutFlagsProperty);
        }
        
        public static T AbsoluteLayoutBounds<T>(this T self,
            Microsoft.Maui.Graphics.Rect absoluteLayoutBounds)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.AbsoluteLayout.LayoutBoundsProperty, absoluteLayoutBounds);
            return self;
        }
        
        public static T AbsoluteLayoutBounds<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Rect>, IPropertyBuilder<Microsoft.Maui.Graphics.Rect>> configure)
            where T : Microsoft.Maui.Controls.View
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Rect>(self, Microsoft.Maui.Controls.AbsoluteLayout.LayoutBoundsProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> AbsoluteLayoutBounds<T>(this SettersContext<T> self,
            Microsoft.Maui.Graphics.Rect absoluteLayoutBounds)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.AbsoluteLayout.LayoutBoundsProperty, Value = absoluteLayoutBounds });
            return self;
        }
        
        public static SettersContext<T> AbsoluteLayoutBounds<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Rect>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Rect>> configure)
            where T : Microsoft.Maui.Controls.View
        {
            var context = new PropertySettersContext<Microsoft.Maui.Graphics.Rect>(self.XamlSetters, Microsoft.Maui.Controls.AbsoluteLayout.LayoutBoundsProperty);
            configure(context).Build();
            return self;
        }
        
        public static Microsoft.Maui.Graphics.Rect GetAbsoluteLayoutBoundsValue<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            return (Microsoft.Maui.Graphics.Rect)self.GetValue(Microsoft.Maui.Controls.AbsoluteLayout.LayoutBoundsProperty);
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
