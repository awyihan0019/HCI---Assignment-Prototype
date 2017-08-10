using HCI___Assignment_Prototype.CustomControl;
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
    /// Interaction logic for UserControl_TopUp.xaml
    /// </summary>
    public partial class UserControl_TopUp : UserControl
    {
        public UserControl_TopUp()
        {
            InitializeComponent();
        }

        private void TopUp_Click(object sender, RoutedEventArgs e)
        {
            DialogBox.Show("Top-Up", "Do you really want make this Top-Up\n\nAmount : " + Amount.TextBlock.Text, "CANCEL", "CONFIRM");
            switch(DialogBox.Result)
            {
                case DialogBox.ResultEnum.LeftButtonClicked: return;
                case DialogBox.ResultEnum.RightButtonClicked:
                    MainWindow.MainFrame.Navigate(new UserControl_TopUpProcess());
                    return;
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.GoBack();
        }
    }
}
