using System;
using System.Windows;
using System.Windows.Controls;

namespace HCI___Assignment_Prototype.Page.Login {
    /// <summary>
    ///     Interaction logic for PasswordIncorrect.xaml
    /// </summary>
    public partial class PasswordIncorrect : UserControl {
        public PasswordIncorrect() {
            InitializeComponent();
        }

        private void CreateNewAccount_OnClick(object sender, RoutedEventArgs e) {
            MainWindow.MainFrame.GoBack();
        }

        private void ForgotYourPassword_OnClick(object sender, RoutedEventArgs e) {
            throw new NotImplementedException();
        }

        private void RetryButton_OnClick(object sender, RoutedEventArgs e) {
            MainWindow.MainFrame.GoBack();
        }
    }
}