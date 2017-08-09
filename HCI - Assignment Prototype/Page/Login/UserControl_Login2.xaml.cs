using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using HCI___Assignment_Prototype.CustomControl;
using HCI___Assignment_Prototype.Page.Login;
using HCI___Assignment_Prototype.Page.Homepage;
using HCI___Assignment_Prototype.Global;

namespace HCI___Assignment_Prototype.Page {
    /// <summary>
    ///     Interaction logic for UserControl_Login2.xaml
    /// </summary>
    public partial class UserControl_Login2 : UserControl {
        public UserControl_Login2() {
            InitializeComponent();
            SentenceOne.Text += " " + Global.Global.OnlyUser.Username + "!";
            PasswordBox.Focus();
            Keyboard.Focus(PasswordBox);
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e) {
            if (PasswordBox.Password == Global.Global.OnlyUser.Password) {
                DialogBox.CloseDialog();
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