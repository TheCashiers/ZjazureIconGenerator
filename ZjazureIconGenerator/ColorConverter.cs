using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

using static System.Convert;

namespace ZjazureIconGenerator
{
    public class ColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return Color.FromArgb(ToByte(values[3]), ToByte(values[0]), ToByte(values[1]), ToByte(values[2]));
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            var color = (Color)value;
            return new object[] { color.R, color.G, color.B, color.A };
        }
    }
}
