using System.Globalization;
using Humanizer;

namespace MauiHumanizer;

public class TimeStampToHumanTimeConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        // Just returning the value does not crash net9.0-ios
        // return value;

        Console.WriteLine($"*** TimeStampToHumanTimeConverter Start value={value} ***");
        
        if (value is DateTime timestamp)
        {
            Console.WriteLine("*** TimeStampToHumanTimeConverter DateTime Start ***");
            
            var humanized = DateHumanizeExtensions.Humanize(timestamp.ToLocalTime(), DateTime.Now, culture);
        
            Console.WriteLine($"*** TimeStampToHumanTimeConverter DateTime END humanized={humanized} ***");
        
            return humanized;
        }
        
        Console.WriteLine("*** TimeStampToHumanTimeConverter return original value END ***");
        
        return value;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}