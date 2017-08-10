using HCI___Assignment_Prototype.CustomControl;
using HCI___Assignment_Prototype.Page.Homepage;
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

namespace HCI___Assignment_Prototype.Page.Top_Up
{
    /// <summary>
    /// Interaction logic for UserControl_TopUpProcess.xaml
    /// </summary>
    public partial class UserControl_TopUpProcess : UserControl
    {
        public UserControl_TopUpProcess()
        {
            InitializeComponent();
        }

        private void NextStep_Click(object sender, RoutedEventArgs e)
        {
            ProgressDialog.Show("Processing Top-Up......", "", () => {
                DialogBox.Show("", "Top-Up successfully!", "OK");
                MainWindow.MainFrame.Navigate(new Homepage_AfterLogin());
            });
        }
    }
}
