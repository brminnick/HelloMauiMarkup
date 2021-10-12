using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace HelloMauiMarkup;

class MainViewModel : BaseViewModel
{
    int _clickCount = 0;

    public MainViewModel()
    {
        ClickMeButtonCommand = new Command(() => ClickCount++);
    }

    public int ClickCount
    {
        get => _clickCount;
        set => SetProperty(ref _clickCount, value);
    }

    public ICommand ClickMeButtonCommand { get; }
}