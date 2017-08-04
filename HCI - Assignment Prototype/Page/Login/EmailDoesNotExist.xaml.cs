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

namespace HCI___Assignment_Prototype.Page.Login
{
    /// <summary>
    /// Interaction logic for EmailDoesNotExist.xaml
    /// </summary>
    public partial class EmailDoesNotExist : UserControl
    {
        public EmailDoesNotExist()
        {
            InitializeComponent();
        }

        private void CreateNewAccount_OnClick(object sender, RoutedEventArgs e) {
            MainWindow.MainFrame.Navigate(new UserControl_SignUp());
        }

        private void RetryButton_OnClick(object sender, RoutedEventArgs e) {
            MainWindow.MainFrame.GoBack();
        }
    }
}
