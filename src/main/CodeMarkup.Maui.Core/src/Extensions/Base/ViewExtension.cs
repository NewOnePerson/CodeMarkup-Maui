﻿using System;
using System.Collections;

namespace CodeMarkup.Maui
{

    [AttachedProperties(typeof(Microsoft.Maui.Controls.Grid))]
    public interface IViewGridAttachedProperties
    {
        int Column { get; set; }
        int Row { get; set; }
        int ColumnSpan { get; set; }
        int RowSpan { get; set; }
    }

    [AttachedProperties(typeof(Microsoft.Maui.Controls.AbsoluteLayout))]
    public interface IViewAbsoluteLayoutProperties
    {
        [AttachedName("LayoutFlagsProperty")]
        Microsoft.Maui.Layouts.AbsoluteLayoutFlags AbsoluteLayoutFlags { get; set; }

        [AttachedName("LayoutBoundsProperty")]
        Microsoft.Maui.Graphics.Rect AbsoluteLayoutBounds { get; set; }
    }

    [AttachedInterfaces(typeof(Microsoft.Maui.Controls.View), new[] { typeof(IViewGridAttachedProperties), typeof(IViewAbsoluteLayoutProperties) })]
    public static partial class ViewExtension
    {
        public static T GridSpan<T>(this T self, int column = 1, int row = 1) where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.Grid.ColumnSpanProperty, column);
            self.SetValue(Microsoft.Maui.Controls.Grid.RowSpanProperty, row);
            return self;
        }

        // --- Padding

        public static T Padding<T>(this T self, double horizontalSize, double verticalSize)
            where T : Microsoft.Maui.Controls.Border
        {
            self.SetValue(Microsoft.Maui.Controls.Border.PaddingProperty, new Thickness(horizontalSize, verticalSize));
            return self;
        }

        public static T Padding<T>(this T self, double left, double top, double right, double bottom)
            where T : Microsoft.Maui.Controls.Border
        {
            self.SetValue(Microsoft.Maui.Controls.Border.PaddingProperty, new Thickness(left, top, right, bottom));
            return self;
        }

        public static T Padding<T>(this T self, object _ = null, double left = 0, double top = 0, double right = 0, double bottom = 0)
        where T : Microsoft.Maui.Controls.Border
        {
            self.SetValue(Microsoft.Maui.Controls.Border.PaddingProperty, new Thickness(left, top, right, bottom));
            return self;
        }

        // --- Margin

        public static T Margin<T>(this T self, double horizontalSize, double verticalSize)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.View.MarginProperty, new Thickness(horizontalSize, verticalSize));
            return self;
        }

        public static T Margin<T>(this T self, double left, double top, double right, double bottom)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.View.MarginProperty, new Thickness(left, top, right, bottom));
            return self;
        }

        public static T Margin<T>(this T self, object _ = null, double left = 0, double top = 0, double right = 0, double bottom = 0)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.View.MarginProperty, new Thickness(left, top, right, bottom));
            return self;
        }

        // --- AbsoluteLayout

        public static T AbsoluteLayoutBounds<T>(this T self, double x, double y, double width, double height)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.AbsoluteLayout.LayoutBoundsProperty, new Rect(x, y, width, height));
            return self;
        }

        // --- Layout

        public static T CenterHorizontally<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.View.HorizontalOptionsProperty, LayoutOptions.Center);
            return self;
        }

        public static T CenterVertically<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.View.VerticalOptionsProperty, LayoutOptions.Center);
            return self;
        }

        public static T Center<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.View.HorizontalOptionsProperty, LayoutOptions.Center);
            self.SetValue(Microsoft.Maui.Controls.View.VerticalOptionsProperty, LayoutOptions.Center);
            return self;
        }

        public static T AlignTop<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.View.VerticalOptionsProperty, LayoutOptions.Start);
            return self;
        }

        public static T AlignTopStart<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.View.VerticalOptionsProperty, LayoutOptions.Start);
            self.SetValue(Microsoft.Maui.Controls.View.HorizontalOptionsProperty, LayoutOptions.Start);
            return self;
        }

        public static T AlignTopEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.View.VerticalOptionsProperty, LayoutOptions.Start);
            self.SetValue(Microsoft.Maui.Controls.View.HorizontalOptionsProperty, LayoutOptions.End);
            return self;
        }

        public static T AlignBottom<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.View.VerticalOptionsProperty, LayoutOptions.End);
            return self;
        }

        public static T AlignBottomStart<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.View.VerticalOptionsProperty, LayoutOptions.End);
            self.SetValue(Microsoft.Maui.Controls.View.HorizontalOptionsProperty, LayoutOptions.Start);
            return self;
        }

        public static T AlignBottomEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.View.VerticalOptionsProperty, LayoutOptions.End);
            self.SetValue(Microsoft.Maui.Controls.View.HorizontalOptionsProperty, LayoutOptions.End);
            return self;
        }

        public static T AlignStart<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.View.HorizontalOptionsProperty, LayoutOptions.Start);
            return self;
        }

        public static T AlignEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.View.HorizontalOptionsProperty, LayoutOptions.End);
            return self;
        }

        public static T FillHorizontally<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.View.HorizontalOptionsProperty, LayoutOptions.Fill);
            return self;
        }

        public static T FillVertically<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.View.VerticalOptionsProperty, LayoutOptions.Fill);
            return self;
        }

        public static T FillBothDirections<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValue(Microsoft.Maui.Controls.View.HorizontalOptionsProperty, LayoutOptions.Fill);
            self.SetValue(Microsoft.Maui.Controls.View.VerticalOptionsProperty, LayoutOptions.Fill);
            return self;
        }

        // ---------------------------- SETTERS -------------------------------

        public static SettersContext<T> GridSpan<T>(this SettersContext<T> self, int column = 1, int row = 1) where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Grid.ColumnSpanProperty, Value = column });
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Grid.RowSpanProperty, Value = row });
            return self;
        }

        // --- Padding

        public static SettersContext<T> Padding<T>(this SettersContext<T> self, double horizontalSize, double verticalSize)
            where T : Microsoft.Maui.Controls.Border
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Border.PaddingProperty, Value = new Thickness(horizontalSize, verticalSize) });
            return self;
        }

        public static SettersContext<T> Padding<T>(this SettersContext<T> self, double left, double top, double right, double bottom)
            where T : Microsoft.Maui.Controls.Border
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Border.PaddingProperty, Value = new Thickness(left, top, right, bottom) });
            return self;
        }

        public static SettersContext<T> Padding<T>(this SettersContext<T> self, object _ = null, double left = 0, double top = 0, double right = 0, double bottom = 0)
        where T : Microsoft.Maui.Controls.Border
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Border.PaddingProperty, Value = new Thickness(left, top, right, bottom) });
            return self;
        }

        // --- Margin

        public static SettersContext<T> Margin<T>(this SettersContext<T> self, double horizontalSize, double verticalSize)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.MarginProperty, Value = new Thickness(horizontalSize, verticalSize) });
            return self;
        }

        public static SettersContext<T> Margin<T>(this SettersContext<T> self, double left, double top, double right, double bottom)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.MarginProperty, Value = new Thickness(left, top, right, bottom) });
            return self;
        }

        public static SettersContext<T> Margin<T>(this SettersContext<T> self, object _ = null, double left = 0, double top = 0, double right = 0, double bottom = 0)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.MarginProperty, Value = new Thickness(left, top, right, bottom) });
            return self;
        }

        // --- AbsoluteLayout

        public static SettersContext<T> AbsoluteLayoutBounds<T>(this SettersContext<T> self, double x, double y, double width, double height)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.AbsoluteLayout.LayoutBoundsProperty, Value = new Rect(x, y, width, height) });
            return self;
        }

        // --- Layout

        public static SettersContext<T> CenterHorizontally<T>(this SettersContext<T> self)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.HorizontalOptionsProperty, Value = LayoutOptions.Center });
            return self;
        }

        public static SettersContext<T> CenterVertically<T>(this SettersContext<T> self)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.VerticalOptionsProperty, Value = LayoutOptions.Center });
            return self;
        }

        public static SettersContext<T> Center<T>(this SettersContext<T> self)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.HorizontalOptionsProperty, Value = LayoutOptions.Center });
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.VerticalOptionsProperty, Value = LayoutOptions.Center });
            return self;
        }

        public static SettersContext<T> AlignTop<T>(this SettersContext<T> self)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.VerticalOptionsProperty, Value = LayoutOptions.Start });
            return self;
        }

        public static SettersContext<T> AlignTopStart<T>(this SettersContext<T> self)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.VerticalOptionsProperty, Value = LayoutOptions.Start });
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.HorizontalOptionsProperty, Value = LayoutOptions.Start });
            return self;
        }

        public static SettersContext<T> AlignTopEnd<T>(this SettersContext<T> self)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.VerticalOptionsProperty, Value = LayoutOptions.Start });
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.HorizontalOptionsProperty, Value = LayoutOptions.End });
            return self;
        }

        public static SettersContext<T> AlignBottom<T>(this SettersContext<T> self)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.VerticalOptionsProperty, Value = LayoutOptions.End });
            return self;
        }

        public static SettersContext<T> AlignBottomStart<T>(this SettersContext<T> self)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.VerticalOptionsProperty, Value = LayoutOptions.End });
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.HorizontalOptionsProperty, Value = LayoutOptions.Start });
            return self;
        }

        public static SettersContext<T> AlignBottomEnd<T>(this SettersContext<T> self)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.VerticalOptionsProperty, Value = LayoutOptions.End });
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.HorizontalOptionsProperty, Value = LayoutOptions.End });            return self;
        }

        public static SettersContext<T> AlignStart<T>(this SettersContext<T> self)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.HorizontalOptionsProperty, Value = LayoutOptions.Start });
            return self;
        }

        public static SettersContext<T> AlignEnd<T>(this SettersContext<T> self)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.HorizontalOptionsProperty, Value = LayoutOptions.End });
            return self;
        }

        public static SettersContext<T> FillHorizontally<T>(this SettersContext<T> self)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.HorizontalOptionsProperty, Value = LayoutOptions.Fill });
            return self;
        }

        public static SettersContext<T> FillVertically<T>(this SettersContext<T> self)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.VerticalOptionsProperty, Value = LayoutOptions.Fill });
            return self;
        }

        public static SettersContext<T> FillBothDirections<T>(this SettersContext<T> self)
            where T : Microsoft.Maui.Controls.View
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.HorizontalOptionsProperty, Value = LayoutOptions.Fill });
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.View.VerticalOptionsProperty, Value = LayoutOptions.Fill });
            return self;
        }


    }
}
