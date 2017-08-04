using HCI___Assignment_Prototype.CustomControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HCI___Assignment_Prototype.Page.Login;

namespace HCI___Assignment_Prototype.Page
{
    /// <summary>
    /// Interaction logic for UserControl_Login.xaml
    /// </summary>
    public partial class UserControl_Login : UserControl
    {
        public UserControl_Login()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e) {
            string email = Textbox_EmailFront.Text + "@" + Textbox_EmailBack.Text;
            if (email == Global.Global.OnlyUser.Email) {
                MainWindow.MainFrame.Navigate(new UserControl_Login2());
            }
            else {
                MainWindow.MainFrame.Navigate(new EmailDoesNotExist());
            }
        }

        private void Textbox_EmailFront_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
