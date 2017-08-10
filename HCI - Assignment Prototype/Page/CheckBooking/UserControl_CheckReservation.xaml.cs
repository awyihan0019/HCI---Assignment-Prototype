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
using HCI___Assignment_Prototype.Class;
using HCI___Assignment_Prototype.Page.View_Booking;

namespace HCI___Assignment_Prototype.Page.CheckBooking {
    /// <summary>
    /// Interaction logic for UserControl_CheckBooking.xaml
    /// </summary>
    public partial class UserControl_CheckReservation : UserControl {
        public UserControl_CheckReservation() {
            InitializeComponent();
            this.Loaded += UserControl_CheckReservation_Loaded;
        }

        private void UserControl_CheckReservation_Loaded(object sender , RoutedEventArgs e) {
            var data = Global.Global.CurrentUser.Reservations;
            if (data == null) {
                DialogBox.Show("You have no booking history yet!", "Do you want to make some movie ticket reservation?",
                    "No", "YES PLEASE");
                switch (DialogBox.Result) {
                    case DialogBox.ResultEnum.LeftButtonClicked:
                        MainWindow.MainFrame.GoBack();
                        break;
                    case DialogBox.ResultEnum.RightButtonClicked:
                        MainWindow.MainFrame.Navigate(new UserControl_SelectMovie());
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                return;
            }
            var incoming = data.
                Where(m => DateTime.Parse(m.Date) >= DateTime.Today).ToList();
            var expired = data.
                Where(m => DateTime.Parse(m.Date) < DateTime.Today).ToList();
            foreach (var item in incoming) {
                BookingList.Children.Add(new ReservationDetail() { DataContext = item });
            }
            foreach (var item in expired) {
                var r = new ReservationDetail() { DataContext = item };
                r.MarkAsObsoleted("[EXPIRED]");
                BookingList.Children.Add(r);

            }
        }
    }
}
