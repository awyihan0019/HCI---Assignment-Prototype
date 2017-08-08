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

        private void DeleteButton_OnClick(object sender, RoutedEventArgs e) {
            this.DrawerHost.IsRightDrawerOpen = true;
        }

        private void YesButton_OnClick(object sender, RoutedEventArgs e) {
            var da = CustomAnimation.GetLeavingScreenAnimation(this.ActualHeight, 0, false);
            this.BeginAnimation(HeightProperty, da);

        }

        public void MarkAsExpired() {
            ToolBox.Visibility = Visibility.Hidden;
            ExpiredLabel.Visibility = Visibility.Visible;
            Card.Opacity = 0.5;
        }
    }
}