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

namespace HCI___Assignment_Prototype.Page.Homepage
{
    /// <summary>
    /// Interaction logic for Homepage_BeforeLogin.xaml
    /// </summary>
    public partial class Homepage_BeforeLogin : UserControl
    {
        public Homepage_BeforeLogin()
        {
            InitializeComponent();
        }

        private void LogInButton_OnClick(object sender, RoutedEventArgs e) {
            MainWindow.MainFrame.Navigate(new UserControl_Login());
        }

        private void SignUpButto_OnClick(object sender, RoutedEventArgs e) {
            MainWindow.MainFrame.Navigate(new UserControl_SignUp());
        }
    }
}
