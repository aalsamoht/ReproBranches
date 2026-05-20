using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiSourceGenRelativeSource.Models;

namespace MauiSourceGenRelativeSource.ViewModels;

public partial class TestingViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<TestItem> _items = [];

    public TestingViewModel()
    {
        InitializeSampleData();
    }

    private void InitializeSampleData()
    {
        Items = new ObservableCollection<TestItem>
        {
            new() { Id = "1", Name = "Test Item 1" },
            new() { Id = "2", Name = "Test Item 2" },
            new() { Id = "3", Name = "Test Item 3" },
            new() { Id = "4", Name = "Test Item 4" },
        };
    }

    [RelayCommand]
    private void DeleteItem(TestItem item)
    {
        if (item != null && Items.Contains(item))
        {
            Items.Remove(item);
        }
    }
}
