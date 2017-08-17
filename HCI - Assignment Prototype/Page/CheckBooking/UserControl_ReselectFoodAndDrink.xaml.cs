using HCI___Assignment_Prototype.Class;
using HCI___Assignment_Prototype.CustomControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HCI___Assignment_Prototype.Page.CheckBooking
{
    /// <summary>
    /// Interaction logic for UserControl_ReselectFoodAndDrink.xaml
    /// </summary>
    public partial class UserControl_ReselectFoodAndDrink : UserControl
    {
        public UserControl_ReselectFoodAndDrink()
        {
            InitializeComponent();
        }

        private void Click_ReConfirmBooking(object sender, RoutedEventArgs e)
        {
            Global.Global.MovieReservation.FoodAndDrinks = new List<FoodAndDrinks>() {
                new FoodAndDrinks("ComboA", ComboA.Number, 7.99),
                new FoodAndDrinks("ComboB", ComboB.Number, 11.99),
                new FoodAndDrinks("ComboC", ComboC.Number, 11.99),
                new FoodAndDrinks("ComboD", ComboD.Number, 14.99),
            };
        }

        private void Click_cancelDetail(object sender, RoutedEventArgs e)
        {
            DialogBox.CloseDialog();
        }
    }
}
