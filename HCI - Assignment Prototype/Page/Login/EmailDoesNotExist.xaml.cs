using System.Windows;
using System.Windows.Controls;
using HCI___Assignment_Prototype.CustomControl;

namespace HCI___Assignment_Prototype.Page.Login {
    /// <summary>
    ///     Interaction logic for EmailDoesNotExist.xaml
    /// </summary>
    public partial class EmailDoesNotExist : UserControl {
        public EmailDoesNotExist() {
            InitializeComponent();
        }

        private void CreateNewAccount_OnClick(object sender, RoutedEventArgs e) {
            MainWindow.MainFrame.Navigate(new UserControl_SignUp());
        }

        private void RetryButton_OnClick(object sender, RoutedEventArgs e) {
            DialogBox.Show(new UserControl_Login());
        }
    }
}