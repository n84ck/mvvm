using Mvvm_practice.Model;
using Mvvm_practice.ViewModel.Filters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Mvvm_practice.ViewModel.ValueConverters
{
    internal class FilterToInputTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null)
            {
                return "Nothing";
            }

            return ((IFilter)value)?.FilterInputType.ToString() ?? "Nothing";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
