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
        }

        private void Click_cancelDetail(object sender, RoutedEventArgs e)
        {
            UserControl_BookingDetail.CurrentPage--;
        }

        private void Click_ConfirmBooking(object sender, RoutedEventArgs e)
        {
            double ticketTotal = Global.Global.MovieReservation.NormalSeat.Split(' ').Length * 15.9;
            double comboATotal = Global.Global.MovieReservation.FoodAndDrinks[0].Quantity * Global.Global.MovieReservation.FoodAndDrinks[0].Price;
            double comboBTotal = Global.Global.MovieReservation.FoodAndDrinks[1].Quantity * Global.Global.MovieReservation.FoodAndDrinks[1].Price;
            double comboCTotal = Global.Global.MovieReservation.FoodAndDrinks[2].Quantity * Global.Global.MovieReservation.FoodAndDrinks[2].Price;
            double comboDTotal = Global.Global.MovieReservation.FoodAndDrinks[3].Quantity * Global.Global.MovieReservation.FoodAndDrinks[3].Price;
            double TotalPayment = ticketTotal + comboATotal + comboBTotal + comboCTotal + comboDTotal;

            DialogBox.Show("Booking Payment", "Do you really want to make this reservation?\n\n" +
                "Number of Ticket  : " + Global.Global.MovieReservation.NormalSeat.Split(' ').Length + $"RM { ticketTotal : F2}"
                +
                "Number of Combo A  : " + Global.Global.MovieReservation.FoodAndDrinks[0].Quantity + $"RM { comboATotal : F2}"
                +
                "Number of Combo B  : " + Global.Global.MovieReservation.FoodAndDrinks[1].Quantity + $"RM { comboBTotal : F2}"
                +
                "Number of Combo C  : " + Global.Global.MovieReservation.FoodAndDrinks[2].Quantity + $"RM { comboCTotal:  F2}"
                +
                "Number of Combo D  : " + Global.Global.MovieReservation.FoodAndDrinks[3].Quantity + $"RM { comboDTotal : F2}"
                +
                "Total Price : RM " + TotalPayment, "CANCEL", "CONFRIM");

            //CustomControl.UserControl_NumberCounter.NumberProperty
            switch (DialogBox.Result)
            {
                case DialogBox.ResultEnum.LeftButtonClicked: return;
                case DialogBox.ResultEnum.RightButtonClicked:
                    ProgressDialog.Show("Making Reservation . . .", "",
                        () => {
                            DialogBox.Show("Payment Successed", "Your Reservation already made the e-ticket are sended to your e-mail.", "OK");
                        });
                    return;
            }
        }
    }
}
