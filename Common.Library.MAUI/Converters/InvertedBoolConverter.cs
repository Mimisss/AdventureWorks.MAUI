using System.Globalization;

namespace Common.Library.MAUI.Converters
{
    public class InvertedBoolConverter : IValueConverter
    {        
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is bool boolValue)
            {
                return !boolValue;
            }

            return value;
        }

        // Convert the visual representation of the data to the specific data type
        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
