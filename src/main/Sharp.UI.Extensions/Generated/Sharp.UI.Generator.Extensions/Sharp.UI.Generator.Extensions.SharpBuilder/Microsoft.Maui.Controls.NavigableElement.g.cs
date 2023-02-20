﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class NavigableElementExtension
    {
        public static T Style<T>(this T obj,
            Microsoft.Maui.Controls.Style style)
            where T : Microsoft.Maui.Controls.NavigableElement
        {
            obj.Style = style;
            return obj;
        }
        
        public static T Style<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Style>, ValueBuilder<Microsoft.Maui.Controls.Style>> buidValue)
            where T : Microsoft.Maui.Controls.NavigableElement
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.Style>());
            if (builder.ValueIsSet()) obj.Style = builder.GetValue();
            return obj;
        }
        
        public static T Style<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Style>, BindingBuilder<Microsoft.Maui.Controls.Style>> buidBinding)
            where T : Microsoft.Maui.Controls.NavigableElement
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.Style>(obj, Microsoft.Maui.Controls.NavigableElement.StyleProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T StyleClass<T>(this T obj,
            IList<string> styleClass)
            where T : Microsoft.Maui.Controls.NavigableElement
        {
            foreach (var item in styleClass)
                obj.StyleClass.Add(item);
            return obj;
        }

        public static T StyleClass<T>(this T obj,
            params string[] styleClass)
            where T : Microsoft.Maui.Controls.NavigableElement
        {
            foreach (var item in styleClass)
                obj.StyleClass.Add(item);
            return obj;
        }
        
        public static T @class<T>(this T obj,
            IList<string> @class)
            where T : Microsoft.Maui.Controls.NavigableElement
        {
            foreach (var item in @class)
                obj.@class.Add(item);
            return obj;
        }

        public static T @class<T>(this T obj,
            params string[] @class)
            where T : Microsoft.Maui.Controls.NavigableElement
        {
            foreach (var item in @class)
                obj.@class.Add(item);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
