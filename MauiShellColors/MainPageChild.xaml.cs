using System.Collections.ObjectModel;

namespace MauiShellColors;

public partial class MainPageChild : ContentPage
{
    private static readonly string[] Palette =
    [
        "#E74C3C", "#3498DB", "#2ECC71", "#F39C12", "#9B59B6",
        "#1ABC9C", "#E67E22", "#34495E", "#E91E63", "#00BCD4"
    ];

    public ObservableCollection<string> Items { get; } = new();

    public MainPageChild()
    {
        InitializeComponent();
        BindingContext = this;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Items.Clear();
        for (int i = 0; i < 450; i++)
        {
            Items.Add(Palette[i % Palette.Length]);
        }
    }
}