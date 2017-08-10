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
    /// Interaction logic for UserControl_SelectSeats.xaml
    /// </summary>
    public partial class UserControl_SelectSeats : UserControl
    {
        public UserControl_SelectSeats()
        {
            InitializeComponent();
        }

        private void Seat_Next(object sender, RoutedEventArgs e) {
            Global.Global.MovieReservation.NormalSeat = SeatPlace.HighlightedSeats;
            UserControl_BookingDetail.CurrentPage++;
        }
    }
}
