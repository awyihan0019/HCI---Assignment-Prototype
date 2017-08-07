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
using HCI___Assignment_Prototype.Global;

namespace HCI___Assignment_Prototype.Page.View_Booking {
    /// <summary>
    /// Interaction logic for UserControl_SelectMovie.xaml
    /// </summary>
    public partial class UserControl_SelectMovie : UserControl {
        public UserControl_SelectMovie() {
            InitializeComponent();
            ListView.ItemsSource = SampleData.SampleMovies;

        }
    }
}
