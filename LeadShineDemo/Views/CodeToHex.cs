using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LeadShineDemo.Views
{
    public class CodeToHex : IValueConverter
    {
        #region IValueConverter Members
        public Object Convert(object value, Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            int code = (int)value;
            if (code != 0)
            {
                return String.Format("0x{0:X2}", code);
            }
            else return "    ";

        }

        public object ConvertBack(object value, Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
