using HCI___Assignment_Prototype.CustomControl;
using HCI___Assignment_Prototype.Global;
using HCI___Assignment_Prototype.Page.CreateReservation_Admin;
using HCI___Assignment_Prototype.Page.Homepage;
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

namespace HCI___Assignment_Prototype.Page.Homepage_Admin
{
    /// <summary>
    /// Interaction logic for UserControl_HomePage_Admin.xaml
    /// </summary>
    public partial class UserControl_HomePage_Admin : UserControl
    {
        public UserControl_HomePage_Admin()
        {
            InitializeComponent();
            var incoming = SampleData.SampleReservationDetails.
                Where(m => DateTime.Parse(m.Date) >= DateTime.Today).ToList();
            var expired = SampleData.SampleReservationDetails.
                Where(m => DateTime.Parse(m.Date) < DateTime.Today).ToList();
            foreach (var item in incoming)
            {
                MovieList.Children.Add(new ReservationDetail_Admin() { DataContext = item });
            }
        }

        private void Click_CreateNewReservation(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new UserControl_CreateReservarion());
        }

        private void SignOut_Click(object sender, RoutedEventArgs e)
        {
            DialogBox.Show("Logout the account", "Do you really want to logout your account?", "Cancel", "Logout");
            switch (DialogBox.Result)
            {
                case DialogBox.ResultEnum.LeftButtonClicked: return;
                case DialogBox.ResultEnum.RightButtonClicked:
                    MainWindow.MainFrame.Navigate(new Homepage_BeforeLogin());
                    Global.Global.CurrentUser = null;
                    return;
            }
        }
    }
}
