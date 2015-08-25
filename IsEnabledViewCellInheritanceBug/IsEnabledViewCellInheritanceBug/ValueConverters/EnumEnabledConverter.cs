using System;
using System.Globalization;
using Xamarin.Forms;

namespace IsEnabledViewCellInheritanceBug.ValueConverters
{
    public class EnumEnabledConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value as TestEnum? == TestEnum.Disabled)
                return false;

            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // No need to implement
            throw new NotImplementedException();
        }
    }
}
