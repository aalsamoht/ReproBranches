# ReproBranches
A collection of minimal bug reproduction cases, organized by branches.

## Issue: RelativeSource Command Binding is NULL with XAML SourceGen and IsAotCompatible (iOS Release only)

When using `<MauiXamlInflator>SourceGen</MauiXamlInflator>` combined with `<IsAotCompatible>true</IsAotCompatible>`, commands bound via `RelativeSource AncestorType` inside a `CollectionView.ItemTemplate` are `null` at runtime **on iOS Release builds only**.

This breaks the common pattern of binding a command from the parent ViewModel to an item in a `DataTemplate`.

### Platform & Configuration Matrix
| Platform | Debug | Release |
|----------|-------|---------|
| iOS | ✅ Works | ❌ **NULL** |
| Android | ✅ Works | ✅ Works |

## App Structure

The app has two test pages accessible from MainPage:

### Testing Page 1 (inline DataTemplate)
Uses an inline `DataTemplate` with `TapGestureRecognizer.Command` bound via RelativeSource:
```xml
<TapGestureRecognizer
    Command="{Binding DeleteItemCommand, Mode=OneTime, Source={RelativeSource AncestorType={x:Type viewModels:TestingViewModel}}, x:DataType=viewModels:TestingViewModel}"
    CommandParameter="{Binding ., Mode=OneTime}" />
```

### Testing Page 2 (ItemView with BindableProperty)
Uses a custom `TestItemView` ContentView with a `BindableProperty` for the command:
```xml
<templates:TestItemView
    ItemTappedCommand="{Binding DeleteItemCommand, Mode=OneTime, Source={RelativeSource AncestorType={x:Type viewModels:TestingViewModel}}, x:DataType=viewModels:TestingViewModel}" />
```

The `TestItemView` code-behind has an event handler that logs whether the command is null:
```csharp
private void OnDeleteTapped(object? sender, TappedEventArgs e)
{
    Console.WriteLine($"ItemTappedCommand: {(ItemTappedCommand is null ? "NULL ❌" : ItemTappedCommand.GetType().Name + " ✓")}");
    // ...
}
```

## Reproduction Steps

1. Ensure `MauiSourceGenRelativeSource.csproj` has:
   ```xml
   <IsAotCompatible>true</IsAotCompatible>
   <MauiXamlInflator>SourceGen</MauiXamlInflator>
   ```
2. Build and run the app in *Release* mode
3. Tap "Testing Page 2 (ItemView with BindableProperty)"
4. Tap any item in the list
5. Check console output — `ItemTappedCommand` will be `NULL ❌`

## Expected Behavior
The command should be resolved via `RelativeSource AncestorType` and execute the `DeleteItemCommand` on the ViewModel.

## Actual Behavior
The command is `null` — the RelativeSource binding fails silently when XAML SourceGen + IsAotCompatible are enabled.
