using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace HCI___Assignment_Prototype.Class
{
    class FoodAndDrink_Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            var s = (List<FoodAndDrinks>)value;
            if (s == null) return "error converting";
            string result = "";
            for (int i = 0; i < s.Count; i++)
            {
                if (s[i].Quantity != 0)
                {
                    result += s[i].Name + "(" + s[i].Quantity + "), ";
                }
            }            
            return result.Trim(' ').Trim(',');
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        
    }
}
