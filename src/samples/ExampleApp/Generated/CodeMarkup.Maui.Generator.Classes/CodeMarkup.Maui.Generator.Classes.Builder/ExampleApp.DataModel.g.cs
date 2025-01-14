﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Classes.Builder
//

#nullable enable


namespace ExampleApp
{
	public partial class DataModel
	{

        // ----- constructors -----

        public DataModel() { }

        public DataModel(out DataModel dataModel) 
        {
            dataModel = this;
        }

        public DataModel(int id, string name, bool admin, out DataModel dataModel) : this(id, name, admin)
        {
            dataModel = this;
        }

        // ----- bindable properties -----

        public static readonly Microsoft.Maui.Controls.BindableProperty IdProperty =
            Microsoft.Maui.Controls.BindableProperty.Create(
                nameof(Id),
                typeof(int),
                typeof(ExampleApp.DataModel),
                default(int));

        public int Id
        {
            get => (int)GetValue(IdProperty);
            set => SetValue(IdProperty, value);
        }
        
        public static readonly Microsoft.Maui.Controls.BindableProperty NameProperty =
            Microsoft.Maui.Controls.BindableProperty.Create(
                nameof(Name),
                typeof(string),
                typeof(ExampleApp.DataModel),
                default(string));

        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }
        
        public static readonly Microsoft.Maui.Controls.BindableProperty AdminProperty =
            Microsoft.Maui.Controls.BindableProperty.Create(
                nameof(Admin),
                typeof(bool),
                typeof(ExampleApp.DataModel),
                default(bool));

        public bool Admin
        {
            get => (bool)GetValue(AdminProperty);
            set => SetValue(AdminProperty, value);
        }
        
    }
}

#nullable restore
