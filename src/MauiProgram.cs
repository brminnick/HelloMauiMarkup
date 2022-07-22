using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;

namespace HelloMauiMarkup;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder()
						.UseMauiApp<App>()
						.UseMauiCommunityToolkit()
						.UseMauiCommunityToolkitMarkup()
						.ConfigureFonts(fonts =>fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"));

		builder.Services.AddSingleton<App>();
		builder.Services.AddSingleton<AppShell>();

		builder.Services.AddSingleton(DeviceInfo.Current);

		builder.Services.AddTransientWithShellRoute<MainPage, MainViewModel>($"//{nameof(MainPage)}");

		return builder.Build();
	}
}