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

namespace HCI___Assignment_Prototype.CustomControl
{
    /// <summary>
    /// Interaction logic for ReservationDetail_Admin.xaml
    /// </summary>
    public partial class ReservationDetail_Admin : UserControl
    {
        public ReservationDetail_Admin()
        {
            InitializeComponent();
        }

        private void YesButton_OnClick(object sender, RoutedEventArgs e) {
            DialogBox.Show("WARNING!" , "Are you sure you want to disable the reservation profile?" , "NO" , "YES");
            switch (DialogBox.Result) {
                case DialogBox.ResultEnum.LeftButtonClicked: return;
                case DialogBox.ResultEnum.RightButtonClicked:
                    break;
            }
            DrawerHost.IsRightDrawerOpen = false;
            ProgressDialog.Show("Updating server . . .","Tearing down profile from production server . . .", () => {
            MarkAsObsoleted("[DISABLED]");
                
            });
        }

        public void MarkAsObsoleted(string message) {
            ToolBox.Visibility = Visibility.Hidden;
            FeedbackLabel.Visibility = Visibility.Visible;
            FeedbackLabel.Text = message;
            Card.Opacity = 0.5;
        }

        private void DisableButton_OnClick(object sender, RoutedEventArgs e) {
            this.DrawerHost.IsRightDrawerOpen = true;
        }
    }
}
