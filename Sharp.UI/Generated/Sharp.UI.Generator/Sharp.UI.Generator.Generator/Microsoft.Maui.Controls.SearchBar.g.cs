﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class SearchBarGeneratedExtension
    {
        public static T CancelButtonColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color cancelButtonColor)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            mauiObject.CancelButtonColor = (Microsoft.Maui.Graphics.Color)cancelButtonColor;
            return obj;
        }
        
        public static T CancelButtonColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.CancelButtonColor = builder.GetValue();
            return obj;
        }
        
        public static T CancelButtonColor<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Graphics.Color>, LazyValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.CancelButtonColor = builder.GetValue();
            return obj;
        }
        
        public static T CancelButtonColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.SearchBar.CancelButtonColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment horizontalTextAlignment)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            mauiObject.HorizontalTextAlignment = (Microsoft.Maui.TextAlignment)horizontalTextAlignment;
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.TextAlignment>, ValueBuilder<Microsoft.Maui.TextAlignment>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.TextAlignment>());
            if (builder.ValueIsSet()) mauiObject.HorizontalTextAlignment = builder.GetValue();
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.TextAlignment>, LazyValueBuilder<Microsoft.Maui.TextAlignment>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.TextAlignment>());
            if (builder.ValueIsSet()) mauiObject.HorizontalTextAlignment = builder.GetValue();
            return obj;
        }
        
        public static T HorizontalTextAlignment<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.TextAlignment>, BindingBuilder<Microsoft.Maui.TextAlignment>> buildBinding)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.SearchBar.HorizontalTextAlignmentProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            Microsoft.Maui.TextAlignment verticalTextAlignment)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            mauiObject.VerticalTextAlignment = (Microsoft.Maui.TextAlignment)verticalTextAlignment;
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.TextAlignment>, ValueBuilder<Microsoft.Maui.TextAlignment>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.TextAlignment>());
            if (builder.ValueIsSet()) mauiObject.VerticalTextAlignment = builder.GetValue();
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.TextAlignment>, LazyValueBuilder<Microsoft.Maui.TextAlignment>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.TextAlignment>());
            if (builder.ValueIsSet()) mauiObject.VerticalTextAlignment = builder.GetValue();
            return obj;
        }
        
        public static T VerticalTextAlignment<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.TextAlignment>, BindingBuilder<Microsoft.Maui.TextAlignment>> buildBinding)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.TextAlignment>(mauiObject, Microsoft.Maui.Controls.SearchBar.VerticalTextAlignmentProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T SearchCommand<T>(this T obj,
            System.Windows.Input.ICommand searchCommand)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            mauiObject.SearchCommand = (System.Windows.Input.ICommand)searchCommand;
            return obj;
        }
        
        public static T SearchCommand<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) mauiObject.SearchCommand = builder.GetValue();
            return obj;
        }
        
        public static T SearchCommand<T>(this T obj,
            System.Func<LazyValueBuilder<System.Windows.Input.ICommand>, LazyValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new LazyValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) mauiObject.SearchCommand = builder.GetValue();
            return obj;
        }
        
        public static T SearchCommand<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buildBinding)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildBinding(new BindingBuilder<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.SearchBar.SearchCommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T SearchCommandParameter<T>(this T obj,
            object searchCommandParameter)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            mauiObject.SearchCommandParameter = (object)searchCommandParameter;
            return obj;
        }
        
        public static T SearchCommandParameter<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) mauiObject.SearchCommandParameter = builder.GetValue();
            return obj;
        }
        
        public static T SearchCommandParameter<T>(this T obj,
            System.Func<LazyValueBuilder<object>, LazyValueBuilder<object>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new LazyValueBuilder<object>());
            if (builder.ValueIsSet()) mauiObject.SearchCommandParameter = builder.GetValue();
            return obj;
        }
        
        public static T SearchCommandParameter<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildBinding(new BindingBuilder<object>(mauiObject, Microsoft.Maui.Controls.SearchBar.SearchCommandParameterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            Microsoft.Maui.Controls.FontAttributes fontAttributes)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            mauiObject.FontAttributes = (Microsoft.Maui.Controls.FontAttributes)fontAttributes;
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.FontAttributes>, ValueBuilder<Microsoft.Maui.Controls.FontAttributes>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.FontAttributes>());
            if (builder.ValueIsSet()) mauiObject.FontAttributes = builder.GetValue();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.FontAttributes>, LazyValueBuilder<Microsoft.Maui.Controls.FontAttributes>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Controls.FontAttributes>());
            if (builder.ValueIsSet()) mauiObject.FontAttributes = builder.GetValue();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.FontAttributes>, BindingBuilder<Microsoft.Maui.Controls.FontAttributes>> buildBinding)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.FontAttributes>(mauiObject, Microsoft.Maui.Controls.SearchBar.FontAttributesProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsTextPredictionEnabled<T>(this T obj,
            bool isTextPredictionEnabled)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            mauiObject.IsTextPredictionEnabled = (bool)isTextPredictionEnabled;
            return obj;
        }
        
        public static T IsTextPredictionEnabled<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.IsTextPredictionEnabled = builder.GetValue();
            return obj;
        }
        
        public static T IsTextPredictionEnabled<T>(this T obj,
            System.Func<LazyValueBuilder<bool>, LazyValueBuilder<bool>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new LazyValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.IsTextPredictionEnabled = builder.GetValue();
            return obj;
        }
        
        public static T IsTextPredictionEnabled<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildBinding(new BindingBuilder<bool>(mauiObject, Microsoft.Maui.Controls.SearchBar.IsTextPredictionEnabledProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CursorPosition<T>(this T obj,
            int cursorPosition)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            mauiObject.CursorPosition = (int)cursorPosition;
            return obj;
        }
        
        public static T CursorPosition<T>(this T obj,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) mauiObject.CursorPosition = builder.GetValue();
            return obj;
        }
        
        public static T CursorPosition<T>(this T obj,
            System.Func<LazyValueBuilder<int>, LazyValueBuilder<int>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new LazyValueBuilder<int>());
            if (builder.ValueIsSet()) mauiObject.CursorPosition = builder.GetValue();
            return obj;
        }
        
        public static T CursorPosition<T>(this T obj,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buildBinding)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildBinding(new BindingBuilder<int>(mauiObject, Microsoft.Maui.Controls.SearchBar.CursorPositionProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T SelectionLength<T>(this T obj,
            int selectionLength)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            mauiObject.SelectionLength = (int)selectionLength;
            return obj;
        }
        
        public static T SelectionLength<T>(this T obj,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) mauiObject.SelectionLength = builder.GetValue();
            return obj;
        }
        
        public static T SelectionLength<T>(this T obj,
            System.Func<LazyValueBuilder<int>, LazyValueBuilder<int>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new LazyValueBuilder<int>());
            if (builder.ValueIsSet()) mauiObject.SelectionLength = builder.GetValue();
            return obj;
        }
        
        public static T SelectionLength<T>(this T obj,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buildBinding)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildBinding(new BindingBuilder<int>(mauiObject, Microsoft.Maui.Controls.SearchBar.SelectionLengthProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            string fontFamily)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            mauiObject.FontFamily = (string)fontFamily;
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) mauiObject.FontFamily = builder.GetValue();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            System.Func<LazyValueBuilder<string>, LazyValueBuilder<string>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new LazyValueBuilder<string>());
            if (builder.ValueIsSet()) mauiObject.FontFamily = builder.GetValue();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildBinding(new BindingBuilder<string>(mauiObject, Microsoft.Maui.Controls.SearchBar.FontFamilyProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            double fontSize)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            mauiObject.FontSize = (double)fontSize;
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) mauiObject.FontSize = builder.GetValue();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            System.Func<LazyValueBuilder<double>, LazyValueBuilder<double>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new LazyValueBuilder<double>());
            if (builder.ValueIsSet()) mauiObject.FontSize = builder.GetValue();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildBinding(new BindingBuilder<double>(mauiObject, Microsoft.Maui.Controls.SearchBar.FontSizeProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            bool fontAutoScalingEnabled)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            mauiObject.FontAutoScalingEnabled = (bool)fontAutoScalingEnabled;
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.FontAutoScalingEnabled = builder.GetValue();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            System.Func<LazyValueBuilder<bool>, LazyValueBuilder<bool>> buildValue)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildValue(new LazyValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.FontAutoScalingEnabled = builder.GetValue();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            var builder = buildBinding(new BindingBuilder<bool>(mauiObject, Microsoft.Maui.Controls.SearchBar.FontAutoScalingEnabledProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnSearchButtonPressed<T>(this T obj, System.EventHandler handler)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            mauiObject.SearchButtonPressed += handler;
            return obj;
        }
        
        public static T OnSearchButtonPressed<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.ISearchBar
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.SearchBar>(obj);
            mauiObject.SearchButtonPressed += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
