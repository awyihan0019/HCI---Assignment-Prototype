using HCI___Assignment_Prototype.Page.View_Booking;
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
    /// Interaction logic for UserControl_BookingDetail.xaml
    /// </summary>
    public partial class UserControl_BookingDetail : UserControl
    {
        public static Frame DetailFrame;
        public UserControl_BookingDetail()
        {
            InitializeComponent();
            frame.Navigate(new UserControl_SelectLocation());
            DetailFrame = frame;
        }
    }
}
