using HCI___Assignment_Prototype.CustomControl;
using HCI___Assignment_Prototype.Page.CheckBooking;
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

namespace HCI___Assignment_Prototype.Page.View_Booking
{
    /// <summary>
    /// Interaction logic for UserControl_DisplayBookDetail.xaml
    /// </summary>
    public partial class UserControl_DisplayBookDetail : UserControl
    {
        public UserControl_DisplayBookDetail()
        {
            InitializeComponent();
            double ticketTotal = Global.Global.MovieReservation.NormalSeat.Split(' ').Length * 15.9;
            double comboATotal = Global.Global.MovieReservation.FoodAndDrinks[0].Quantity * Global.Global.MovieReservation.FoodAndDrinks[0].Price;
            double comboBTotal = Global.Global.MovieReservation.FoodAndDrinks[1].Quantity * Global.Global.MovieReservation.FoodAndDrinks[1].Price;
            double comboCTotal = Global.Global.MovieReservation.FoodAndDrinks[2].Quantity * Global.Global.MovieReservation.FoodAndDrinks[2].Price;
            double comboDTotal = Global.Global.MovieReservation.FoodAndDrinks[3].Quantity * Global.Global.MovieReservation.FoodAndDrinks[3].Price;
            double TotalPayment = ticketTotal + comboATotal + comboBTotal + comboCTotal + comboDTotal;

            ticketQuantity.Content = Global.Global.MovieReservation.NormalSeat.Split(' ').Length;
            ComboAQuantity.Content = Global.Global.MovieReservation.FoodAndDrinks[0].Quantity;
            ComboBQuantity.Content = Global.Global.MovieReservation.FoodAndDrinks[1].Quantity;
            ComboCQuantity.Content = Global.Global.MovieReservation.FoodAndDrinks[2].Quantity;
            ComboDQuantity.Content = Global.Global.MovieReservation.FoodAndDrinks[3].Quantity;

            TicketTotal.Content = "RM " + (Global.Global.MovieReservation.NormalSeat.Split(' ').Length * 15.9).ToString();
            ComboATotal.Content = "RM " + Global.Global.MovieReservation.FoodAndDrinks[0].Quantity * Global.Global.MovieReservation.FoodAndDrinks[0].Price;
            ComboBTotal.Content = "RM " + Global.Global.MovieReservation.FoodAndDrinks[1].Quantity * Global.Global.MovieReservation.FoodAndDrinks[1].Price;
            ComboCTotal.Content = "RM " + Global.Global.MovieReservation.FoodAndDrinks[2].Quantity * Global.Global.MovieReservation.FoodAndDrinks[2].Price;
            ComboDTotal.Content = "RM " + Global.Global.MovieReservation.FoodAndDrinks[3].Quantity * Global.Global.MovieReservation.FoodAndDrinks[3].Price;
            Total.Content = "RM " + TotalPayment;

            for (int i = 0; i < Global.Global.MovieReservation.FoodAndDrinks.Count; i++)
            {
                if(Global.Global.MovieReservation.FoodAndDrinks[i].Quantity == 0)
                {
                    if(i == 0)
                    {
                        LabelA.Visibility = Visibility.Collapsed;
                        ComboAQuantity.Visibility = Visibility.Collapsed;
                        ComboATotal.Visibility = Visibility.Collapsed;
                    }
                    else if(i == 1)
                    {
                        LabelB.Visibility = Visibility.Collapsed;
                        ComboBQuantity.Visibility = Visibility.Collapsed;
                        ComboBTotal.Visibility = Visibility.Collapsed;
                    }
                    else if(i == 2)
                    {
                        LabelC.Visibility = Visibility.Collapsed;
                        ComboCQuantity.Visibility = Visibility.Collapsed;
                        ComboCTotal.Visibility = Visibility.Collapsed;
                    }
                    else if(i == 3)
                    {
                        LabelD.Visibility = Visibility.Collapsed;
                        ComboDQuantity.Visibility = Visibility.Collapsed;
                        ComboDTotal.Visibility = Visibility.Collapsed;
                    }
                }
            }
            
        }

        private void Click_cancelDetail(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.GoBack();
            
        }

        private void Click_ConfirmBooking(object sender, RoutedEventArgs e)
        {
            ProgressDialog.Show("Making Reservation . . .", "",
                () =>
                {
                    DialogBox.Show("Payment Successful", "Your Reservation is already made, your e-tickets are sent to your e-mail.", "OK");
                    Global.Global.CurrentUser.Reservations.Add(Global.Global.MovieReservation);
                });

            MainWindow.MainFrame.Navigate(new UserControl_CheckReservation());
        }
    }
}

