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

namespace HCI___Assignment_Prototype.Page.CreateReservation_Admin
{
    /// <summary>
    /// Interaction logic for UserControl_CreateReservarion.xaml
    /// </summary>
    public partial class UserControl_CreateReservarion : UserControl
    {
        public UserControl_CreateReservarion()
        {
            InitializeComponent();
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.GoBack();
        }

        private void SaveReservationCreate_Click(object sender, RoutedEventArgs e)
        {
                DialogBox.Show("Do you really want to create this reservation", "", "CANCEL", "SAVE");
                switch (DialogBox.Result)
                {
                    case DialogBox.ResultEnum.LeftButtonClicked: return;
                    case DialogBox.ResultEnum.RightButtonClicked:
                        {
                            ProgressDialog.Show("Creating Reservation......", "", () => {
                                DialogBox.Show("", "Reservation successfully created!", "OK");
                                MainWindow.MainFrame.GoBack();
                            });
                            return;
                        }
                }
        }
    }
}
