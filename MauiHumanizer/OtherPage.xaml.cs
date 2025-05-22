namespace MauiHumanizer;

public partial class OtherPage : ContentPage
{
    public OtherPage(OtherViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}