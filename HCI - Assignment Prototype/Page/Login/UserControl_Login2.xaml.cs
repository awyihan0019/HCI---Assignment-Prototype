using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using HCI___Assignment_Prototype.CustomControl;
using HCI___Assignment_Prototype.Page.Login;
using HCI___Assignment_Prototype.Page.Homepage;
using HCI___Assignment_Prototype.Global;
using HCI___Assignment_Prototype.Page.Homepage_Admin;

namespace HCI___Assignment_Prototype.Page {
    /// <summary>
    ///     Interaction logic for UserControl_Login2.xaml
    /// </summary>
    public partial class UserControl_Login2 : UserControl {
        public UserControl_Login2() {
            InitializeComponent();
            SentenceOne.Text += " " + Global.Global.CurrentUser.Username + "!";
            Image.Source = Global.Global.CurrentUser.ProfilePicture;
            PasswordBox.Focus();
            Keyboard.Focus(PasswordBox);
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e) {
            if (PasswordBox.Password == Global.Global.CurrentUser.Password) {
                DialogBox.CloseDialog();
                if (Global.Global.CurrentUser.IsAdmin) {
                    MainWindow.MainFrame.Navigate(new UserControl_HomePage_Admin());
                    return;
                }
                if (Global.Global.CurrentUser.IsVerified == false) {
                    MainWindow.MainFrame.Navigate(new UserControl_SF_Verify());
                    return;
                }
                DialogBox.Show("Login Successful!", "", "OK");
                MainWindow.MainFrame.Navigate(new Homepage_AfterLogin());
            }
            else {
                DialogBox.Show(new PasswordIncorrect());
            }
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e) {
            DialogBox.Show(new UserControl_Login());
        }

        private void PasswordBox_OnKeyUp(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) LoginButton_Click(null, null);
        }
    }
}