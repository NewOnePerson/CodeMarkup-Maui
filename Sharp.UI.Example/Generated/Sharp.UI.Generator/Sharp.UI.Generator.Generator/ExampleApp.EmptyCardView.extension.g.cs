﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace ExampleApp
{
    using Sharp.UI;

    public static class EmptyCardViewGeneratedSharpObjectExtension
    {
        public static T CardTitle<T>(this T obj,
            string cardTitle)
            where T : ExampleApp.EmptyCardView
        {
            var mauiObject = MauiWrapper.Value<ExampleApp.EmptyCardView>(obj);
            mauiObject.SetValue(ExampleApp.EmptyCardView.CardTitleProperty, (string)cardTitle);
            return obj;
        }
        
        public static T CardTitle<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : ExampleApp.EmptyCardView
        {
            var mauiObject = MauiWrapper.Value<ExampleApp.EmptyCardView>(obj);
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) mauiObject.SetValue(ExampleApp.EmptyCardView.CardTitleProperty, builder.GetValue());
            return obj;
        }
        
        public static T CardTitle<T>(this T obj,
            System.Func<LazyValueBuilder<string>, LazyValueBuilder<string>> buildValue)
            where T : ExampleApp.EmptyCardView
        {
            var mauiObject = MauiWrapper.Value<ExampleApp.EmptyCardView>(obj);
            var builder = buildValue(new LazyValueBuilder<string>());
            if (builder.ValueIsSet()) mauiObject.SetValue(ExampleApp.EmptyCardView.CardTitleProperty, builder.GetValue());
            return obj;
        }
        
        public static T CardTitle<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
            where T : ExampleApp.EmptyCardView
        {
            var mauiObject = MauiWrapper.Value<ExampleApp.EmptyCardView>(obj);
            var builder = buildBinding(new BindingBuilder<string>(mauiObject, ExampleApp.EmptyCardView.CardTitleProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CardDescription<T>(this T obj,
            string cardDescription)
            where T : ExampleApp.EmptyCardView
        {
            var mauiObject = MauiWrapper.Value<ExampleApp.EmptyCardView>(obj);
            mauiObject.SetValue(ExampleApp.EmptyCardView.CardDescriptionProperty, (string)cardDescription);
            return obj;
        }
        
        public static T CardDescription<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : ExampleApp.EmptyCardView
        {
            var mauiObject = MauiWrapper.Value<ExampleApp.EmptyCardView>(obj);
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) mauiObject.SetValue(ExampleApp.EmptyCardView.CardDescriptionProperty, builder.GetValue());
            return obj;
        }
        
        public static T CardDescription<T>(this T obj,
            System.Func<LazyValueBuilder<string>, LazyValueBuilder<string>> buildValue)
            where T : ExampleApp.EmptyCardView
        {
            var mauiObject = MauiWrapper.Value<ExampleApp.EmptyCardView>(obj);
            var builder = buildValue(new LazyValueBuilder<string>());
            if (builder.ValueIsSet()) mauiObject.SetValue(ExampleApp.EmptyCardView.CardDescriptionProperty, builder.GetValue());
            return obj;
        }
        
        public static T CardDescription<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
            where T : ExampleApp.EmptyCardView
        {
            var mauiObject = MauiWrapper.Value<ExampleApp.EmptyCardView>(obj);
            var builder = buildBinding(new BindingBuilder<string>(mauiObject, ExampleApp.EmptyCardView.CardDescriptionProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CardColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color cardColor)
            where T : ExampleApp.EmptyCardView
        {
            var mauiObject = MauiWrapper.Value<ExampleApp.EmptyCardView>(obj);
            mauiObject.SetValue(ExampleApp.EmptyCardView.CardColorProperty, (Microsoft.Maui.Graphics.Color)cardColor);
            return obj;
        }
        
        public static T CardColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : ExampleApp.EmptyCardView
        {
            var mauiObject = MauiWrapper.Value<ExampleApp.EmptyCardView>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.SetValue(ExampleApp.EmptyCardView.CardColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T CardColor<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Graphics.Color>, LazyValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : ExampleApp.EmptyCardView
        {
            var mauiObject = MauiWrapper.Value<ExampleApp.EmptyCardView>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.SetValue(ExampleApp.EmptyCardView.CardColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T CardColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : ExampleApp.EmptyCardView
        {
            var mauiObject = MauiWrapper.Value<ExampleApp.EmptyCardView>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(mauiObject, ExampleApp.EmptyCardView.CardColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color borderColor)
            where T : ExampleApp.EmptyCardView
        {
            var mauiObject = MauiWrapper.Value<ExampleApp.EmptyCardView>(obj);
            mauiObject.SetValue(ExampleApp.EmptyCardView.BorderColorProperty, (Microsoft.Maui.Graphics.Color)borderColor);
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : ExampleApp.EmptyCardView
        {
            var mauiObject = MauiWrapper.Value<ExampleApp.EmptyCardView>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.SetValue(ExampleApp.EmptyCardView.BorderColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Graphics.Color>, LazyValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : ExampleApp.EmptyCardView
        {
            var mauiObject = MauiWrapper.Value<ExampleApp.EmptyCardView>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.SetValue(ExampleApp.EmptyCardView.BorderColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : ExampleApp.EmptyCardView
        {
            var mauiObject = MauiWrapper.Value<ExampleApp.EmptyCardView>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(mauiObject, ExampleApp.EmptyCardView.BorderColorProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
