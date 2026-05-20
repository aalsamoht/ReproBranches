using System.Windows.Input;
using MauiSourceGenRelativeSource.Models;

namespace MauiSourceGenRelativeSource.Views.Templates;

public partial class TestItemView : ContentView
{
    public static readonly BindableProperty ItemTappedCommandProperty = BindableProperty.Create(
        nameof(ItemTappedCommand), typeof(ICommand), typeof(TestItemView), null);

    public TestItemView()
    {
        InitializeComponent();
    }

    public ICommand? ItemTappedCommand
    {
        get => (ICommand)GetValue(ItemTappedCommandProperty);
        set => SetValue(ItemTappedCommandProperty, value);
    }

    private void OnDeleteTapped(object? sender, TappedEventArgs e)
    {
        var item = BindingContext as TestItem;
        
        Console.WriteLine($"========== OnDeleteTapped ==========");
        Console.WriteLine($"  BindingContext: {BindingContext?.GetType().Name ?? "NULL"}");
        Console.WriteLine($"  Item: {item?.Name ?? "NULL"}");
        Console.WriteLine($"  ItemTappedCommand: {(ItemTappedCommand is null ? "NULL ❌" : ItemTappedCommand.GetType().Name + " ✓")}");
        
        if (ItemTappedCommand is null)
        {
            return;
        }

        if (ItemTappedCommand.CanExecute(item))
        {
            Console.WriteLine($"  Executing command with parameter: {item?.Name}");
            ItemTappedCommand.Execute(item);
        }
        else
        {
            Console.WriteLine($"  Command.CanExecute returned false");
        }
    }
}
