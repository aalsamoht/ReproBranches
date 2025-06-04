namespace MauiShellColors;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(MainPageChild), typeof(MainPageChild));
        Routing.RegisterRoute(nameof(OtherPageChild), typeof(OtherPageChild));
    }
}