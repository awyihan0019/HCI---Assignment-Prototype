using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using HCI___Assignment_Prototype.Page.Login;
using HCI___Assignment_Prototype.CustomControl;

namespace HCI___Assignment_Prototype.Page {
    /// <summary>
    ///     Interaction logic for UserControl_Login.xaml
    /// </summary>
    public partial class UserControl_Login : UserControl {
        public UserControl_Login() {
            InitializeComponent();
        }



        private void Textbox_EmailFront_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) NextButton_OnClick(null, null);
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e) {
            DialogBox.CloseDialog();
        }

        private void NextButton_OnClick(object sender, RoutedEventArgs e) {
            var email = Textbox_EmailFront.Text;
            if (Global.Global.Users.Any(x => x.Email == email)) {
                Global.Global.CurrentUser = Global.Global.Users.Find(x => x.Email == email);
                DialogBox.Show(new UserControl_Login2());
            }
            else DialogBox .Show(new EmailDoesNotExist());
        }
    }
}