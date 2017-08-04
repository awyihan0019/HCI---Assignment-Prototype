using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HCI___Assignment_Prototype.CustomControl.SeatPlace
{
    /// <summary>
    /// Interaction logic for SingleSeat.xaml
    /// </summary>
    public partial class SingleSeat : UserControl
    {
        public SingleSeat()
        {
            InitializeComponent();
            Image.Source = new BitmapImage(new Uri(@"Seat_Unoccupied.png" , UriKind.Relative));
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e) {
            var t = sender as ToggleButton;
            if (t.IsChecked.Value) {
                Image.Source = new BitmapImage(new Uri(@"seat_occupied.png", UriKind.Relative));
            }
            else {
                Image.Source = new BitmapImage(new Uri(@"Seat_Unoccupied.png" , UriKind.Relative));
            }
        }
    }
}
