using MauiSourceGenRelativeSource.ViewModels;

namespace MauiSourceGenRelativeSource.Views;

public partial class TestingPage2 : ContentPage
{
    public TestingPage2()
    {
        InitializeComponent();
        BindingContext = new TestingViewModel();
    }
}
