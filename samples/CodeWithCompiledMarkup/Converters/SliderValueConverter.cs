using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CodeWithCompiledMarkup.Converters
{
    public class SliderValueConverter : IValueConverter
    {
        //Value Bind from Source---->Target
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int valueFromSource;
            if(Int32.TryParse(value.ToString(),out valueFromSource))
            {
                valueFromSource = valueFromSource * 2;
                return valueFromSource;
            }
            return value;
        }

        //Value Bind From Target To Source
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
