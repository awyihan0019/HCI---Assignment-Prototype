using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using HCI___Assignment_Prototype.Class;
using HCI___Assignment_Prototype.CustomControl;
using HCI___Assignment_Prototype.CustomControl.SeatPlaceControl;
using HCI___Assignment_Prototype.Global;
using HCI___Assignment_Prototype.Page;
using HCI___Assignment_Prototype.Page.CheckBooking;
using HCI___Assignment_Prototype.Page.Homepage;
using HCI___Assignment_Prototype.Page.View_Booking;
using MaterialDesignThemes.Wpf;
using HCI___Assignment_Prototype.CustomControl;
using HCI___Assignment_Prototype.Page.CheckBooking;
using HCI___Assignment_Prototype.Page.CreateReservation_Admin;
using HCI___Assignment_Prototype.Page.Homepage_Admin;

namespace HCI___Assignment_Prototype {
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public static Frame MainFrame;
        public static Snackbar Snackbar;

        public MainWindow() {
            InitializeComponent();
            MainFrame = Frame;
            Snackbar = this.snackbar;
            Snackbar.MessageQueue = new SnackbarMessageQueue();
            Frame.Navigate(new Homepage_BeforeLogin());
        }

        private void ExtraMenuButton_OnClick(object sender , RoutedEventArgs e) {
            DrawerHost.IsRightDrawerOpen = true;
        }

        private void HomeButton_OnClick(object sender , RoutedEventArgs e) {
            if (Global.Global.CurrentUser == null || Global.Global.CurrentUser.IsVerified == false)
                MainFrame.Navigate(new Homepage_BeforeLogin());
            else {
                if (Frame.Content.GetType() == typeof(UserControl_DisplayBookDetail) || Frame.Content.GetType() == typeof(UserControl_SelectDate) || Frame.Content.GetType() == typeof(UserControl_SelectFoodAndDrink) || Frame.Content.GetType() == typeof(UserControl_SelectLocation) || Frame.Content.GetType() == typeof(UserControl_SelectMovie) || Frame.Content.GetType() == typeof(UserControl_SelectSeats) || Frame.Content.GetType() == typeof(UserControl_SelectTime)) {
                    //vincent here
                    DialogBox.Show("Did you " , "" , "CANCEL" , "CONFIRM");
                    switch (DialogBox.Result) {
                        case DialogBox.ResultEnum.LeftButtonClicked:
                            break;
                        case DialogBox.ResultEnum.RightButtonClicked:
                            MainFrame.Navigate(new Homepage_AfterLogin());
                            break;
                    }
                }
                else
                    MainFrame.Navigate(new Homepage_AfterLogin());

            }
        }
        private void Home_Click(object sender , RoutedEventArgs e) {
            if (Global.Global.CurrentUser == null || Global.Global.CurrentUser.IsVerified == false)
                MainFrame.Navigate(new Homepage_BeforeLogin());
            else {

                MainFrame.Navigate(new Homepage_AfterLogin());

            }
        }

        private void ShowingNowButton_Click(object sender , RoutedEventArgs e) {
            MainFrame.Navigate(new UserControl_SelectMovie());
        }

        private void Frame_Navigated(object sender , System.Windows.Navigation.NavigationEventArgs e) {

        }

        private void CreditButton_Click(object sender , RoutedEventArgs e) {

        }

        private void Support_Click(object sender , RoutedEventArgs e) {

        }

        private void Frame_OnNavigating(object sender , NavigatingCancelEventArgs e) {
            if (Frame.Content == null) return;
            if (Frame.Content.GetType() == typeof(UserControl_BookingDetail) && e.Content.GetType() != typeof(UserControl_DisplayBookDetail)) {
                DialogBox.Show("Did you really want to leave this page?" , "Changes you made will not be saved." , "STAY" , "LEAVE");
                switch (DialogBox.Result) {
                    case DialogBox.ResultEnum.LeftButtonClicked:
                        e.Cancel = true;
                        break;
                    case DialogBox.ResultEnum.RightButtonClicked:
                        break;
                }
            }
        }
    }
}