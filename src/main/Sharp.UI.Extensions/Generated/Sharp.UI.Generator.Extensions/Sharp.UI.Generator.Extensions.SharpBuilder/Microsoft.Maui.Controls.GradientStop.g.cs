﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class GradientStopExtension
    {
        public static T Color<T>(this T obj,
            Microsoft.Maui.Graphics.Color color)
            where T : Microsoft.Maui.Controls.GradientStop
        {
            obj.Color = color;
            return obj;
        }
        
        public static T Color<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.GradientStop
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.Color = builder.GetValue();
            return obj;
        }
        
        public static T Color<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : Microsoft.Maui.Controls.GradientStop
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, Microsoft.Maui.Controls.GradientStop.ColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Offset<T>(this T obj,
            float offset)
            where T : Microsoft.Maui.Controls.GradientStop
        {
            obj.Offset = offset;
            return obj;
        }
        
        public static T Offset<T>(this T obj,
            System.Func<ValueBuilder<float>, ValueBuilder<float>> buidValue)
            where T : Microsoft.Maui.Controls.GradientStop
        {
            var builder = buidValue(new ValueBuilder<float>());
            if (builder.ValueIsSet()) obj.Offset = builder.GetValue();
            return obj;
        }
        
        public static T Offset<T>(this T obj,
            System.Func<BindingBuilder<float>, BindingBuilder<float>> buidBinding)
            where T : Microsoft.Maui.Controls.GradientStop
        {
            var builder = buidBinding(new BindingBuilder<float>(obj, Microsoft.Maui.Controls.GradientStop.OffsetProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
