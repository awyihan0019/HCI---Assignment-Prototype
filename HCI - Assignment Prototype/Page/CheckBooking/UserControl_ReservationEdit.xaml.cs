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
using HCI___Assignment_Prototype.Class;
using HCI___Assignment_Prototype.CustomControl.SeatPlaceControl;
using HCI___Assignment_Prototype.Page.View_Booking;

namespace HCI___Assignment_Prototype.Page.CheckBooking {
    /// <summary>
    /// Interaction logic for UserControl_ReservationEdit.xaml
    /// </summary>
    public partial class UserControl_ReservationEdit : UserControl {
        public UserControl_ReservationEdit() {
            InitializeComponent();
            this.DataContext = Global.Global.MovieReservation;
        }

        private void Cancel_OnClick(object sender , RoutedEventArgs e) {
            MainWindow.MainFrame.GoBack();
        }

        private void SaveReservationEdit_Click(object sender , RoutedEventArgs e) {
            DialogBox.Show("Do you really want to update this reservation" , "" , "CANCEL" , "SAVE");
            switch (DialogBox.Result) {
                case DialogBox.ResultEnum.LeftButtonClicked: return;
                case DialogBox.ResultEnum.RightButtonClicked: {
                        ProgressDialog.Show("Updating profile......" , "" , () => {
                            var c = Global.Global.MovieReservation;
                            c.Location = LocationField.Text;
                            c.Time = TimeField.Text;
                            c.Date = DateField.Text;
                            c.NormalSeat = SeatField.Text;
                            //c.FoodAndDrinks = ComboField.Text;
                            Global.Global.CurrentUser.Reservations.RemoveAll(x => x.UID == c.UID);
                            Global.Global.CurrentUser.Reservations.Add(c);
                            DialogBox.Show("" , "Profile successfully updated!" , "OK");
                            MainWindow.MainFrame.Navigate(new UserControl_CheckReservation());
                        });

                        return;
                    }
            }
        }

        private void Seat_OnPencilButtonOnClick(object sender , EventArgs e) {
            DialogBox.Show(new UserControl_ReselectSeat());
            SeatField.PendingText = (string)DialogBox.ReturnedValue;
        }

        private void Combo_OnPencilButtonOnClick(object sender, EventArgs e) {
            DialogBox.Show(new UserControl_ReselectFoodAndDrink());
        }
        
    }
}