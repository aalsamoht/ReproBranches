namespace MauiShellColors;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnNavClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("MainPageChild");
    }
}