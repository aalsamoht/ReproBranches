using MauiSourceGenRelativeSource.Views;

namespace MauiSourceGenRelativeSource;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnNavigateToTestingClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TestingPage));
    }

    private async void OnNavigateToTesting2Clicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TestingPage2));
    }

    private void OnCounterClicked(object? sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}