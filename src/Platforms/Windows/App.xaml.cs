using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.UI.Xaml;
using Windows.ApplicationModel;

namespace HelloMauiMarkup.WinUI;

public partial class App : MauiWinUIApplication
{
	public App() => this.InitializeComponent();

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
