using System.Windows;
using System.Windows.Controls;
using HCI___Assignment_Prototype.CustomControl.SeatPlaceControl;
using HCI___Assignment_Prototype.Page.Homepage;
using HCI___Assignment_Prototype.Page.View_Booking;
using MaterialDesignThemes.Wpf;

namespace HCI___Assignment_Prototype {
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public static Frame MainFrame;
        public static Snackbar Snackbar;

        public MainWindow() {
            InitializeComponent();
            MainFrame = Frame;
            Snackbar = snackbar;
            Snackbar.MessageQueue = new SnackbarMessageQueue();
            Frame.Navigate(new Homepage_BeforeLogin());
        }

        private void ExtraMenuButton_OnClick(object sender, RoutedEventArgs e) {
            DrawerHost.IsRightDrawerOpen = true;
        }
    }
}