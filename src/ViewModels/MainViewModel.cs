using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HelloMauiMarkup;

partial class MainViewModel : ObservableObject
{
	[ObservableProperty]
	int _clickCount = 0;

	[ICommand]
	public void IncrementClickMeButton() => ClickCount++;
}