# Overview
Sharp.UI allows you to build a .NET Multi-platform App User Interface (.NET MAUI) declaratively in C# code using fluent methods. It is a wrapper library, mostly auto-generated.

## Hello, World!

```cs
namespace ExampleApp;
using Sharp.UI;

public class HelloWorldPage : ContentPage
{
    int count = 0;

    public HelloWorldPage()
    {
        Content = new VStack
        {
            new Image("dotnet_bot.png")
                .HeightRequest(200)
                .HorizontalOptions(LayoutOptions.Center),

            new Label("Hello, World!")
                .FontSize(32)
                .HorizontalOptions(LayoutOptions.Center),

            new Label("Welcome to .NET Multi-platform App UI")
                .FontSize(18)
                .HorizontalOptions(LayoutOptions.Center),

            new Button("Click me")
                .HorizontalOptions(LayoutOptions.Center)
                .OnClicked(button =>
                {
                    count++;
                    button.Text = $"Clicked {count} ";
                    button.Text += count == 1 ? "time" : "times";
                })
        }
        .Spacing(25)
        .Padding(new Thickness(30, 0))
        .VerticalOptions(LayoutOptions.Center);
    }
}
```

# Nuget Package

#### .NET CLI

```
dotnet add package Sharp.UI --version 0.1.1-beta
```

#### Package manager

```
dotnet add package Sharp.UI --version 0.1.1-beta
```

## Before you start
If you want to use this library, you must include the `using Sharp.UI` inside your app namespace, which replaces the standard MAUI classes.

```cs
namespace ExampleApp;
using Sharp.UI;
```

```cs
namespace ExampleApp
{
    using Sharp.UI;
    ...
}
```

# Examples
Here are some simple examples showing how to use the Sharp.UI library

## Properties
The properties of the MAUI classes are matched with their fluent helper methods

```cs
new Label()
    .Text("This is a test")
    .Padding(20)
    .FontSize(30)
    .HorizontalOptions(LayoutOptions.Center)
    .VerticalOptions(LayoutOptions.Center)
```

To speed up defining the interface, some common properties are placed directly as constructor arguments

```cs
new Label("This is a test")
```

### Property value
You can set the property value depending on the device idiom, platform, or app theme

```cs
new Label("Hello")
    .FontSize(e => e.Default(50).OnDesktop(80).OnPhone(30))
    .TextColor(e => e.Light(Colors.Black).Dark(Colors.Teal))
```

## Assign
There are two ways to assign objects. Using the `Assign` method 

```cs
new Label().Assign(out label1)
```

or using a constructor parameter

```cs
new Label(out label1)
```

## Containers
Sharp.UI allows you to create single and multi-element containers using braces.

#### Single item containers
Objects such as `ScrollView`, `Border`, `ContentView` etc. can contain only one element.

```cs
new Scrollview
{
    new VStack
    {
        ...
    }
}
```

#### Multi item containers
Objects such as `Grid`, `VStack` (short name for VerticalStackLayout), `HStack` (short name for HorizontalStackLayout) etc. can contain many elements.

```cs
new VStack
{
    new Label("Hello,")
        .FontSize(40),
    new Label("World!"),
    new Ellipse()
        .WidthRequest(100)
        .HeightRequest(40)
},
```

## Bindings
Sharp.UI allows you to create bindings using a property method parameter and fluent methods.

```cs
new Label()
    .Text(e => e.Path("Author"))
    .TextColor(e => e.Path("TextColor").Source(myColors))
``` 
Example of bindings between objects

```cs
using Sharp.UI;

public class SimpleBindings : ContentPage
{
    public SimpleBindings()
    {
        this.Content = new VStack
        {
            new Slider(out var slider)
                .Minimum(1)
                .Maximum(20),

            new Label()
                .Text(e => e
                    .Path("Value")
                    .Source(slider)
                    .StringFormat("Slider value: {0}")
                )
                .FontSize(28)
                .TextColor(Colors.Blue)
        }
        .VerticalOptions(LayoutOptions.Center);
    }
}
```

## Event handlers
To handle events like `OnClicked`, you can write a method handler

```cs
using Sharp.UI;

public class HelloWorldPage : ContentPage
{
    int count = 0;
    public HelloWorldPage()
    {
        Content = new VStack
        {
            ...
            new Button("Click me")
                .OnClicked(OnCounterClicked)
        };
    }

    private void OnCounterClicked(Button sender)
    {
        count++;
        sender.Text = $"Clicked {count} ";
        sender.Text += count == 1 ? "time" : "times";
    }
}
``` 
or do it inline

```cs
new Button("Click me")
    .OnClicked(button =>
    {
        count++;
        button.Text = $"Clicked {count} ";
        button.Text += count == 1 ? "time" : "times";
    })
``` 

## Attached properties

#### Example

`Shell.NavBarIsVisible` is an attached property, and you can set it on the `ContentPage` using the `ShellNavBarIsVisible()` method.

```cs
public class GridPage : ContentPage
{
    public GridPage()
    {
        Content = new Grid
        {
            ...
        }

        this.ShellNavBarIsVisible(false);
    }
}
```

## Grid

#### Rows, columns
Using the `GridRow()`, `GridColumn()`, `GridColumnSpan()`, `GridRowSpan()` and `GridSpan()` methods, you can set the row, column and span within the grid definition.

```cs
new Label("Column 0, Row 2, Span 2 columns")
    .GridColumn(0)
    .GridRow(2)
    .GridColumnSpan(2)
```

Methods like `GridRow()`, `GridColumn()`, `GridColumnSpan()`, `GridRowSpan()` matches attached properties: `Grid.Row`, `Grid.Column`, `Grid.ColumnSpan` and `Grid.RowSpan`.

#### Row and column definition
Using folowing fluent methods you can define the number and sizes of rows and columns.

```cs
new Grid
{
    ...
}
.RowDefinitions(e => e.Star(2).Star())
.ColumnDefinitions(e => e.Absolute(100).Star());
``` 


#### Example grid definition

```cs
new Grid
{
    new BoxView().Color(Colors.Green),
    new Label("Column 0, Row 0"),

    new BoxView().Color(Colors.Blue).GridColumn(1).GridRow(0),
    new Label("Column 1, Row 0").GridColumn(1).GridRow(0),

    new BoxView().Color(Colors.Teal).GridColumn(0).GridRow(1),
    new Label("Column 0, Row 1").GridColumn(0).GridRow(1),

    new BoxView().Color(Colors.Purple).GridColumn(1).GridRow(1),
    new Label("Column 1, Row 1").GridColumn(1).GridRow(1),
}
.RowDefinitions(e => e.Star(2).Star())
.ColumnDefinitions(e => e.Absolute(200).Star());
```

## Menus

### Context menu

```cs
new Grid(out var grid)
{
    new Image("dotnet_bot.png")
        .ContextFlyout(new MenuFlyout
        {
            new MenuFlyoutItem("Copy")
                .OnClicked(e => Console.WriteLine("Copy")),
            new MenuFlyoutItem("Paste")
                .OnClicked(e => Console.WriteLine("Paste")),
            new MenuFlyoutSubItem("Background color")
            {
                new MenuFlyoutItem("Blue")
                    .OnClicked(e => grid.BackgroundColor = Colors.Blue),
                new MenuFlyoutItem("Red")
                    .OnClicked(e => grid.BackgroundColor = Colors.Red),
                new MenuFlyoutItem("Black")
                    .OnClicked(e => grid.BackgroundColor = Colors.Black)
            }
        })
}
```

### Menu bar

```cs
public class MenuPage : ContentPage
{
    public MenuPage()
    {
        this.MenuBarItems(new MenuBarItem[]
        {
            new MenuBarItem("File")
            {
                new MenuFlyoutItem("Exit")
                    .OnClicked(e => Application.Current.Quit()),
            },
            new MenuBarItem("Edit")
            {
                new MenuFlyoutItem("Copy")
                    .OnClicked(e => Console.WriteLine("Copy")),
                new MenuFlyoutItem("Paste")
                    .OnClicked(e => Console.WriteLine("Paste")),
            },
            new MenuBarItem("Theme")
            {
                new MenuFlyoutItem("Blue")
                    .OnClicked(e => this.BackgroundColor = Colors.Blue),
                new MenuFlyoutItem("Red")
                    .OnClicked(e => this.BackgroundColor = Colors.Red),
                new MenuFlyoutItem("Black")
                    .OnClicked(e => this.BackgroundColor = Colors.Black)
            }
        });

        Content = new Grid(out var grid)
        {
            new Label("Menu bar test").FontSize(50)
        }
        .VerticalOptions(LayoutOptions.Center)
        .HorizontalOptions(LayoutOptions.Center);
    }
}
```
## Gradients

```cs
new Border
{
    new Label("This is a test")
        .Padding(20)
        .FontSize(30)
        .HorizontalOptions(LayoutOptions.Center)
        .VerticalOptions(LayoutOptions.Center)
}
.Background(new LinearGradientBrush(new Point(0,0), new Point(1,1))
{
    new GradientStop(Colors.Yellow, 0.0),
    new GradientStop(Colors.Red, 0.25),
    new GradientStop(Colors.Blue, 0.75),
    new GradientStop(Colors.LimeGreen, 1.0)
})
.SizeRequest(400,200)
.Stroke(Colors.Blue)
.StrokeThickness(4)
.StrokeShape(new RoundRectangle().CornerRadius(40)),
```

## Gesture recognizers

Simple usage of the tap gesture recognizer

```cs
new VStack
{
    new Label("Tap 2 times on the image", out var label),
    new Image("dotnet_bot.png", out var image)
        .SizeRequest(100,100)
        .GestureRecognizers(new GestureRecognizer[]
        {
            new TapGestureRecognizer()
                .NumberOfTapsRequired(2)
                .OnTapped((e, args) =>
                {
                    label.Text = "You tapped 2 times";
                })
        })
}
```

This is an example of the pan gesture recognizer

```cs
public class PanGesturePage : ContentPage
{
    double x, y;

    public PanGesturePage()
    {
        Content = new Grid
        {
            new Image("dotnet_bot.png", out var image)
                .SizeRequest(100,100)
                .GestureRecognizers(new GestureRecognizer[]
                {
                    new PanGestureRecognizer()
                        .OnPanUpdated((e, args) =>
                        {
                            switch (args.StatusType)
                            {
                                case GestureStatus.Running:
                                    image.TranslationX = x + args.TotalX;
                                    image.TranslationY = y + args.TotalY;
                                    break;

                                case GestureStatus.Completed:
                                    x = image.TranslationX;
                                    y = image.TranslationY;
                                    break;
                            }
                        })
                })
        };
    }
}
```

Pointer gesture recognizer test page

```cs
public class PointerGesturePage : ContentPage
{
    public PointerGesturePage()
    {
        Content = new VStack
        {
            new Label(out var label).FontSize(20),
            new Label(out var enterExitLabel).FontSize(20).TextColor(Colors.Blue),
            new Image("dotnet_bot.png", out var image)
                .SizeRequest(300,300)
                .GestureRecognizers(new GestureRecognizer[]
                {
                    new PointerGestureRecognizer()
                        .OnPointerEntered((e, args) =>
                        {
                            enterExitLabel.Text = "Entered";
                        })
                        .OnPointerExited((e, args) =>
                        {
                            enterExitLabel.Text = "Exited";
                        })
                        .OnPointerMoved((e, args) =>
                        {
                            var pos = args.GetPosition(relativeTo: image).Value;
                            label.Text = $"point: {pos.X}, {pos.Y}";
                        })
                })
        }
        .HorizontalOptions(LayoutOptions.Center)
        .VerticalOptions(LayoutOptions.Center);
    }
}
```

## Style
Using the `Style<T>` class and the `Set()` extension method of the `BindableProperty` you can define the style of the elements

```cs
new Style<Button>
{
    Button.FontSizeProperty.Set(14),
    Button.CornerRadiusProperty.Set(8)
    ...
}
```

If you want to use different values depending on your app theme, device idiom, or platform, you can combine following methods.

```cs
new Style<Button>
{
    Button.TextColorProperty.Set().Light(Colors.White).Dark(AppColors.Primary),
    Button.BackgroundColorProperty.Set().Light(AppColors.Primary).Dark(Colors.White),
    Button.FontSizeProperty.Set(14).OnDesktop(20),
    Button.CornerRadiusProperty.Set(8).OniOS(15),
    ...
}
```

you can also define visual states of objects

```cs
new Style<Button>
{
    ...
    new VisualState(VisualState.VisualElement.Normal)
    {
        Button.TextColorProperty.Set().Light(Colors.White).Dark(AppColors.Primary),
        Button.BackgroundColorProperty.Set().Light(AppColors.Primary).Dark(Colors.White),
    },
    new VisualState(VisualState.VisualElement.Disabled)
    {
        Button.TextColorProperty.Set().Light(AppColors.Gray950).Dark(AppColors.Gray200),
        Button.BackgroundColorProperty.Set().Light(AppColors.Gray200).Dark(AppColors.Gray600),
    },
    ...
},
```
All defined styles can be placed in `ResourceDictionary`

```cs
new ResourceDictionary
{
    new Style<VStack>
    {
        VStack.VerticalOptionsProperty.Set(LayoutOptions.Center),
        VStack.HorizontalOptionsProperty.Set(LayoutOptions.Center)
        ...
    },
    new Style<Label>
    {
        Label.TextColorProperty.Set(Colors.Red),
        Label.FontSizeProperty.Set(30.0),
        Label.MarginProperty.Set(new Thickness(10,10)),
        Label.HorizontalOptionsProperty.Set(LayoutOptions.Center),
        ...
    },
    ...
};
```

## Triggers

### Property triggers

```cs
using Sharp.UI;

public class PropertyTriggerPage : ContentPage
{
    public PropertyTriggerPage()
    {
        Resources = new ResourceDictionary
        {
            new Style<Entry>
            {
                Entry.BackgroundColorProperty.Set(Colors.Black),
                Entry.TextColorProperty.Set(Colors.White),

                new Trigger(Entry.IsFocusedProperty, true)
                {
                    Entry.BackgroundColorProperty.Set(Colors.Yellow),
                    Entry.TextColorProperty.Set(Colors.Black)
                },
            }
        };

        Content = new VStack
        {
            new Entry("Enter name"),
            new Entry("Enter password"),
            new Entry("Enter address")
        }
        .WidthRequest(300)
        .VerticalOptions(LayoutOptions.Center);
    }
}
```

### Data triggers

```cs
new VStack
{
    new Entry("Enter text...", out var entry).Text(""),
    new Button("Save")
        .Triggers(new List<TriggerBase>
        {
            new DataTrigger<Button>(e => e.Path("Text.Length").Source(entry), 0)
            {
                Entry.IsEnabledProperty.Set(false)
            }
        })
}
```

### Event triggers

```cs
new Entry("Enter text...", out var entry).Text("")
    .Triggers(new List<TriggerBase>
    {
        new EventTrigger("TextChanged")
        {
            new NumericValidationTriggerAction()
        }
    })
```

Action

```cs
public class NumericValidationTriggerAction : TriggerAction<Entry>
{
    protected override void Invoke(Entry entry)
    {
        double result;
        bool isValid = Double.TryParse(entry.Text, out result);
        entry.TextColor = isValid ? Colors.Black : Colors.Red;
    }
}
```

## Behaviours
You can add functionality to user interface controls without having to subclass them with behaviours.

```cs
public class BehaviorTestPage : ContentPage
{
    public BehaviorTestPage()
    {
        Content = new VStack
        {
            new Entry("Enter text...", out var entry).Text("")
                .Behaviors(new NumericValidationBehavior())
        }
        .VerticalOptions(LayoutOptions.Center);
    }
}
```

## Templates definition
With `Def<T>` you can create templates depending on device idiom, platform, or app theme

```cs
new Def<VStack>(e => e
        .BackgroundColor(Colors.Red)
        .Padding(20)
    )
    .OnDesktop(() =>
        new VStack
        {
            new Label("Desktop version"),
            new Image("dotnet_bot.png"),
        })
    .OnPhone(() =>
        new VStack
        {
            new Label("This is a phone version"),
            new Label("No images...")
        }),
```

## Shell
Defining your application's shell

```cs
using Sharp.UI;

public partial class App : Application
{
    public App()
    {
        MainPage = new Shell
        {
            new FlyoutItem(FlyoutDisplayOptions.AsMultipleItems)
            {
                new Tab("Main")
                {
                    new ShellContent<HelloWorldPage>("Hello Page"),
                    new ShellContent<ExamplePage>("ExamplePage"),
                },

                new ShellContent<GridPage>("Grid"),
                ...
            }
        }
	.ItemTemplate(() => new ShellItemTemplate())
        .Resources(AppResources.Default);
    }
}
```

### Define FlyoutItem appearance

```cs
public class ShellItemTemplate : ContentView
{
    public ShellItemTemplate()
    {
        Content = new Grid
        {
            new Image()
                .Source(e => e.Path("FlyoutIcon"))
                .Margin(5)
                .HeightRequest(45),

            new Label()
                .GridColumn(1)
                .Text(e => e.Path("Title"))
                .FontSize(20)
                .FontAttributes(FontAttributes.Italic)
                .VerticalTextAlignment(TextAlignment.Center)
        }
        .ColumnDefinitions(e => e.Star(0.2).Star(0.8));
    }
}
```

## Auto-generated Bindable Properties

Sharp.UI automatically generates bindable properties and helper methods for classes with interfaces with the `Bindable` attribute.

```cs
[Bindable]
public interface ICardViewProperties
{
    string CardTitle { get; set; }
    string CardDescription { get; set; }
    Color CardColor { get; set; }
    Color BorderColor { get; set; }
}

[MauiWrapper]
public partial class CardView : ContentView, ICardViewProperties
{
}
```

An example of a control template

```cs
public class TemplatedParentPage : ContentPage
{    
    public TemplatedParentPage()
    {
        var template = new ControlTemplate(() =>
            new Border
            {
                new VStack
                {
                    new Label()
                        .Text(e => e.TemplatedPath("CardTitle"))
                        .FontSize(44)
                        .TextColor(Colors.White),

                    new Label()
                        .Text(e => e.TemplatedPath("CardDescription"))
                }
            }
            .StrokeShape(new RoundRectangle().CornerRadius(10))
            .Stroke(e => e.TemplatedPath("BorderColor"))
            .BackgroundColor(e => e.TemplatedPath("CardColor"))
            .SizeRequest(200, 300)
            .Margin(50)
            .Padding(20)
        );

        this.Content = new VStack
        {
            new CardView()
                .CardTitle("Title 1")
                .CardDescription("Do you like it")
                .CardColor(Colors.Blue)
                .BorderColor(Colors.Red)
                .ControlTemplate(template),

            new CardView()
                .CardTitle("Title 2")
                .CardDescription("Yes I do")
                .CardColor(Colors.Red)
                .BorderColor(Colors.Blue)
                .ControlTemplate(template)
        }
        .VerticalOptions(LayoutOptions.Center);
    }
}
```
# License 

MIT License, Copyright 2022 Pawel Krzywdzinski
