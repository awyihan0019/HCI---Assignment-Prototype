using System.Windows;
using System.Windows.Controls;

namespace HCI___Assignment_Prototype.Page.Profile_Page {
    /// <summary>
    ///     Interaction logic for UserControl_UserProfile.xaml
    /// </summary>
    public partial class UserControl_UserProfile : UserControl {
        public UserControl_UserProfile() {
            InitializeComponent();
            var u = Global.Global.CurrentUser;
            NameField.Text = u.Username;
            PhoneField.Text = u.PhoneNumber;
            AddressField.Text = u.Address;
            EmailField.Text = u.Email;
            ProfilePicture.Source = u.ProfilePicture;
        }

        private void EditProfile_Click(object sender, RoutedEventArgs e) {
            MainWindow.MainFrame.Navigate(new UserControl_EditProfile());

            
        }
    }
}