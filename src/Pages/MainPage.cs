using System;
using CommunityToolkit.Maui.Markup;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace HelloMauiMarkup;

class MainPage : BaseContentPage<MainViewModel>
{
	public MainPage(MainViewModel mainViewModel) : base(mainViewModel)
	{
		Content = new ScrollView
		{
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
		};
	}

	enum Row { HelloWorld, Welcome, Count, ClickMeButton, Image }
}