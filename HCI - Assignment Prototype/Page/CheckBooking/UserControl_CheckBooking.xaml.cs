using HCI___Assignment_Prototype.CustomControl;
using HCI___Assignment_Prototype.Global;
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
using HCI___Assignment_Prototype.Class;

namespace HCI___Assignment_Prototype.Page.CheckBooking
{
    /// <summary>
    /// Interaction logic for UserControl_CheckBooking.xaml
    /// </summary>
    public partial class UserControl_CheckBooking : UserControl
    {
        public UserControl_CheckBooking()
        {
            InitializeComponent();
            var incoming = SampleData.SampleReservationDetails.
                Where(m => DateTime.Parse(m.Date) >= DateTime.Today).ToList();
            var expired = SampleData.SampleReservationDetails.
                Where(m => DateTime.Parse(m.Date) < DateTime.Today).ToList();
            foreach (var item in incoming)
            {
                BookingList.Children.Add(new ReservationDetail() { DataContext = item });
            }
            foreach (var item in expired) {
               var r = new ReservationDetail(){DataContext = item};
                r.MarkAsObsoleted("[EXPIRED]");
                BookingList.Children.Add(r);

            }
        }
    }
}
