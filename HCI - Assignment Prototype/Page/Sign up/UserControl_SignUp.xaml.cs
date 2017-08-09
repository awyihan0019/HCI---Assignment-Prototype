using System.Linq;
using System.Windows;
using System.Windows.Controls;
using HCI___Assignment_Prototype.CustomControl;
using HCI___Assignment_Prototype.Global;

namespace HCI___Assignment_Prototype.Page {
    /// <summary>
    ///     Interaction logic for UserControl_SignUp.xaml
    /// </summary>
    public partial class UserControl_SignUp : UserControl {
        public UserControl_SignUp() {
            InitializeComponent();
        }

        private void CreateProfile_Click(object sender , RoutedEventArgs e) {
            Verify();
        }


        private void Verify() {
            var email = Textbox_EmailFront.Text;
            var password = PasswordBox.Password;
            var rePassword = Passwordbox_PasswordReenter.Password;

            if ((Textbox_EmailFront.Text == "")) {
                DialogBox.Show("Error . . ." , "You must enter email." , "OK");


            }
            else if (PasswordBox.Password == "") {
                DialogBox.Show("Error . . ." , "You must enter the password." , "OK");
            }
            else if (Passwordbox_PasswordReenter.Password == "") {
                DialogBox.Show("Error . . ." , "You must enter the re-enter password." , "OK");
            }
            else if (password != rePassword) {
                DialogBox.Show("Error . . ." , "Password does not match" , "OK");
            }
            else {
                try {
                    var addr = new System.Net.Mail.MailAddress(email);
                }
                catch {
                    DialogBox.Show("Error . . ." , "Email is not in correct format." , "OK");
                    return;
                }
                if (Global.Global.Users.Any(x => x.Email == email))
                    DialogBox.Show("Error . . ." , $"The email of '{email}' has already been used." , "OK");
                else {
                    Global.Global.Email = email;
                    ProgressDialog.Show("Creating profile . . ." , "" ,
                        () => {
                            MainWindow.MainFrame.Navigate(new UserControl_SF_Verify());
                            var newUser = new User(email , password , email);
                            Global.Global.Users.Add(newUser);
                            Global.Global.CurrentUser = newUser;

                        });
                }
            }
        }

        private void CancelButton_Click(object sender , RoutedEventArgs e) {
            MainWindow.MainFrame.GoBack();
        }

        private void PasswordBox_KeyUp(object sender , System.Windows.Input.KeyEventArgs e) {
            if (e.Key == System.Windows.Input.Key.Enter) {
                CreateProfile_Click(null , null);
            }
        }
    }
}