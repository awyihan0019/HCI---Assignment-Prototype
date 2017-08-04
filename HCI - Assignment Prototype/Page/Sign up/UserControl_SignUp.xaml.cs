using System.Windows;
using System.Windows.Controls;
using HCI___Assignment_Prototype.CustomControl;

namespace HCI___Assignment_Prototype.Page {
    /// <summary>
    ///     Interaction logic for UserControl_SignUp.xaml
    /// </summary>
    public partial class UserControl_SignUp : UserControl {
        public UserControl_SignUp() {
            InitializeComponent();
        }

        private void CreateProfile_Click(object sender, RoutedEventArgs e) {
            Verify();
        }


        private void Verify() {
            var email = Textbox_EmailFront.Text + "@" + Textbox_EmailBack.Text;
            var password = Passwordbox_Password.Password;
            var rePassword = Passwordbox_PasswordReenter.Password;

            if ((Textbox_EmailFront.Text == "") | (Textbox_EmailBack.Text == "")) {
                DialogBox.Show("Create Error", "Profile Created Failed.\nYou must enter email.", "OK");
            }
            else if (Passwordbox_Password.Password == "") {
                DialogBox.Show("Create Error", "Profile Created Failed.\nYou must enter the password.", "OK");
            }
            else if (Passwordbox_PasswordReenter.Password == "") {
                DialogBox.Show("Create Error", "Profile Created Failed.\nYou must enter the re-enter password.", "OK");
            }
            else if (password != rePassword) {
                DialogBox.Show("Create Error", "Profile Created Failed.\nPassword does not match", "OK");
            }
            else {
                if (email != Global.Global.OnlyUser.Email) {
                    Global.Global.Email = email;
                    ProgressDialog.Show("Creating profile . . .", "",
                        () => { MainWindow.MainFrame.Navigate(new UserControl_SF_Verify()); });
                }
                else {
                    DialogBox.Show("Email already used", "Profile Not Created.\nEmail already used !!!", "OK");
                }
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e) { }
    }
}