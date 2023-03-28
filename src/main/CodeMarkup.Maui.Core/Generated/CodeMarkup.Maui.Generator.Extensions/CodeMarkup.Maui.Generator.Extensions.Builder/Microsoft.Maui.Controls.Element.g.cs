﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class ElementExtension
    {
        public static T AutomationId<T>(this T self,
            string automationId)
            where T : Microsoft.Maui.Controls.Element
        {
            self.SetValue(Microsoft.Maui.Controls.Element.AutomationIdProperty, automationId);
            return self;
        }
        
        public static T AutomationId<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.Element
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.Element.AutomationIdProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> AutomationId<T>(this SettersContext<T> self,
            string automationId)
            where T : Microsoft.Maui.Controls.Element
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Element.AutomationIdProperty, Value = automationId });
            return self;
        }
        
        public static SettersContext<T> AutomationId<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.Element
        {
            var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.Element.AutomationIdProperty);
            configure(context).Build();
            return self;
        }
        
        public static T ClassId<T>(this T self,
            string classId)
            where T : Microsoft.Maui.Controls.Element
        {
            self.SetValue(Microsoft.Maui.Controls.Element.ClassIdProperty, classId);
            return self;
        }
        
        public static T ClassId<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.Element
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.Element.ClassIdProperty);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> ClassId<T>(this SettersContext<T> self,
            string classId)
            where T : Microsoft.Maui.Controls.Element
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Element.ClassIdProperty, Value = classId });
            return self;
        }
        
        public static SettersContext<T> ClassId<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.Element
        {
            var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.Element.ClassIdProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Effects<T>(this T self,
            IList<Microsoft.Maui.Controls.Effect> effects)
            where T : Microsoft.Maui.Controls.Element
        {
            foreach (var item in effects)
                self.Effects.Add(item);
            return self;
        }

        public static T Effects<T>(this T self,
            params Microsoft.Maui.Controls.Effect[] effects)
            where T : Microsoft.Maui.Controls.Element
        {
            foreach (var item in effects)
                self.Effects.Add(item);
            return self;
        }
        
        public static T StyleId<T>(this T self,
            string styleId)
            where T : Microsoft.Maui.Controls.Element
        {
            self.StyleId = styleId;
            return self;
        }
        
        public static T Parent<T>(this T self,
            Microsoft.Maui.Controls.Element parent)
            where T : Microsoft.Maui.Controls.Element
        {
            self.Parent = parent;
            return self;
        }
        
        public static T EffectControlProvider<T>(this T self,
            Microsoft.Maui.Controls.IEffectControlProvider effectControlProvider)
            where T : Microsoft.Maui.Controls.Element
        {
            self.EffectControlProvider = effectControlProvider;
            return self;
        }
        
        public static T OnChildAdded<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> handler)
            where T : Microsoft.Maui.Controls.Element
        {
            self.ChildAdded += handler;
            return self;
        }
        
        public static T OnChildAdded<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Element
        {
            self.ChildAdded += (o, arg) => action(self);
            return self;
        }
        
        public static T OnChildRemoved<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> handler)
            where T : Microsoft.Maui.Controls.Element
        {
            self.ChildRemoved += handler;
            return self;
        }
        
        public static T OnChildRemoved<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Element
        {
            self.ChildRemoved += (o, arg) => action(self);
            return self;
        }
        
        public static T OnDescendantAdded<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> handler)
            where T : Microsoft.Maui.Controls.Element
        {
            self.DescendantAdded += handler;
            return self;
        }
        
        public static T OnDescendantAdded<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Element
        {
            self.DescendantAdded += (o, arg) => action(self);
            return self;
        }
        
        public static T OnDescendantRemoved<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> handler)
            where T : Microsoft.Maui.Controls.Element
        {
            self.DescendantRemoved += handler;
            return self;
        }
        
        public static T OnDescendantRemoved<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Element
        {
            self.DescendantRemoved += (o, arg) => action(self);
            return self;
        }
        
        public static T OnParentChanging<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.ParentChangingEventArgs> handler)
            where T : Microsoft.Maui.Controls.Element
        {
            self.ParentChanging += handler;
            return self;
        }
        
        public static T OnParentChanging<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Element
        {
            self.ParentChanging += (o, arg) => action(self);
            return self;
        }
        
        public static T OnParentChanged<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Element
        {
            self.ParentChanged += handler;
            return self;
        }
        
        public static T OnParentChanged<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Element
        {
            self.ParentChanged += (o, arg) => action(self);
            return self;
        }
        
        public static T OnHandlerChanging<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.HandlerChangingEventArgs> handler)
            where T : Microsoft.Maui.Controls.Element
        {
            self.HandlerChanging += handler;
            return self;
        }
        
        public static T OnHandlerChanging<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Element
        {
            self.HandlerChanging += (o, arg) => action(self);
            return self;
        }
        
        public static T OnHandlerChanged<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Element
        {
            self.HandlerChanged += handler;
            return self;
        }
        
        public static T OnHandlerChanged<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Element
        {
            self.HandlerChanged += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
