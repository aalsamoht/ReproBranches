using System.Collections.ObjectModel;

namespace MauiShellColors;

public partial class OtherPageChild : ContentPage
{
    private static readonly string[] Palette =
    [
        "#FF6F00", "#FFB300", "#F4511E", "#6D4C41", "#FDD835",
        "#FB8C00", "#E65100", "#BF360C", "#FF8F00", "#FFCA28"
    ];

    public ObservableCollection<string> Items { get; } = new();

    public OtherPageChild()
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