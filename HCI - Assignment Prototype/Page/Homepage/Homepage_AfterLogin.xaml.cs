﻿using System.Windows;
using HCI___Assignment_Prototype.CustomControl;
using HCI___Assignment_Prototype.Page.Profile_Page;
using System.Windows.Controls;
using HCI___Assignment_Prototype.Page.CheckBooking;
using HCI___Assignment_Prototype.Page.Top_Up;
using HCI___Assignment_Prototype.Page.View_Booking;

namespace HCI___Assignment_Prototype.Page.Homepage {
    /// <summary>
    ///     Interaction logic for Homepage_AfterLogin.xaml
    /// </summary>
    public partial class Homepage_AfterLogin : UserControl {
        public Homepage_AfterLogin() {
            InitializeComponent();
            UsernameButton.Content = Global.Global.CurrentUser.Username;
            ProfilePicture.Source = Global.Global.CurrentUser.ProfilePicture;
        }

        private void ViewProfile(object sender, System.Windows.RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new UserControl_UserProfile());
        }

        private void LogOut(object sender, System.Windows.RoutedEventArgs e)
        {
            DialogBox.Show("Logout the account", "Do you really want to logout your account?", "Cancel", "Logout");
            switch (DialogBox.Result) {
                    case DialogBox.ResultEnum.LeftButtonClicked: return;
                    case DialogBox.ResultEnum.RightButtonClicked:
                        MainWindow.MainFrame.Navigate(new Homepage_BeforeLogin());
                        Global.Global.CurrentUser = null;
                        return;
            }
        }

        private void UserButton_OnClick(object sender, RoutedEventArgs e) {
            UserPopup.IsOpen = !UserPopup.IsOpen;
        }
        private void CheckBooking(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new UserControl_CheckReservation());
        }

        private void ProfilePicture_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            UserPopup.IsOpen = !UserPopup.IsOpen;
        }
        
        private void Click_TopUp(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new UserControl_TopUp());
        }

        private void BookTicket_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new UserControl_SelectMovie());
        }
    }
}