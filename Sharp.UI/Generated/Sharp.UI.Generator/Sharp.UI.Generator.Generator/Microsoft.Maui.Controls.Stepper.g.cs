﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class StepperGeneratedExtension
    {
        public static T Increment<T>(this T obj,
            double? increment)
            where T : Sharp.UI.IStepper
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Stepper>(obj);
            var mauiValue = MauiWrapper.Value<double>(increment);
            if (increment != null) mauiObject.Increment = mauiValue;
            return obj;
        }
        
        public static T Increment<T>(this T obj,
            double? increment,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IStepper
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Stepper>(obj);
            var mauiValue = MauiWrapper.Value<double>(increment);
            if (increment != null) mauiObject.Increment = mauiValue;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Stepper.IncrementProperty));
            if (def.ValueIsSet()) mauiObject.Increment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Increment<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IStepper
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Stepper>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Stepper.IncrementProperty));
            if (def.ValueIsSet()) mauiObject.Increment = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Maximum<T>(this T obj,
            double? maximum)
            where T : Sharp.UI.IStepper
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Stepper>(obj);
            var mauiValue = MauiWrapper.Value<double>(maximum);
            if (maximum != null) mauiObject.Maximum = mauiValue;
            return obj;
        }
        
        public static T Maximum<T>(this T obj,
            double? maximum,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IStepper
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Stepper>(obj);
            var mauiValue = MauiWrapper.Value<double>(maximum);
            if (maximum != null) mauiObject.Maximum = mauiValue;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Stepper.MaximumProperty));
            if (def.ValueIsSet()) mauiObject.Maximum = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Maximum<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IStepper
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Stepper>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Stepper.MaximumProperty));
            if (def.ValueIsSet()) mauiObject.Maximum = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Minimum<T>(this T obj,
            double? minimum)
            where T : Sharp.UI.IStepper
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Stepper>(obj);
            var mauiValue = MauiWrapper.Value<double>(minimum);
            if (minimum != null) mauiObject.Minimum = mauiValue;
            return obj;
        }
        
        public static T Minimum<T>(this T obj,
            double? minimum,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IStepper
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Stepper>(obj);
            var mauiValue = MauiWrapper.Value<double>(minimum);
            if (minimum != null) mauiObject.Minimum = mauiValue;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Stepper.MinimumProperty));
            if (def.ValueIsSet()) mauiObject.Minimum = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Minimum<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IStepper
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Stepper>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Stepper.MinimumProperty));
            if (def.ValueIsSet()) mauiObject.Minimum = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Value<T>(this T obj,
            double? value)
            where T : Sharp.UI.IStepper
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Stepper>(obj);
            var mauiValue = MauiWrapper.Value<double>(value);
            if (value != null) mauiObject.Value = mauiValue;
            return obj;
        }
        
        public static T Value<T>(this T obj,
            double? value,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IStepper
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Stepper>(obj);
            var mauiValue = MauiWrapper.Value<double>(value);
            if (value != null) mauiObject.Value = mauiValue;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Stepper.ValueProperty));
            if (def.ValueIsSet()) mauiObject.Value = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Value<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IStepper
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Stepper>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Stepper.ValueProperty));
            if (def.ValueIsSet()) mauiObject.Value = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnValueChanged<T>(this T obj, OnEventAction<T, Microsoft.Maui.Controls.ValueChangedEventArgs> action)
            where T : Sharp.UI.IStepper
        {            
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Stepper>(obj);
            mauiObject.ValueChanged += (o, arg) => action(obj, arg);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
