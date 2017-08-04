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
using HCI___Assignment_Prototype.CustomControl;
using HCI___Assignment_Prototype.Page.Login;

namespace HCI___Assignment_Prototype.Page
{
    /// <summary>
    /// Interaction logic for UserControl_Login2.xaml
    /// </summary>
    public partial class UserControl_Login2 : UserControl
    {
        public UserControl_Login2()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e) {
            if (PasswordBox.Password == "kow99") {
                DialogBox.Show("Login Successful!", "", "OK");
            }
            else {
                MainWindow.MainFrame.Navigate(new PasswordIncorrect());
            }
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e) {
            MainWindow.MainFrame.GoBack();
        }
    }
}
