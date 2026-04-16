using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiSourceGenAsyncRelayCommand.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [RelayCommand]
    private async Task First()
    {
        await Task.Delay(3000);
    }

    [RelayCommand]
    private async Task Second()
    {
        await Task.Delay(3000);
    }
}
