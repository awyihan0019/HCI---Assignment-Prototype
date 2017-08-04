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
using HCI___Assignment_Prototype.CustomControl;
using HCI___Assignment_Prototype.Page;
using MaterialDesignThemes.Wpf;
using HCI___Assignment_Prototype.Page.Profile_Page;

namespace HCI___Assignment_Prototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public static Frame MainFrame;
        public static Snackbar Snackbar;
        public MainWindow()
        {
            InitializeComponent();
            MainFrame = this.Frame;
            Snackbar = this.snackbar;
            Snackbar.MessageQueue = new SnackbarMessageQueue();
            Frame.Navigate(new UserControl_UserProfile());            
        }

        private void ExtraMenuButton_OnClick(object sender, RoutedEventArgs e) {
            DrawerHost.IsRightDrawerOpen = true;
        }
    }
}
