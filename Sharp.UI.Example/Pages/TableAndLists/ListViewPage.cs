﻿
namespace ExampleApp;

using Sharp.UI;

[BindableProperties]
public interface ListViewPageViewModelProperties
{
    List<DataModel> SimpleData { get; set; }
}

[SharpObject]
public partial class ListViewPageViewModel : BindableObject, ListViewPageViewModelProperties
{
    public ListViewPageViewModel()
    {
        SimpleData = DataModel.SimpleData;
        var test = SimpleData.First().Name;
    }
}

[ViewModel(typeof(ListViewPageViewModel))]
public class ListViewPage : ContentPage
{
	public ListViewPage()
	{
        Content = new ScrollView {
            new VStack
            {
                new Grid(e => e
                    .HeightRequest(80)
                    .BackgroundColor(Colors.Gray))
                {
                    new Label("This is a test of ListView")
                        .TextColor(Colors.White)
                        .FontSize(28)
                        .HorizontalOptions(LayoutOptions.Center)
                        .VerticalOptions(LayoutOptions.Center)
                },

                new Label("TextCell")
                    .FontSize(40)
                    .TextColor(Colors.Red)
                    .BackgroundColor(AppColors.Gray900),
                new ListView()
                    .ItemsSource(e => e.Path(nameof(ListViewPageViewModel.SimpleData)))
                    .ItemTemplate(() =>
                        new TextCell()
                            .Text(e => e.Path(nameof(DataModel.Name)))
                            .Detail(e => e.Path(nameof(DataModel.Id)).StringFormat("id: {0}"))
                    ),

                new Label("ImageCell")
                    .FontSize(40)
                    .TextColor(Colors.Red)
                    .BackgroundColor(AppColors.Gray900),
                new ListView()
                    .ItemsSource(e => e.Path(nameof(ListViewPageViewModel.SimpleData)))
                    .ItemTemplate(() =>
                        new ImageCell()
                            .ImageSource("dotnet_bot.png")
                            .Text(e => e.Path(nameof(DataModel.Name)))
                            .Detail(e => e.Path(nameof(DataModel.Id)).StringFormat("id: {0}"))
                    ),

                new Label("SwitchCell")
                    .FontSize(40)
                    .TextColor(Colors.Red)
                    .BackgroundColor(AppColors.Gray900),
                new ListView()
                    .ItemsSource(e => e.Path(nameof(ListViewPageViewModel.SimpleData)))
                    .ItemTemplate(() =>
                        new SwitchCell()
                            .Text(e => e.Path(nameof(DataModel.Name)))
                            .On(e => e.Path(nameof(DataModel.Admin)))
                    ),

                new Label("EntryCell")
                    .FontSize(40)
                    .TextColor(Colors.Red)
                    .BackgroundColor(AppColors.Gray900),
                new ListView()
                    .ItemsSource(e => e.Path(nameof(ListViewPageViewModel.SimpleData)))
                    .ItemTemplate(() =>
                        new EntryCell()
                            .Text(e => e.Path(nameof(DataModel.Name)))
                    ),

                new Label("ViewCell")
                    .FontSize(40)
                    .TextColor(Colors.Red)
                    .BackgroundColor(AppColors.Gray900),
                new ListView()
                    .ItemsSource(e => e.Path(nameof(ListViewPageViewModel.SimpleData)))
                    .ItemTemplate(() =>
                        new ViewCell
                        {
                            new HStack
                            {
                                new Label()
                                    .Text(e => e.Path("Id").StringFormat("Id: {0}, "))
                                    .FontSize(30)
                                    .TextColor(Colors.Blue),
                                new Label()
                                    .Text(e => e.Path("Name").StringFormat("Name: {0} "))
                                    .FontSize(30)
                            }
                        })
            }
        }
        .Margin(new Thickness(0,30,0,0));
    }
}