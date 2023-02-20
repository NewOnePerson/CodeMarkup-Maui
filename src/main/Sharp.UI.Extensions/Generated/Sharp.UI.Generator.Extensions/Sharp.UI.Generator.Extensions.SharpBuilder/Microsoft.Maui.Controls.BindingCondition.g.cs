﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;

    public static partial class BindingConditionExtension
    {
        public static Microsoft.Maui.Controls.BindingCondition Binding(this Microsoft.Maui.Controls.BindingCondition obj,
            Microsoft.Maui.Controls.BindingBase binding)
        {
            obj.Binding = binding;
            return obj;
        }
        
        public static Microsoft.Maui.Controls.BindingCondition Binding(this Microsoft.Maui.Controls.BindingCondition obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.BindingBase>, ValueBuilder<Microsoft.Maui.Controls.BindingBase>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.BindingBase>());
            if (builder.ValueIsSet()) obj.Binding = builder.GetValue();
            return obj;
        }
        
        public static Microsoft.Maui.Controls.BindingCondition Value(this Microsoft.Maui.Controls.BindingCondition obj,
            object value)
        {
            obj.Value = value;
            return obj;
        }
        
        public static Microsoft.Maui.Controls.BindingCondition Value(this Microsoft.Maui.Controls.BindingCondition obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.Value = builder.GetValue();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
