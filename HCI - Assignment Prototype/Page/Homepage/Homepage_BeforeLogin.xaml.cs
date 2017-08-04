using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace HCI___Assignment_Prototype.Page.Homepage {
    /// <summary>
    ///     Interaction logic for Homepage_BeforeLogin.xaml
    /// </summary>
    public partial class Homepage_BeforeLogin : UserControl {      
        public Homepage_BeforeLogin() {
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