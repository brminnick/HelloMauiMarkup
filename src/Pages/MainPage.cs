using CommunityToolkit.Maui.Markup;

namespace HelloMauiMarkup;

class MainPage : BaseContentPage<MainViewModel>
{
	public MainPage(MainViewModel mainViewModel) : base(mainViewModel)
	{
		Content = new ScrollView
		{
			Content = new VerticalStackLayout
			{
				Spacing = 25,
				Padding = 30,

				Children =
				{
					new Label()
						.Text("Hello World")
						.Font(size: 32)
						.CenterHorizontal(),

					new Label()
						.Text("Welcome to .NET MAUI Markup Community Toolkit Sample")
						.Font(size: 18)
						.CenterHorizontal(),

					new Label()
						.Font(size: 18, bold: true)
						.CenterHorizontal()
						.Bind(Label.TextProperty,
								static (MainViewModel vm) => vm.ClickCount,
								convert: count => $"Current Count: {count}"),

					new Button()
						.Text("Click Me")
						.Font(bold: true)
						.CenterHorizontal()
						.Bind(Button.CommandProperty,
								static (MainViewModel vm) => vm.IncrementClickMeButtonCommand,
								mode: BindingMode.OneTime),

					new Image()
						.Source("dotnet_bot")
						.Size(250, 310)
						.CenterHorizontal()
				}
			}
		};
	}
}