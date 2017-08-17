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
    /// Interaction logic for UserControl_ReselectSeat.xaml
    /// </summary>
    public partial class UserControl_ReselectSeat : UserControl
    {
        public UserControl_ReselectSeat()
        {
            InitializeComponent();
        }

        private void SeatReselect_Next(object sender, RoutedEventArgs e)
        {
            Global.Global.MovieReservation.NormalSeat = SeatPlace.HighlightedSeats;
        }

        private void BackButton_onClick(object sender, RoutedEventArgs e)
        {
            DialogBox.CloseDialog();
        }
    }
}
