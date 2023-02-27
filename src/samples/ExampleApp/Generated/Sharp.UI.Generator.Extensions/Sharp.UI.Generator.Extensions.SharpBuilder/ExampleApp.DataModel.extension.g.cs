﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace ExampleApp
{
    using Sharp.UI.Internal;
    using Sharp.UI;
    
    public static partial class DataModelExtension
    {
        public static T Id<T>(this T self,
            int id)
            where T : ExampleApp.DataModel
        {
            self.SetValueOrAddSetter(ExampleApp.DataModel.IdProperty, id);
            return self;
        }
        
        public static T Id<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
            where T : ExampleApp.DataModel
        {
            var context = new PropertyContext<int>(self, ExampleApp.DataModel.IdProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Name<T>(this T self,
            string name)
            where T : ExampleApp.DataModel
        {
            self.SetValueOrAddSetter(ExampleApp.DataModel.NameProperty, name);
            return self;
        }
        
        public static T Name<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : ExampleApp.DataModel
        {
            var context = new PropertyContext<string>(self, ExampleApp.DataModel.NameProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Admin<T>(this T self,
            bool admin)
            where T : ExampleApp.DataModel
        {
            self.SetValueOrAddSetter(ExampleApp.DataModel.AdminProperty, admin);
            return self;
        }
        
        public static T Admin<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : ExampleApp.DataModel
        {
            var context = new PropertyContext<bool>(self, ExampleApp.DataModel.AdminProperty);
            configure(context).Build();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
