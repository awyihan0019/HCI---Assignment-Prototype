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

namespace HCI___Assignment_Prototype.Page.Profile_Page
{
    /// <summary>
    /// Interaction logic for UserControl_EditProfile.xaml
    /// </summary>
    public partial class UserControl_EditProfile : UserControl
    {
        public UserControl_EditProfile()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            ProgressDialog.Show("Updating profile......", "", () =>
            {
                DialogBox.Show("", "Profile successfully updated!", "OK");
                MainWindow.MainFrame.GoBack();
            });
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.GoBack();
        }
    }
}
