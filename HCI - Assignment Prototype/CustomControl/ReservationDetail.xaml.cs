using System.Windows.Controls;

namespace HCI___Assignment_Prototype.CustomControl {
    /// <summary>
    ///     Interaction logic for CheckBooking.xaml
    /// </summary>
    public partial class ReservationDetail : UserControl {
        public ReservationDetail() {
            InitializeComponent();
        }

        private void DeleteButton_OnClick(object sender, System.Windows.RoutedEventArgs e)
        {
            DialogBox.Show("Do you really want cancel the following reservation?", "", "CANCEL", "CONFIRM");
            switch (DialogBox.Result)
            {
                case 
            }
        }
    }
}