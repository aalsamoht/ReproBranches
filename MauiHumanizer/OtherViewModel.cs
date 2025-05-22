using System.Collections.ObjectModel;

namespace MauiHumanizer;

public class OtherViewModel
{
    public ObservableCollection<OtherModel> MyItems { get; } = new(Enumerable
        .Range(1, 20)
        .Select(i => new OtherModel
        {
            Id = i,
            Title = $"My title {i}",
            Message = $"My msg {i}",
            
            // Crashes net9.0-ios
            SentTs = DateTime.Now.AddMinutes(-(i * 1000)),
            
            // Does not crash net9.0-ios
            // SentTs = DateTime.Now,
        }));
}