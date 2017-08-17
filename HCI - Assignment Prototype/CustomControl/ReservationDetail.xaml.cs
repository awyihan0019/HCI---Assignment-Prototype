using System;
using System.Windows;
using System.Windows.Controls;
using HCI___Assignment_Prototype.Class;
using HCI___Assignment_Prototype.Page.CheckBooking;

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
            var thisReservation = this.DataContext as MovieReservation;
            if (thisReservation.WhenIsThisBook < (DateTime.Now.Add(new TimeSpan(1, 0, 0)))) {
                DialogBox.Show("Apologies.", "You cannot cancel a movie reservation that is showing within 24 hours.");
                return;
            }
                


            DialogBox.Show("WARNING!" , "Are you sure you want to cancel the reservation?\n[Note: This action cannot be undone]" , "NO" , "YES");
            switch (DialogBox.Result) {
                case DialogBox.ResultEnum.LeftButtonClicked: return;
                case DialogBox.ResultEnum.RightButtonClicked:
                    break;
            }
            DrawerHost.IsRightDrawerOpen = false;
            ProgressDialog.Show("Cancelling reservation . . ." , "Please hold on for a few seconds." , () => {
                MarkAsObsoleted("[CANCELLED]");
            });
            MainWindow.Snackbar.MessageQueue.Enqueue("A reservation had been cancelled.");
        }

        public void MarkAsObsoleted(string message) {
            ToolBox.Visibility = Visibility.Hidden;
            FeedbackLabel.Visibility = Visibility.Visible;
            FeedbackLabel.Text = message;
            Card.Opacity = 0.5;
        }

        private void EditButton_OnClick(object sender, RoutedEventArgs e) {
            Global.Global.MovieReservation = (MovieReservation)this.DataContext;
            MainWindow.MainFrame.Navigate(new UserControl_ReservationEdit());
        }
    }
}