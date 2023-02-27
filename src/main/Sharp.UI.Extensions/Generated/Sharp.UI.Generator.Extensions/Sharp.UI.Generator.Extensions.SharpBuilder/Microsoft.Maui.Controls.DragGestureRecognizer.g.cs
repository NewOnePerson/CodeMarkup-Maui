﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class DragGestureRecognizerExtension
    {
        public static T CanDrag<T>(this T self,
            bool canDrag)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DragGestureRecognizer.CanDragProperty, canDrag);
            return self;
        }
        
        public static T CanDrag<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.DragGestureRecognizer.CanDragProperty);
            configure(context).Build();
            return self;
        }
        
        public static T DropCompletedCommand<T>(this T self,
            System.Windows.Input.ICommand dropCompletedCommand)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DragGestureRecognizer.DropCompletedCommandProperty, dropCompletedCommand);
            return self;
        }
        
        public static T DropCompletedCommand<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            var context = new PropertyContext<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.DragGestureRecognizer.DropCompletedCommandProperty);
            configure(context).Build();
            return self;
        }
        
        public static T DropCompletedCommandParameter<T>(this T self,
            object dropCompletedCommandParameter)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DragGestureRecognizer.DropCompletedCommandParameterProperty, dropCompletedCommandParameter);
            return self;
        }
        
        public static T DropCompletedCommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.DragGestureRecognizer.DropCompletedCommandParameterProperty);
            configure(context).Build();
            return self;
        }
        
        public static T DragStartingCommand<T>(this T self,
            System.Windows.Input.ICommand dragStartingCommand)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DragGestureRecognizer.DragStartingCommandProperty, dragStartingCommand);
            return self;
        }
        
        public static T DragStartingCommand<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            var context = new PropertyContext<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.DragGestureRecognizer.DragStartingCommandProperty);
            configure(context).Build();
            return self;
        }
        
        public static T DragStartingCommandParameter<T>(this T self,
            object dragStartingCommandParameter)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DragGestureRecognizer.DragStartingCommandParameterProperty, dragStartingCommandParameter);
            return self;
        }
        
        public static T DragStartingCommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.DragGestureRecognizer.DragStartingCommandParameterProperty);
            configure(context).Build();
            return self;
        }
        
        public static T OnDropCompleted<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.DropCompletedEventArgs> handler)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            self.DropCompleted += handler;
            return self;
        }
        
        public static T OnDropCompleted<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            self.DropCompleted += (o, arg) => action(self);
            return self;
        }
        
        public static T OnDragStarting<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.DragStartingEventArgs> handler)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            self.DragStarting += handler;
            return self;
        }
        
        public static T OnDragStarting<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            self.DragStarting += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
