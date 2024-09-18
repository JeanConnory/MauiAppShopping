using System.Globalization;
using ZXing.Net.Maui;

namespace AppShoppingCenter.Libraries.Converters;

public class BarcodeArgsConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var args = value as BarcodeDetectionEventArgs;
        return args.Results[0].Value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
