using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
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
            Frame.Navigate(new DropDownSelectionList()
            {
                DataContext = new List<Item>()
                {
                    new Item("GSC"),
                    new Item("The mines"),
                    new Item("Garden")
                }
            });
        }

        private void ExtraMenuButton_OnClick(object sender , RoutedEventArgs e) {
            DrawerHost.IsRightDrawerOpen = true;
        }

        private void HomeButton_OnClick(object sender , RoutedEventArgs e) {
            if (Global.Global.CurrentUser == null || Global.Global.CurrentUser.IsVerified == false)
                MainFrame.Navigate(new Homepage_BeforeLogin());
            else
                MainFrame.Navigate(new Homepage_AfterLogin());
        }
    }
}