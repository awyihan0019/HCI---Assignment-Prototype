using System.Windows;
using HCI___Assignment_Prototype.CustomControl;
using HCI___Assignment_Prototype.Page.Profile_Page;
using System.Windows.Controls;
using HCI___Assignment_Prototype.Page.CheckBooking;

namespace HCI___Assignment_Prototype.Page.Homepage {
    /// <summary>
    ///     Interaction logic for Homepage_AfterLogin.xaml
    /// </summary>
    public partial class Homepage_AfterLogin : UserControl {
        public Homepage_AfterLogin() {
            InitializeComponent();
            UsernameButton.Tag = Global.Global.CurrentUser.Username;
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
    }
}