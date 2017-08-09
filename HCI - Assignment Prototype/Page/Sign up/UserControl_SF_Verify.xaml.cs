using System.Windows;
using System.Windows.Controls;
using HCI___Assignment_Prototype.CustomControl;
using HCI___Assignment_Prototype.Page.Homepage;

namespace HCI___Assignment_Prototype.Page {
    /// <summary>
    ///     Interaction logic for UserControl_SF_Verify.xaml
    /// </summary>
    public partial class UserControl_SF_Verify : UserControl {
        public UserControl_SF_Verify() {
            InitializeComponent();
            SecondSentence.Text += " " + Global.Global.Email;
        }

        private void Resend_Click(object sender , RoutedEventArgs e) {
            MainWindow.Snackbar.MessageQueue.Enqueue("Verification mail resent.");
        }

        private void Submit_Click(object sender , RoutedEventArgs e) {
            ProgressDialog.Show("Loading . . ." , "Verifiying Code . . ." , () => {
                if (VerificationCode.Text != "1234") DialogBox.Show("Error!" , "Verification code is incorrect." , "RETRY");
                else {
                    Global.Global.CurrentUser.IsVerified = true;
                    DialogBox.Show("Profile successfully created!" , "" , "OK");
                    if (DialogBox.Result == DialogBox.ResultEnum.LeftButtonClicked) {
                        MainWindow.MainFrame.Navigate(new Homepage_BeforeLogin());
                        DialogBox.Show(new UserControl_Login());
                    }
                }
            });


        }
    }
}