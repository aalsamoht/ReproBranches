using MauiSourceGenAsyncRelayCommand.ViewModels;

namespace MauiSourceGenAsyncRelayCommand;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }
}