using HCI___Assignment_Prototype.CustomControl;
using HCI___Assignment_Prototype.Page.Profile_Page;
using System.Windows.Controls;

namespace HCI___Assignment_Prototype.Page.Homepage {
    /// <summary>
    ///     Interaction logic for Homepage_AfterLogin.xaml
    /// </summary>
    public partial class Homepage_AfterLogin : UserControl {
        public Homepage_AfterLogin() {
            InitializeComponent();
        }

        private void ViewProfile(object sender, System.Windows.RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new UserControl_UserProfile());
        }

        private void LogOut(object sender, System.Windows.RoutedEventArgs e)
        {
            DialogBox.Show("Logout the account", "Do you really want to logout your account?", "Cancel", "Logout");
        }
    }
}