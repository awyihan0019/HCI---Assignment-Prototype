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
            string comboes = "";
            for (int i = 0; i < s.Count; i++)
            {
                if (Global.Global.MovieReservation.FoodAndDrinks[i].Quantity != 0)
                {
                    comboes += Global.Global.MovieReservation.FoodAndDrinks[i].Name + "(" + Global.Global.MovieReservation.FoodAndDrinks[i].Quantity + ") \n";
                }
            }
            return comboes;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        
    }
}
