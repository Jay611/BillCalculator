using BillCalculator.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BillCalculator
{
    public class CollectionToStringConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Format($"Sub Total: {value:c}");

            //IEnumerable<string> names = (IEnumerable<string>)value;
            //return string.Join(parameter?.ToString() ?? ", ", names);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
