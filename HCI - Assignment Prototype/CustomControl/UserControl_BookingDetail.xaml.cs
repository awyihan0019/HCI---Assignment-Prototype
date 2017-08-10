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

        public enum CurrentPageEnum {
            SelectMovie = 0,
            SelectLocation,
            SelectDate,
            SelectTime,
            SelectSeat,
            SelectCombo
        }

        private static UserControl_BookingDetail _current;
        public UserControl_BookingDetail() {
            InitializeComponent();
            DetailFrame = frame;
            _current = this;
            CurrentPage = CurrentPageEnum.SelectLocation;
        }
        private static Style _flatStyle = Application.Current.FindResource("MaterialDesignFlatButton") as Style;
        private static Style _accentStyle = Application.Current.FindResource("MaterialDesignRaisedButton") as Style;
        private static CurrentPageEnum _currentPage;

        private void ResetButtonStyle() {
            MovieButton.Style = _flatStyle;
            LocationButton.Style = _flatStyle;
            DateButton.Style = _flatStyle;
            TimeButton.Style = _flatStyle;
            SeatButton.Style = _flatStyle;
            ComboButton.Style = _flatStyle;
        }

        public static CurrentPageEnum CurrentPage {
            get => _currentPage;
            set {
                Button b = null;
                UserControl pageToGo = null;
                _currentPage = value;

                //1. Set the content of current button
                (b, pageToGo) = GetButtonAndPageToGo((_currentPage - 1));
                if (b == null || pageToGo == null) return;
                b.Content = GetContent(_currentPage - 1);

                //2. Focus the next button
                _current.ResetButtonStyle();
                (b, pageToGo) = GetButtonAndPageToGo(_currentPage);
                if (b != null) b.Style = _accentStyle;
                if (pageToGo != null) DetailFrame.Navigate(pageToGo);
            }
        }

        private static string GetContent(CurrentPageEnum c) {
            switch (c) {
                case CurrentPageEnum.SelectMovie:
                    return "Movie : " + Global.Global.MovieReservation.MovieName;
                case CurrentPageEnum.SelectLocation:
                    return "Location : " + Global.Global.MovieReservation.Location;
                case CurrentPageEnum.SelectDate:
                    return "Date : " + Global.Global.MovieReservation.Date;
                case CurrentPageEnum.SelectTime:
                    return "Time : " + Global.Global.MovieReservation.Time;
                case CurrentPageEnum.SelectSeat:
                    return "Seats : " + Global.Global.MovieReservation.NormalSeat;
                case CurrentPageEnum.SelectCombo:
                    return "Combo : " + Global.Global.MovieReservation.FoodAndDrinks;
                default:
                    return "";
            }
        }

        private static (Button, UserControl) GetButtonAndPageToGo(CurrentPageEnum c) {
            switch (c) {
                case CurrentPageEnum.SelectMovie:
                    return (_current.MovieButton, new UserControl_SelectMovie());
                case CurrentPageEnum.SelectCombo:
                    return (_current.ComboButton, new UserControl_SelectFoodAndDrink());
                case CurrentPageEnum.SelectDate:
                    return (_current.DateButton, new UserControl_SelectDate());
                case CurrentPageEnum.SelectLocation:
                    return (_current.LocationButton, new UserControl_SelectLocation());
                case CurrentPageEnum.SelectSeat:
                    return (_current.SeatButton, new UserControl_SelectSeats());
                case CurrentPageEnum.SelectTime:
                    return (_current.TimeButton, new UserControl_SelectTime());
                default:
                    MainWindow.MainFrame.Navigate(new UserControl_SelectMovie());
                    break;
            }
            return (null, null);
        }

        private void MovieButton_OnClick(object sender , RoutedEventArgs e) {
            CurrentPage = CurrentPageEnum.SelectMovie;
        }

        private void LocationButton_OnClick(object sender , RoutedEventArgs e) {
            CurrentPage = CurrentPageEnum.SelectLocation;
        }


        private void DateButton_OnClick(object sender , RoutedEventArgs e) {
            CurrentPage = CurrentPageEnum.SelectDate;
        }

        private void TimeButton_OnClick(object sender , RoutedEventArgs e) {
            CurrentPage = CurrentPageEnum.SelectTime;
        }

        private void SeatButton_OnClick(object sender , RoutedEventArgs e) {
            CurrentPage = CurrentPageEnum.SelectSeat;
        }

        private void ComboButton_OnClick(object sender , RoutedEventArgs e) {
            CurrentPage = CurrentPageEnum.SelectCombo;
        }
    }
}
