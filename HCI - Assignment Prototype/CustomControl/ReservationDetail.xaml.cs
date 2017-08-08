using System.Windows;
using System.Windows.Controls;
using HCI___Assignment_Prototype.Class;

namespace HCI___Assignment_Prototype.CustomControl {
    /// <summary>
    ///     Interaction logic for CheckBooking.xaml
    /// </summary>
    public partial class ReservationDetail : UserControl {
        public ReservationDetail() {
            InitializeComponent();
        }

        private void DeleteButton_OnClick(object sender , System.Windows.RoutedEventArgs e) {
            this.DrawerHost.IsRightDrawerOpen = true;
        }

        private void YesButton_OnClick(object sender , RoutedEventArgs e) {
            DialogBox.Show("WARNING!" , "Are you sure you want to cancel the reservation?\n[Note: This action cannot be undone]" , "NO" , "YES");
            switch (DialogBox.Result) {
                case DialogBox.ResultEnum.LeftButtonClicked: return;
                case DialogBox.ResultEnum.RightButtonClicked:
                    break;
            }
            MarkAsObsoleted("[CANCELLED]");
            DrawerHost.IsRightDrawerOpen = false;
            //   var da = CustomAnimation.GetLeavingScreenAnimation(this.ActualHeight, 0, false);
            //  this.BeginAnimation(HeightProperty, da);
            MainWindow.Snackbar.MessageQueue.Enqueue("A reservation had been cancelled.");

        }

        public void MarkAsObsoleted(string message) {
            ToolBox.Visibility = Visibility.Hidden;
            FeedbackLabel.Visibility = Visibility.Visible;
            FeedbackLabel.Text = message;
            Card.Opacity = 0.5;
        }
    }
}