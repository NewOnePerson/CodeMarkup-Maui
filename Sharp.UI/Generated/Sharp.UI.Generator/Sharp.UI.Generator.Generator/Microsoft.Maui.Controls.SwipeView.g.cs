﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class SwipeViewGeneratedExtension
    {
        public static T Threshold<T>(this T obj,
            double? threshold)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var mauiValue = MauiWrapper.Value<double>(threshold);
            if (threshold != null) mauiObject.Threshold = mauiValue;
            return obj;
        }
        
        public static T Threshold<T>(this T obj,
            double? threshold,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var mauiValue = MauiWrapper.Value<double>(threshold);
            if (threshold != null) mauiObject.Threshold = mauiValue;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.SwipeView.ThresholdProperty));
            if (def.ValueIsSet()) mauiObject.Threshold = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Threshold<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.SwipeView.ThresholdProperty));
            if (def.ValueIsSet()) mauiObject.Threshold = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T LeftItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems? leftItems)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItems>(leftItems);
            if (leftItems != null) mauiObject.LeftItems = mauiValue;
            return obj;
        }
        
        public static T LeftItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems? leftItems,
            System.Func<BindableDef<Microsoft.Maui.Controls.SwipeItems>, BindableDef<Microsoft.Maui.Controls.SwipeItems>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItems>(leftItems);
            if (leftItems != null) mauiObject.LeftItems = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.LeftItemsProperty));
            if (def.ValueIsSet()) mauiObject.LeftItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T LeftItems<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.SwipeItems>, BindableDef<Microsoft.Maui.Controls.SwipeItems>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.LeftItemsProperty));
            if (def.ValueIsSet()) mauiObject.LeftItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T RightItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems? rightItems)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItems>(rightItems);
            if (rightItems != null) mauiObject.RightItems = mauiValue;
            return obj;
        }
        
        public static T RightItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems? rightItems,
            System.Func<BindableDef<Microsoft.Maui.Controls.SwipeItems>, BindableDef<Microsoft.Maui.Controls.SwipeItems>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItems>(rightItems);
            if (rightItems != null) mauiObject.RightItems = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.RightItemsProperty));
            if (def.ValueIsSet()) mauiObject.RightItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T RightItems<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.SwipeItems>, BindableDef<Microsoft.Maui.Controls.SwipeItems>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.RightItemsProperty));
            if (def.ValueIsSet()) mauiObject.RightItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TopItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems? topItems)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItems>(topItems);
            if (topItems != null) mauiObject.TopItems = mauiValue;
            return obj;
        }
        
        public static T TopItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems? topItems,
            System.Func<BindableDef<Microsoft.Maui.Controls.SwipeItems>, BindableDef<Microsoft.Maui.Controls.SwipeItems>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItems>(topItems);
            if (topItems != null) mauiObject.TopItems = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.TopItemsProperty));
            if (def.ValueIsSet()) mauiObject.TopItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TopItems<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.SwipeItems>, BindableDef<Microsoft.Maui.Controls.SwipeItems>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.TopItemsProperty));
            if (def.ValueIsSet()) mauiObject.TopItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BottomItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems? bottomItems)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItems>(bottomItems);
            if (bottomItems != null) mauiObject.BottomItems = mauiValue;
            return obj;
        }
        
        public static T BottomItems<T>(this T obj,
            Microsoft.Maui.Controls.SwipeItems? bottomItems,
            System.Func<BindableDef<Microsoft.Maui.Controls.SwipeItems>, BindableDef<Microsoft.Maui.Controls.SwipeItems>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var mauiValue = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeItems>(bottomItems);
            if (bottomItems != null) mauiObject.BottomItems = mauiValue;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.BottomItemsProperty));
            if (def.ValueIsSet()) mauiObject.BottomItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T BottomItems<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.SwipeItems>, BindableDef<Microsoft.Maui.Controls.SwipeItems>> definition)
            where T : Sharp.UI.ISwipeView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.SwipeItems>(mauiObject, Microsoft.Maui.Controls.SwipeView.BottomItemsProperty));
            if (def.ValueIsSet()) mauiObject.BottomItems = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnSwipeStarted<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.SwipeStartedEventArgs> action)
            where T : Sharp.UI.ISwipeView
        {            
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.SwipeStarted += (o, arg) => action(obj, arg);
            return obj;
        }
        
        public static T OnSwipeChanging<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.SwipeChangingEventArgs> action)
            where T : Sharp.UI.ISwipeView
        {            
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.SwipeChanging += (o, arg) => action(obj, arg);
            return obj;
        }
        
        public static T OnSwipeEnded<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.SwipeEndedEventArgs> action)
            where T : Sharp.UI.ISwipeView
        {            
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.SwipeEnded += (o, arg) => action(obj, arg);
            return obj;
        }
        
        public static T OnOpenRequested<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.OpenRequestedEventArgs> action)
            where T : Sharp.UI.ISwipeView
        {            
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.OpenRequested += (o, arg) => action(obj, arg);
            return obj;
        }
        
        public static T OnCloseRequested<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.CloseRequestedEventArgs> action)
            where T : Sharp.UI.ISwipeView
        {            
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SwipeView>(obj);
            mauiObject.CloseRequested += (o, arg) => action(obj, arg);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
