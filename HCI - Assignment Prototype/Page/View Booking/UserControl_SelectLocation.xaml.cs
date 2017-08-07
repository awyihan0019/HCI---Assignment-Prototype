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

namespace HCI___Assignment_Prototype.Page.View_Booking
{
    /// <summary>
    /// Interaction logic for UserControl_SelectLocation.xaml
    /// </summary>
    public partial class UserControl_SelectLocation : UserControl
    {
        public UserControl_SelectLocation()
        {
            InitializeComponent();
            String[] location = SampleData.SampleMovies[0].AvailableLocation.ToArray();
            ListView.ItemsSource = location;
        }

        private void Click_locationNext(object sender, RoutedEventArgs e)
        {
            if (ListView.SelectedItem == null) {
                DialogBox.Show("You must select a location!", "", "OK");
            }
            else {
                MainWindow.MainFrame.Navigate(new UserControl_SelectDate());
                Global.Global.MovieReservation.Location = ListView.SelectedItem.ToString();
            }
        }

        private void Click_Cancel(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.GoBack();
        }
    }
}
