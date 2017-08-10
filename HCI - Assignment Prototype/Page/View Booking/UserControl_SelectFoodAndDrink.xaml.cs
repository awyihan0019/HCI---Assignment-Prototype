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

namespace HCI___Assignment_Prototype.Page.View_Booking
{
    /// <summary>
    /// Interaction logic for UserControl_SelectFoodAndDrink.xaml
    /// </summary>
    public partial class UserControl_SelectFoodAndDrink : UserControl
    {
        public static int TotalPayment;
        public UserControl_SelectFoodAndDrink()
        {
            InitializeComponent();
        }

        private void Click_ConfirmBooking(object sender, RoutedEventArgs e)
        {
            TotalPayment = (ComboA.Number*6) + (ComboB.Number*8);
            //CustomControl.UserControl_NumberCounter.NumberProperty
            DialogBox.Show("Booking Payment", "Do you really want to make this reservation?\n\nTotal Price : RM " + TotalPayment, "CANCEL", "CONFRIM");
            switch (DialogBox.Result)
            {
                case DialogBox.ResultEnum.LeftButtonClicked: return;
                case DialogBox.ResultEnum.RightButtonClicked:
                    ProgressDialog.Show("Making Reservation . . .", "",
                        () => {
                            DialogBox.Show("Payment Successed", "Your Reservation already made the e-ticket are sended to your e-mail.", "OK");
                        });
                    return;
            }
        }

        private void Click_cancelDetail(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.GoBack();
        }
    }
}
