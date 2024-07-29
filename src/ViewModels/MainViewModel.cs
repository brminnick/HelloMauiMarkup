using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HelloMauiMarkup;

partial class MainViewModel : BaseViewModel
{
	[ObservableProperty]
	int _clickCount = 0;

	[RelayCommand]
	void IncrementClickMeButton() => ClickCount++;
}