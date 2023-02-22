﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class ListViewExtension
    {
        public static T Footer<T>(this T obj,
            object footer)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.FooterProperty, footer);
            return obj;
        }
        
        public static T Footer<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.FooterProperty, builder.GetValue());
            return obj;
        }
        
        public static T Footer<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.ListView.FooterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FooterTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate footerTemplate)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.FooterTemplateProperty, footerTemplate);
            return obj;
        }
        
        public static T FooterTemplate<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.DataTemplate>, ValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.FooterTemplateProperty, builder.GetValue());
            return obj;
        }
        
        public static T FooterTemplate<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.DataTemplate>, BindingBuilder<Microsoft.Maui.Controls.DataTemplate>> buidBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.DataTemplate>(obj, Microsoft.Maui.Controls.ListView.FooterTemplateProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T FooterTemplate<T>(this T obj, System.Func<object> loadTemplate)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.FooterTemplate = new DataTemplate(loadTemplate);
            return obj;
        }
        
        public static T GroupDisplayBinding<T>(this T obj,
            Microsoft.Maui.Controls.BindingBase groupDisplayBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property GroupDisplayBinding");
            obj.GroupDisplayBinding = groupDisplayBinding;
            return obj;
        }
        
        public static T GroupDisplayBinding<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.BindingBase>, ValueBuilder<Microsoft.Maui.Controls.BindingBase>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property GroupDisplayBinding");
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.BindingBase>());
            if (builder.ValueIsSet()) obj.GroupDisplayBinding = builder.GetValue();
            return obj;
        }
        
        public static T GroupHeaderTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate groupHeaderTemplate)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.GroupHeaderTemplateProperty, groupHeaderTemplate);
            return obj;
        }
        
        public static T GroupHeaderTemplate<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.DataTemplate>, ValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.GroupHeaderTemplateProperty, builder.GetValue());
            return obj;
        }
        
        public static T GroupHeaderTemplate<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.DataTemplate>, BindingBuilder<Microsoft.Maui.Controls.DataTemplate>> buidBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.DataTemplate>(obj, Microsoft.Maui.Controls.ListView.GroupHeaderTemplateProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T GroupHeaderTemplate<T>(this T obj, System.Func<object> loadTemplate)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.GroupHeaderTemplate = new DataTemplate(loadTemplate);
            return obj;
        }
        
        public static T GroupShortNameBinding<T>(this T obj,
            Microsoft.Maui.Controls.BindingBase groupShortNameBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property GroupShortNameBinding");
            obj.GroupShortNameBinding = groupShortNameBinding;
            return obj;
        }
        
        public static T GroupShortNameBinding<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.BindingBase>, ValueBuilder<Microsoft.Maui.Controls.BindingBase>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property GroupShortNameBinding");
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.BindingBase>());
            if (builder.ValueIsSet()) obj.GroupShortNameBinding = builder.GetValue();
            return obj;
        }
        
        public static T HasUnevenRows<T>(this T obj,
            bool hasUnevenRows)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.HasUnevenRowsProperty, hasUnevenRows);
            return obj;
        }
        
        public static T HasUnevenRows<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.HasUnevenRowsProperty, builder.GetValue());
            return obj;
        }
        
        public static T HasUnevenRows<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.ListView.HasUnevenRowsProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Header<T>(this T obj,
            object header)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.HeaderProperty, header);
            return obj;
        }
        
        public static T Header<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.HeaderProperty, builder.GetValue());
            return obj;
        }
        
        public static T Header<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.ListView.HeaderProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T HeaderTemplate<T>(this T obj,
            Microsoft.Maui.Controls.DataTemplate headerTemplate)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.HeaderTemplateProperty, headerTemplate);
            return obj;
        }
        
        public static T HeaderTemplate<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.DataTemplate>, ValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.HeaderTemplateProperty, builder.GetValue());
            return obj;
        }
        
        public static T HeaderTemplate<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.DataTemplate>, BindingBuilder<Microsoft.Maui.Controls.DataTemplate>> buidBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.DataTemplate>(obj, Microsoft.Maui.Controls.ListView.HeaderTemplateProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T HeaderTemplate<T>(this T obj, System.Func<object> loadTemplate)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.HeaderTemplate = new DataTemplate(loadTemplate);
            return obj;
        }
        
        public static T IsGroupingEnabled<T>(this T obj,
            bool isGroupingEnabled)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.IsGroupingEnabledProperty, isGroupingEnabled);
            return obj;
        }
        
        public static T IsGroupingEnabled<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.IsGroupingEnabledProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsGroupingEnabled<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.ListView.IsGroupingEnabledProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsPullToRefreshEnabled<T>(this T obj,
            bool isPullToRefreshEnabled)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.IsPullToRefreshEnabledProperty, isPullToRefreshEnabled);
            return obj;
        }
        
        public static T IsPullToRefreshEnabled<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.IsPullToRefreshEnabledProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsPullToRefreshEnabled<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.ListView.IsPullToRefreshEnabledProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsRefreshing<T>(this T obj,
            bool isRefreshing)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.IsRefreshingProperty, isRefreshing);
            return obj;
        }
        
        public static T IsRefreshing<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.IsRefreshingProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsRefreshing<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.ListView.IsRefreshingProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T RefreshCommand<T>(this T obj,
            System.Windows.Input.ICommand refreshCommand)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.RefreshCommandProperty, refreshCommand);
            return obj;
        }
        
        public static T RefreshCommand<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.RefreshCommandProperty, builder.GetValue());
            return obj;
        }
        
        public static T RefreshCommand<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buidBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidBinding(new BindingBuilder<System.Windows.Input.ICommand>(obj, Microsoft.Maui.Controls.ListView.RefreshCommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T RowHeight<T>(this T obj,
            int rowHeight)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.RowHeightProperty, rowHeight);
            return obj;
        }
        
        public static T RowHeight<T>(this T obj,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.RowHeightProperty, builder.GetValue());
            return obj;
        }
        
        public static T RowHeight<T>(this T obj,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buidBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidBinding(new BindingBuilder<int>(obj, Microsoft.Maui.Controls.ListView.RowHeightProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T SelectedItem<T>(this T obj,
            object selectedItem)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.SelectedItemProperty, selectedItem);
            return obj;
        }
        
        public static T SelectedItem<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.SelectedItemProperty, builder.GetValue());
            return obj;
        }
        
        public static T SelectedItem<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.ListView.SelectedItemProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T SelectionMode<T>(this T obj,
            Microsoft.Maui.Controls.ListViewSelectionMode selectionMode)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.SelectionModeProperty, selectionMode);
            return obj;
        }
        
        public static T SelectionMode<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ListViewSelectionMode>, ValueBuilder<Microsoft.Maui.Controls.ListViewSelectionMode>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.ListViewSelectionMode>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.SelectionModeProperty, builder.GetValue());
            return obj;
        }
        
        public static T SelectionMode<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ListViewSelectionMode>, BindingBuilder<Microsoft.Maui.Controls.ListViewSelectionMode>> buidBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.ListViewSelectionMode>(obj, Microsoft.Maui.Controls.ListView.SelectionModeProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T SeparatorColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color separatorColor)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.SeparatorColorProperty, separatorColor);
            return obj;
        }
        
        public static T SeparatorColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.SeparatorColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T SeparatorColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, Microsoft.Maui.Controls.ListView.SeparatorColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateSeparatorColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.ListView
        {
            Microsoft.Maui.Graphics.Color fromValue = self.SeparatorColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.SeparatorColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateSeparatorColorTo", transform, callback, length, easing);
        }
        
        public static T RefreshControlColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color refreshControlColor)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.RefreshControlColorProperty, refreshControlColor);
            return obj;
        }
        
        public static T RefreshControlColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.RefreshControlColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T RefreshControlColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, Microsoft.Maui.Controls.ListView.RefreshControlColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateRefreshControlColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.ListView
        {
            Microsoft.Maui.Graphics.Color fromValue = self.RefreshControlColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.RefreshControlColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateRefreshControlColorTo", transform, callback, length, easing);
        }
        
        public static T SeparatorVisibility<T>(this T obj,
            Microsoft.Maui.Controls.SeparatorVisibility separatorVisibility)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.SeparatorVisibilityProperty, separatorVisibility);
            return obj;
        }
        
        public static T SeparatorVisibility<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.SeparatorVisibility>, ValueBuilder<Microsoft.Maui.Controls.SeparatorVisibility>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.SeparatorVisibility>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.SeparatorVisibilityProperty, builder.GetValue());
            return obj;
        }
        
        public static T SeparatorVisibility<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.SeparatorVisibility>, BindingBuilder<Microsoft.Maui.Controls.SeparatorVisibility>> buidBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.SeparatorVisibility>(obj, Microsoft.Maui.Controls.ListView.SeparatorVisibilityProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T HorizontalScrollBarVisibility<T>(this T obj,
            Microsoft.Maui.ScrollBarVisibility horizontalScrollBarVisibility)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.HorizontalScrollBarVisibilityProperty, horizontalScrollBarVisibility);
            return obj;
        }
        
        public static T HorizontalScrollBarVisibility<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.ScrollBarVisibility>, ValueBuilder<Microsoft.Maui.ScrollBarVisibility>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.ScrollBarVisibility>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.HorizontalScrollBarVisibilityProperty, builder.GetValue());
            return obj;
        }
        
        public static T HorizontalScrollBarVisibility<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.ScrollBarVisibility>, BindingBuilder<Microsoft.Maui.ScrollBarVisibility>> buidBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.ScrollBarVisibility>(obj, Microsoft.Maui.Controls.ListView.HorizontalScrollBarVisibilityProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T VerticalScrollBarVisibility<T>(this T obj,
            Microsoft.Maui.ScrollBarVisibility verticalScrollBarVisibility)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.VerticalScrollBarVisibilityProperty, verticalScrollBarVisibility);
            return obj;
        }
        
        public static T VerticalScrollBarVisibility<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.ScrollBarVisibility>, ValueBuilder<Microsoft.Maui.ScrollBarVisibility>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.ScrollBarVisibility>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ListView.VerticalScrollBarVisibilityProperty, builder.GetValue());
            return obj;
        }
        
        public static T VerticalScrollBarVisibility<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.ScrollBarVisibility>, BindingBuilder<Microsoft.Maui.ScrollBarVisibility>> buidBinding)
            where T : Microsoft.Maui.Controls.ListView
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.ScrollBarVisibility>(obj, Microsoft.Maui.Controls.ListView.VerticalScrollBarVisibilityProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T RefreshAllowed<T>(this T obj,
            bool refreshAllowed)
            where T : Microsoft.Maui.Controls.ListView
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property RefreshAllowed");
            obj.RefreshAllowed = refreshAllowed;
            return obj;
        }
        
        public static T RefreshAllowed<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.ListView
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property RefreshAllowed");
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.RefreshAllowed = builder.GetValue();
            return obj;
        }
        
        public static T OnItemAppearing<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ItemVisibilityEventArgs> handler)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.ItemAppearing += handler;
            return obj;
        }
        
        public static T OnItemAppearing<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.ItemAppearing += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnItemDisappearing<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ItemVisibilityEventArgs> handler)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.ItemDisappearing += handler;
            return obj;
        }
        
        public static T OnItemDisappearing<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.ItemDisappearing += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnItemSelected<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.SelectedItemChangedEventArgs> handler)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.ItemSelected += handler;
            return obj;
        }
        
        public static T OnItemSelected<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.ItemSelected += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnItemTapped<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ItemTappedEventArgs> handler)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.ItemTapped += handler;
            return obj;
        }
        
        public static T OnItemTapped<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.ItemTapped += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnScrolled<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ScrolledEventArgs> handler)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.Scrolled += handler;
            return obj;
        }
        
        public static T OnScrolled<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.Scrolled += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnRefreshing<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.Refreshing += handler;
            return obj;
        }
        
        public static T OnRefreshing<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.Refreshing += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnScrollToRequested<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ScrollToRequestedEventArgs> handler)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.ScrollToRequested += handler;
            return obj;
        }
        
        public static T OnScrollToRequested<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ListView
        {
            obj.ScrollToRequested += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
