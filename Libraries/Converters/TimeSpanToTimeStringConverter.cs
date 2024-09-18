using AppShoppingCenter.Models;
using System.Globalization;

namespace AppShoppingCenter.Libraries.Converters;

public class TimeSpanToTimeStringConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if(value == null) return string.Empty;

        Ticket ticket = (Ticket)value;

        var dif = ticket.DateOut.Ticks - ticket.DateIn.Ticks;
        var difTS = new TimeSpan(dif);

        return string.Format("{0:D2}h {1:D2}m", difTS.Hours, difTS.Minutes);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
