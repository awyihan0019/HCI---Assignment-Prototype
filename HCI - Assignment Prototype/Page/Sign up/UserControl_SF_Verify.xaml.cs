using System.Windows;
using System.Windows.Controls;
using HCI___Assignment_Prototype.CustomControl;

namespace HCI___Assignment_Prototype.Page {
    /// <summary>
    ///     Interaction logic for UserControl_SF_Verify.xaml
    /// </summary>
    public partial class UserControl_SF_Verify : UserControl {
        public UserControl_SF_Verify() {
            InitializeComponent();
            SecondSentence.Text += " " + Global.Global.Email;
        }

        private void Resend_Click(object sender, RoutedEventArgs e) {
            MainWindow.Snackbar.MessageQueue.Enqueue("Verification mail resent.");
        }

        private void Submit_Click(object sender, RoutedEventArgs e) {
            if (VerificationCode.Text != "1234") DialogBox.Show("Error!", "Verification code is incorrect.", "RETRY");
            else
                ProgressDialog.Show("Loading . . .", "Going to homepage . . .", () => { });
        }
    }
}