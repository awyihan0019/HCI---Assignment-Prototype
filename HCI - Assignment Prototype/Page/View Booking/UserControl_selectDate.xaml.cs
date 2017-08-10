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
    /// Interaction logic for UserControl_SelectDate.xaml
    /// </summary>
    public partial class UserControl_SelectDate : UserControl {
        public UserControl_SelectDate() {
            InitializeComponent();
            DateTime[] date = Global.Global.SelectedMovie.AvailableDate.ToArray();
            String[] fixedDate = new String[date.Length];
            for (int i = 0 ; i < fixedDate.Length ; i++) {
                fixedDate[i] = date[i].ToLongDateString();
            }
            ListView.ItemsSource = fixedDate;
        }

        private void Click_cancel(object sender , RoutedEventArgs e) {
            UserControl_BookingDetail.CurrentPage--;
        }

        private void Click_dateNext(object sender , RoutedEventArgs e) {
            if (ListView.SelectedItem == null) {
                DialogBox.Show("You must select a location!" , "" , "OK");
            }
            else {
                Global.Global.MovieReservation.Date = ListView.SelectedItem.ToString();
                UserControl_BookingDetail.CurrentPage++;
            }
        }
    }
}
