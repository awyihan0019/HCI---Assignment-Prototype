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

namespace HCI___Assignment_Prototype.Page.View_Booking {
    /// <summary>
    /// Interaction logic for UserControl_DisplayBookDetail.xaml
    /// </summary>
    public partial class UserControl_DisplayBookDetail : UserControl {
        public UserControl_DisplayBookDetail() {
            InitializeComponent();
            int _ticketQuantity = Global.Global.MovieReservation.NormalSeat.Trim().Split(' ').Length;
            int comboAQuantity = Global.Global.MovieReservation.FoodAndDrinks[0].Quantity;
            int comboBQuantity = Global.Global.MovieReservation.FoodAndDrinks[1].Quantity;
            int comboCQuantity = Global.Global.MovieReservation.FoodAndDrinks[2].Quantity;
            int comboDQuantity = Global.Global.MovieReservation.FoodAndDrinks[3].Quantity;

            double ticketTotal = _ticketQuantity * 15.9;
            double comboATotal = comboAQuantity * Global.Global.MovieReservation.FoodAndDrinks[0].Price;
            double comboBTotal = comboBQuantity * Global.Global.MovieReservation.FoodAndDrinks[1].Price;
            double comboCTotal = comboCQuantity * Global.Global.MovieReservation.FoodAndDrinks[2].Price;
            double comboDTotal = comboDQuantity * Global.Global.MovieReservation.FoodAndDrinks[3].Price;
            double TotalPayment = ticketTotal + comboATotal + comboBTotal + comboCTotal + comboDTotal;

            ticketQuantity.Content = _ticketQuantity;
            ComboAQuantity.Content = comboAQuantity;
            ComboBQuantity.Content =comboBQuantity;
            ComboCQuantity.Content = comboCQuantity;
            ComboDQuantity.Content = comboDQuantity;

            TicketTotal.Content = "RM " + ticketTotal;
            ComboATotal.Content = "RM " + comboATotal; 
            ComboBTotal.Content = "RM " + comboBTotal; 
            ComboCTotal.Content = "RM " + comboCTotal; 
            ComboDTotal.Content = "RM " + comboDTotal; 
            Total.Content = "RM " + TotalPayment;

            string comboes =null;

            for (int i = 0; i < Global.Global.MovieReservation.FoodAndDrinks.Count; i++)
            {
                if(Global.Global.MovieReservation.FoodAndDrinks[i].Quantity == 0)
                {
                    if(i == 0)
                    {
                        LabelA.Visibility = Visibility.Collapsed;
                        ComboAPrice.Visibility = Visibility.Collapsed;
                        ComboAQuantity.Visibility = Visibility.Collapsed;
                        ComboATotal.Visibility = Visibility.Collapsed;
                    }
                    else if (i == 1) {
                        LabelB.Visibility = Visibility.Collapsed;
                        ComboBPrice.Visibility = Visibility.Collapsed;
                        ComboBQuantity.Visibility = Visibility.Collapsed;
                        ComboBTotal.Visibility = Visibility.Collapsed;
                    }
                    else if (i == 2) {
                        LabelC.Visibility = Visibility.Collapsed;
                        ComboCPrice.Visibility = Visibility.Collapsed;
                        ComboCQuantity.Visibility = Visibility.Collapsed;
                        ComboCTotal.Visibility = Visibility.Collapsed;
                    }
                    else if (i == 3) {
                        LabelD.Visibility = Visibility.Collapsed;
                        ComboDPrice.Visibility = Visibility.Collapsed;
                        ComboDQuantity.Visibility = Visibility.Collapsed;
                        ComboDTotal.Visibility = Visibility.Collapsed;
                    }
                }
                if(Global.Global.MovieReservation.FoodAndDrinks[i].Quantity != 0)
                {
                    comboes += Global.Global.MovieReservation.FoodAndDrinks[i].Name + "(" + Global.Global.MovieReservation.FoodAndDrinks[i].Quantity + ") \n";
                }
            }

            //display reservation detail

            Movie.Content = Global.Global.MovieReservation.MovieName;
            Location.Content = Global.Global.MovieReservation.Location;
            Date.Content = Global.Global.MovieReservation.Date;
            Time.Content = Global.Global.MovieReservation.Time;
            Seat.Content = Global.Global.MovieReservation.NormalSeat;

            Combo.Content = comboes;
        }

        private void Click_cancelDetail(object sender , RoutedEventArgs e) {
            MainWindow.MainFrame.GoBack();

        }

        private void Click_ConfirmBooking(object sender , RoutedEventArgs e) {
            ProgressDialog.Show("Making Reservation . . ." , "" ,
                () => {
                    DialogBox.Show("Payment Successful" , "Your Reservation is already made, your e-tickets are sent to your e-mail." , "OK");
                    Global.Global.CurrentUser.Reservations.Add(Global.Global.MovieReservation);
                });

            MainWindow.MainFrame.Navigate(new UserControl_CheckReservation());
        }
    }
}

