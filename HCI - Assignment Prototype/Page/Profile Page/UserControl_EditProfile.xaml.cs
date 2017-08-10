using System.Windows;
using System.Windows.Controls;
using HCI___Assignment_Prototype.CustomControl;
using Microsoft.Win32;
using System.Windows.Media.Imaging;
using System;

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
            ProfilePicture.Source = u.ProfilePicture;
            
        }

        private void Save_Click(object sender, RoutedEventArgs e) {
            var u = Global.Global.CurrentUser;
            u.Password = PasswordField.Text;
            u.Username = NameField.Text;
            u.PhoneNumber = PhoneField.Text;
            u.Address = AddressField.Text;
            ProgressDialog.Show("Updating profile......", "", () => {
                DialogBox.Show("", "Profile successfully updated!", "OK");
                MainWindow.MainFrame.Navigate(new UserControl_UserProfile());
            });
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e) {
            MainWindow.MainFrame.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                var newImage = new BitmapImage(new Uri(op.FileName));
                ProfilePicture.Source = newImage;
                Global.Global.CurrentUser.ProfilePicture = newImage;
            }
        }
    }
}