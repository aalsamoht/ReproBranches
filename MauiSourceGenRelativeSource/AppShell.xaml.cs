using MauiSourceGenRelativeSource.Views;

namespace MauiSourceGenRelativeSource;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(TestingPage), typeof(TestingPage));
        Routing.RegisterRoute(nameof(TestingPage2), typeof(TestingPage2));
    }
}