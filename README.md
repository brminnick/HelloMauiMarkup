# HelloMauiMarkup
The [.NET MAUI Markup Community Toolkit](https://github.com/communitytoolkit/maui.markup) is a collection of Fluent C# Extension Methods that allows developers to continue architecting their apps using MVVM, Bindings, Resource Dictionaries, etc., without the need for XAML.

### .NET MAUI Markup Community Toolkit

This specific example uses `CommunityToolkit.Maui.Markup` and `CommunityToolkit.Maui.Markup.GridRowsColumns` 

#### Add Markup Namespace

At the top of your C# file, add the following `using static`

```cs
using static CommunityToolkit.Maui.Markup.GridRowsColumns;
```

#### Add `enum Row`

In **MainPage.cs**, add an `enum` to define the `Grid` rows:

```cs
enum Row { HelloWorld, Welcome, Count, ClickMeButton, Image }
```

#### Define Grid

In the constructor of **MainPage.cs**, define the `Content` as a `Grid`

```cs
Content = new Grid
{
    RowSpacing = 25,

    Padding = Device.RuntimePlatform switch
    {
        Device.iOS => new Thickness(30, 60, 30, 30),
        _ => new Thickness(30)
    },

    RowDefinitions = Rows.Define(
        (Row.HelloWorld, Auto),
        (Row.Welcome, Auto),
        (Row.Count, Auto),
        (Row.ClickMeButton, Auto),
        (Row.Image, Auto)),

    Children =
    {
        new Label { Text = "Hello World" }
            .Row(Row.HelloWorld).Font(size: 32)
            .CenterHorizontal().TextCenter(),

        new Label { Text = "Welcome to .NET MAUI Markup Community Toolkit Sample" }
            .Row(Row.Welcome).Font(size: 18)
            .CenterHorizontal().TextCenter(),

        new HorizontalStackLayout
        {
            new Label { Text = "Current Count: " }
                .Font(bold: true)
                .FillHorizontal().TextEnd(),

            new Label()
                .Font(bold: true)
                .FillHorizontal().TextStart()
                .Bind<Label, int, string>(Label.TextProperty, nameof(MainViewModel.ClickCount), convert: count => count.ToString())

        }.Row(Row.Count).CenterHorizontal(),

        new Button { Text = "Click Me" }
            .Row(Row.ClickMeButton)
            .Font(bold: true)
            .CenterHorizontal()
            .BindCommand(nameof(ViewModel.ClickMeButtonCommand)),

        new Image { Source = "dotnet_bot.png", WidthRequest = 250, HeightRequest = 310 }
            .Row(Row.Image)
            .CenterHorizontal()
    }
}
```


<p align="center">
 <img src="https://user-images.githubusercontent.com/13558917/137029038-3005f59f-8726-4462-a1e7-c54d5e897805.png" width="500" />
</p>


