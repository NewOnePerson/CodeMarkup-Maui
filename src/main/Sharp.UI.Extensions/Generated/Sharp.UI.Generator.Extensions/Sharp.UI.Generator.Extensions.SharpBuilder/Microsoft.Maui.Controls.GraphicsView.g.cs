﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class GraphicsViewExtension
    {
        public static T Drawable<T>(this T self,
            Microsoft.Maui.Graphics.IDrawable drawable)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.GraphicsView.DrawableProperty, drawable);
            return self;
        }
        
        public static T Drawable<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.IDrawable>, IPropertyBuilder<Microsoft.Maui.Graphics.IDrawable>> configure)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.IDrawable>(self, Microsoft.Maui.Controls.GraphicsView.DrawableProperty);
            configure(context).Build();
            return self;
        }
        
        public static T OnStartHoverInteraction<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.TouchEventArgs> handler)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            self.StartHoverInteraction += handler;
            return self;
        }
        
        public static T OnStartHoverInteraction<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            self.StartHoverInteraction += (o, arg) => action(self);
            return self;
        }
        
        public static T OnMoveHoverInteraction<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.TouchEventArgs> handler)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            self.MoveHoverInteraction += handler;
            return self;
        }
        
        public static T OnMoveHoverInteraction<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            self.MoveHoverInteraction += (o, arg) => action(self);
            return self;
        }
        
        public static T OnEndHoverInteraction<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            self.EndHoverInteraction += handler;
            return self;
        }
        
        public static T OnEndHoverInteraction<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            self.EndHoverInteraction += (o, arg) => action(self);
            return self;
        }
        
        public static T OnStartInteraction<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.TouchEventArgs> handler)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            self.StartInteraction += handler;
            return self;
        }
        
        public static T OnStartInteraction<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            self.StartInteraction += (o, arg) => action(self);
            return self;
        }
        
        public static T OnDragInteraction<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.TouchEventArgs> handler)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            self.DragInteraction += handler;
            return self;
        }
        
        public static T OnDragInteraction<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            self.DragInteraction += (o, arg) => action(self);
            return self;
        }
        
        public static T OnEndInteraction<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.TouchEventArgs> handler)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            self.EndInteraction += handler;
            return self;
        }
        
        public static T OnEndInteraction<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            self.EndInteraction += (o, arg) => action(self);
            return self;
        }
        
        public static T OnCancelInteraction<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            self.CancelInteraction += handler;
            return self;
        }
        
        public static T OnCancelInteraction<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.GraphicsView
        {
            self.CancelInteraction += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
