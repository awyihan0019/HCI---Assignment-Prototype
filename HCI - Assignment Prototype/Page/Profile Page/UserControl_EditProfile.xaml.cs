using System.Windows;
using System.Windows.Controls;
using HCI___Assignment_Prototype.CustomControl;

namespace HCI___Assignment_Prototype.Page.Profile_Page {
    /// <summary>
    ///     Interaction logic for UserControl_EditProfile.xaml
    /// </summary>
    public partial class UserControl_EditProfile : UserControl {
        public UserControl_EditProfile() {
            InitializeComponent();
            var u = Global.Global.CurrentUser;
            PasswordField.Text = u.Password;
            NameField.Text = u.Username;
            PhoneField.Text = u.PhoneNumber;
            AddressField.Text = u.Address;
            
        }

        private void Save_Click(object sender, RoutedEventArgs e) {
            var u = Global.Global.CurrentUser;
            u.Password = PasswordField.Text;
            u.Username = NameField.Text;
            u.PhoneNumber = PhoneField.Text;
            u.Address = AddressField.Text;
            ProgressDialog.Show("Updating profile......", "", () => {
                DialogBox.Show("", "Profile successfully updated!", "OK");
                MainWindow.MainFrame.GoBack();
            });
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e) {
            MainWindow.MainFrame.GoBack();
        }
    }
}