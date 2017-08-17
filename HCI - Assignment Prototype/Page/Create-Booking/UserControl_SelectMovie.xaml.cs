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
using HCI___Assignment_Prototype.CustomControl;
using HCI___Assignment_Prototype.Global;

namespace HCI___Assignment_Prototype.Page.View_Booking {
    /// <summary>
    /// Interaction logic for UserControl_SelectMovie.xaml
    /// </summary>
    public partial class UserControl_SelectMovie : UserControl {
        public UserControl_SelectMovie() {
            InitializeComponent();
            ItemsControl.ItemsSource = SampleData.SampleMovies;
        }

        private void ViewAvailabilityButton_OnClick(object sender , RoutedEventArgs e) {
            BookTicketButton_OnClick(sender , e);
        }

        private void BookTicketButton_OnClick(object sender , RoutedEventArgs e) {
            if (Global.Global.CurrentUser == null) {
                DialogBox.Show("Please log in to your account first", "", "OK");
                return;
            }
            var b = sender as Button;
            var selectedMovie = (Movie)b.Tag;
            Global.Global.SelectedMovie = selectedMovie;
            Global.Global.MovieReservation = new MovieReservation();
            Global.Global.MovieReservation.Image = selectedMovie.ImageUri;
            Global.Global.MovieReservation.MovieName = Global.Global.SelectedMovie.Name;
            MainWindow.MainFrame.Navigate(new UserControl_BookingDetail());
        }
    }
}
