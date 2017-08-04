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

namespace HCI___Assignment_Prototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public static Frame MainFrame;
        public MainWindow()
        {
            InitializeComponent();
            MainFrame = this.Frame;
            ProgressDialog.Show("Loading . . .","Signing out . . .");
            Frame.Navigate(new UserControl_Login());
        }
    }
}
