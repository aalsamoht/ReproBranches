namespace MauiShellColors;

public partial class OtherPage : ContentPage
{
    public OtherPage()
    {
        InitializeComponent();
    }

    private async void OnNavClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"OtherPageChild");
    }
}