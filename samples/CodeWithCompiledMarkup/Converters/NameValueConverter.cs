using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CodeWithCompiledMarkup.Converters
{
    public class NameValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            StringBuilder valueBuilder = new StringBuilder();
            foreach(object value in values)
            {
                valueBuilder.Append(value.ToString()).Append(" ");
            }
            return valueBuilder.ToString().Trim();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            string[] values = value.ToString().Split(' ');
            return values;
        }
    }
}
