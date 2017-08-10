using HCI___Assignment_Prototype.CustomControl;
using HCI___Assignment_Prototype.Global;
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
    /// Interaction logic for UserControl_SelectTime.xaml
    /// </summary>
    public partial class UserControl_SelectTime : UserControl {
        public UserControl_SelectTime() {
            InitializeComponent();
            DateTime[] date = Global.Global.SelectedMovie.AvailableTime.ToArray();
            String[] fixedDate = new String[date.Length];
            for (int i = 0 ; i < fixedDate.Length ; i++) {
                fixedDate[i] = date[i].ToString("hh:mm tt");
            }
            ListView.ItemsSource = fixedDate;
        }

        private void Click_CancelTime(object sender , RoutedEventArgs e) {
            UserControl_BookingDetail.CurrentPage--;
        }

        private void Click_Button(object sender , RoutedEventArgs e) {
            Global.Global.MovieReservation.Time = ListView.SelectedItem.ToString();
            UserControl_BookingDetail.CurrentPage++;
        }
    }
}
