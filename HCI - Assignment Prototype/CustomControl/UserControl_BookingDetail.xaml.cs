using HCI___Assignment_Prototype.Page.View_Booking;
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

namespace HCI___Assignment_Prototype.CustomControl {
    /// <summary>
    /// Interaction logic for UserControl_BookingDetail.xaml
    /// </summary>
    public partial class UserControl_BookingDetail : UserControl {
        public static Frame DetailFrame;
        public enum CurrentPageEnum { SelectMovie, SelectLocation, SelectDate, SelectTime, SelectSeat, SelectCombo }

        private static UserControl_BookingDetail _current;
        public UserControl_BookingDetail() {
            InitializeComponent();
            frame.Navigate(new UserControl_SelectLocation());
            DetailFrame = frame;
            _current = this;
        }
        private static Style _flatStyle = Application.Current.FindResource("MaterialDesignFlatButton") as Style;
        private static Style _accentStyle = Application.Current.FindResource("MaterialDesignRaisedButton") as Style;

        private void ResetButtonStyle() {
            MovieButton.Style = _flatStyle;
            LocationButton.Style = _flatStyle;
            DateButton.Style = _flatStyle;
            TimeButton.Style = _flatStyle;
            SeatButton.Style = _flatStyle;
            ComboButton.Style = _flatStyle;
        }

        public static CurrentPageEnum CurrentPage {
            set {
                _current.ResetButtonStyle();
                Button b = null;
                UserControl pageToGo = null;
                switch (value) {
                    case CurrentPageEnum.SelectMovie:
                        b = _current.MovieButton;
                        pageToGo = new UserControl_SelectMovie();
                        break;
                    case CurrentPageEnum.SelectCombo:
                        b = _current.ComboButton;
                        //pageToGo = new UserControl_SelectCombo();
                        break;
                    case CurrentPageEnum.SelectDate:
                        b = _current.DateButton;
                        pageToGo = new UserControl_SelectDate();
                        break;
                    case CurrentPageEnum.SelectLocation:
                        b = _current.LocationButton;
                        pageToGo = new UserControl_SelectLocation();
                        break;
                    case CurrentPageEnum.SelectSeat:
                        b = _current.SeatButton;
                        pageToGo = new UserControl_SelectSeats();
                        break;
                    case CurrentPageEnum.SelectTime:
                        b = _current.TimeButton;
                        pageToGo = new UserControl_SelectTime();
                        break;
                }
                if (b != null) b.Style = _accentStyle;
                if (pageToGo != null) DetailFrame.Navigate(pageToGo);
            }
        }

        private void MovieButton_OnClick(object sender , RoutedEventArgs e) {
            CurrentPage = CurrentPageEnum.SelectMovie;
        }

        private void LocationButton_OnClick(object sender , RoutedEventArgs e) {
            CurrentPage = CurrentPageEnum.SelectLocation;
        }
    }
}
