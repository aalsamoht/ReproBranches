using MauiSourceGenRelativeSource.ViewModels;

namespace MauiSourceGenRelativeSource.Views;

public partial class TestingPage : ContentPage
{
    public TestingPage()
    {
        InitializeComponent();
        BindingContext = new TestingViewModel();
    }
}
