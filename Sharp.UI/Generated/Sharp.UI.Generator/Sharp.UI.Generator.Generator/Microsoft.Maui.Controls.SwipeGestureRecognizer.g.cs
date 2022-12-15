﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class SwipeGestureRecognizerGeneratedExtension
    {
        public static T Command<T>(this T obj,
            System.Windows.Input.ICommand? command)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var mauiValue = MauiWrapper.Value<System.Windows.Input.ICommand>(command);
            if (command != null) mauiObject.Command = mauiValue;
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Windows.Input.ICommand? command,
            System.Func<BindableDef<System.Windows.Input.ICommand>, BindableDef<System.Windows.Input.ICommand>> definition)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var mauiValue = MauiWrapper.Value<System.Windows.Input.ICommand>(command);
            if (command != null) mauiObject.Command = mauiValue;
            var def = definition(new BindableDef<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.SwipeGestureRecognizer.CommandProperty));
            if (def.ValueIsSet()) mauiObject.Command = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<BindableDef<System.Windows.Input.ICommand>, BindableDef<System.Windows.Input.ICommand>> definition)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var def = definition(new BindableDef<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.SwipeGestureRecognizer.CommandProperty));
            if (def.ValueIsSet()) mauiObject.Command = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            object? commandParameter)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var mauiValue = MauiWrapper.Value<object>(commandParameter);
            if (commandParameter != null) mauiObject.CommandParameter = mauiValue;
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            object? commandParameter,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var mauiValue = MauiWrapper.Value<object>(commandParameter);
            if (commandParameter != null) mauiObject.CommandParameter = mauiValue;
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.SwipeGestureRecognizer.CommandParameterProperty));
            if (def.ValueIsSet()) mauiObject.CommandParameter = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<BindableDef<object>, BindableDef<object>> definition)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var def = definition(new BindableDef<object>(mauiObject, Microsoft.Maui.Controls.SwipeGestureRecognizer.CommandParameterProperty));
            if (def.ValueIsSet()) mauiObject.CommandParameter = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Direction<T>(this T obj,
            Microsoft.Maui.SwipeDirection? direction)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.SwipeDirection>(direction);
            if (direction != null) mauiObject.Direction = mauiValue;
            return obj;
        }
        
        public static T Direction<T>(this T obj,
            Microsoft.Maui.SwipeDirection? direction,
            System.Func<BindableDef<Microsoft.Maui.SwipeDirection>, BindableDef<Microsoft.Maui.SwipeDirection>> definition)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.SwipeDirection>(direction);
            if (direction != null) mauiObject.Direction = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.SwipeDirection>(mauiObject, Microsoft.Maui.Controls.SwipeGestureRecognizer.DirectionProperty));
            if (def.ValueIsSet()) mauiObject.Direction = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Direction<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.SwipeDirection>, BindableDef<Microsoft.Maui.SwipeDirection>> definition)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.SwipeDirection>(mauiObject, Microsoft.Maui.Controls.SwipeGestureRecognizer.DirectionProperty));
            if (def.ValueIsSet()) mauiObject.Direction = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Threshold<T>(this T obj,
            uint? threshold)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var mauiValue = MauiWrapper.Value<uint>(threshold);
            if (threshold != null) mauiObject.Threshold = mauiValue;
            return obj;
        }
        
        public static T Threshold<T>(this T obj,
            uint? threshold,
            System.Func<BindableDef<uint>, BindableDef<uint>> definition)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var mauiValue = MauiWrapper.Value<uint>(threshold);
            if (threshold != null) mauiObject.Threshold = mauiValue;
            var def = definition(new BindableDef<uint>(mauiObject, Microsoft.Maui.Controls.SwipeGestureRecognizer.ThresholdProperty));
            if (def.ValueIsSet()) mauiObject.Threshold = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Threshold<T>(this T obj,
            System.Func<BindableDef<uint>, BindableDef<uint>> definition)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            var def = definition(new BindableDef<uint>(mauiObject, Microsoft.Maui.Controls.SwipeGestureRecognizer.ThresholdProperty));
            if (def.ValueIsSet()) mauiObject.Threshold = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnSwiped<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.SwipedEventArgs> action)
            where T : Sharp.UI.ISwipeGestureRecognizer
        {            
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeGestureRecognizer>(obj);
            mauiObject.Swiped += (o, arg) => action(obj, arg);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
