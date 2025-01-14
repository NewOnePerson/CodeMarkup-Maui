﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class DropGestureRecognizerExtension
    {
        public static T AllowDrop<T>(this T self,
            bool allowDrop)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.SetValue(Microsoft.Maui.Controls.DropGestureRecognizer.AllowDropProperty, allowDrop);
            return self;
        }
        
        public static T AllowDrop<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.DropGestureRecognizer.AllowDropProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> AllowDrop<T>(this SettersContext<T> self,
            bool allowDrop)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.DropGestureRecognizer.AllowDropProperty, Value = allowDrop });
            return self;
        }
        
        public static SettersContext<T> AllowDrop<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.DropGestureRecognizer.AllowDropProperty);
            configure(context).Build();
            return self;
        }
        
        public static T DragOverCommand<T>(this T self,
            System.Windows.Input.ICommand dragOverCommand)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.SetValue(Microsoft.Maui.Controls.DropGestureRecognizer.DragOverCommandProperty, dragOverCommand);
            return self;
        }
        
        public static T DragOverCommand<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var context = new PropertyContext<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.DropGestureRecognizer.DragOverCommandProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> DragOverCommand<T>(this SettersContext<T> self,
            System.Windows.Input.ICommand dragOverCommand)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.DropGestureRecognizer.DragOverCommandProperty, Value = dragOverCommand });
            return self;
        }
        
        public static SettersContext<T> DragOverCommand<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, Microsoft.Maui.Controls.DropGestureRecognizer.DragOverCommandProperty);
            configure(context).Build();
            return self;
        }
        
        public static T DragOverCommandParameter<T>(this T self,
            object dragOverCommandParameter)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.SetValue(Microsoft.Maui.Controls.DropGestureRecognizer.DragOverCommandParameterProperty, dragOverCommandParameter);
            return self;
        }
        
        public static T DragOverCommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.DropGestureRecognizer.DragOverCommandParameterProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> DragOverCommandParameter<T>(this SettersContext<T> self,
            object dragOverCommandParameter)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.DropGestureRecognizer.DragOverCommandParameterProperty, Value = dragOverCommandParameter });
            return self;
        }
        
        public static SettersContext<T> DragOverCommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var context = new PropertySettersContext<object>(self.XamlSetters, Microsoft.Maui.Controls.DropGestureRecognizer.DragOverCommandParameterProperty);
            configure(context).Build();
            return self;
        }
        
        public static T DragLeaveCommand<T>(this T self,
            System.Windows.Input.ICommand dragLeaveCommand)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.SetValue(Microsoft.Maui.Controls.DropGestureRecognizer.DragLeaveCommandProperty, dragLeaveCommand);
            return self;
        }
        
        public static T DragLeaveCommand<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var context = new PropertyContext<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.DropGestureRecognizer.DragLeaveCommandProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> DragLeaveCommand<T>(this SettersContext<T> self,
            System.Windows.Input.ICommand dragLeaveCommand)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.DropGestureRecognizer.DragLeaveCommandProperty, Value = dragLeaveCommand });
            return self;
        }
        
        public static SettersContext<T> DragLeaveCommand<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, Microsoft.Maui.Controls.DropGestureRecognizer.DragLeaveCommandProperty);
            configure(context).Build();
            return self;
        }
        
        public static T DragLeaveCommandParameter<T>(this T self,
            object dragLeaveCommandParameter)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.SetValue(Microsoft.Maui.Controls.DropGestureRecognizer.DragLeaveCommandParameterProperty, dragLeaveCommandParameter);
            return self;
        }
        
        public static T DragLeaveCommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.DropGestureRecognizer.DragLeaveCommandParameterProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> DragLeaveCommandParameter<T>(this SettersContext<T> self,
            object dragLeaveCommandParameter)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.DropGestureRecognizer.DragLeaveCommandParameterProperty, Value = dragLeaveCommandParameter });
            return self;
        }
        
        public static SettersContext<T> DragLeaveCommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var context = new PropertySettersContext<object>(self.XamlSetters, Microsoft.Maui.Controls.DropGestureRecognizer.DragLeaveCommandParameterProperty);
            configure(context).Build();
            return self;
        }
        
        public static T DropCommand<T>(this T self,
            System.Windows.Input.ICommand dropCommand)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.SetValue(Microsoft.Maui.Controls.DropGestureRecognizer.DropCommandProperty, dropCommand);
            return self;
        }
        
        public static T DropCommand<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var context = new PropertyContext<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.DropGestureRecognizer.DropCommandProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> DropCommand<T>(this SettersContext<T> self,
            System.Windows.Input.ICommand dropCommand)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.DropGestureRecognizer.DropCommandProperty, Value = dropCommand });
            return self;
        }
        
        public static SettersContext<T> DropCommand<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, Microsoft.Maui.Controls.DropGestureRecognizer.DropCommandProperty);
            configure(context).Build();
            return self;
        }
        
        public static T DropCommandParameter<T>(this T self,
            object dropCommandParameter)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.SetValue(Microsoft.Maui.Controls.DropGestureRecognizer.DropCommandParameterProperty, dropCommandParameter);
            return self;
        }
        
        public static T DropCommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.DropGestureRecognizer.DropCommandParameterProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> DropCommandParameter<T>(this SettersContext<T> self,
            object dropCommandParameter)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.DropGestureRecognizer.DropCommandParameterProperty, Value = dropCommandParameter });
            return self;
        }
        
        public static SettersContext<T> DropCommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var context = new PropertySettersContext<object>(self.XamlSetters, Microsoft.Maui.Controls.DropGestureRecognizer.DropCommandParameterProperty);
            configure(context).Build();
            return self;
        }
        
        public static T OnDragLeave<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.DragEventArgs> handler)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.DragLeave += handler;
            return self;
        }
        
        public static T OnDragLeave<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.DragLeave += (o, arg) => action(self);
            return self;
        }
        
        public static T OnDragOver<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.DragEventArgs> handler)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.DragOver += handler;
            return self;
        }
        
        public static T OnDragOver<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.DragOver += (o, arg) => action(self);
            return self;
        }
        
        public static T OnDrop<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.DropEventArgs> handler)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.Drop += handler;
            return self;
        }
        
        public static T OnDrop<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.Drop += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
