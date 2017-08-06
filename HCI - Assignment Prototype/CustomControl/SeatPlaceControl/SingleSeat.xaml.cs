using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HCI___Assignment_Prototype.CustomControl.SeatPlace {
    /// <summary>
    /// Interaction logic for SingleSeat.xaml
    /// </summary>
    public partial class SingleSeat : UserControl {
        private static Random random = new Random();
        public event EventHandler Clicked;
        public SingleSeat() {
            InitializeComponent();

            SeatState =
                random.Next() % 2 == 0 ?
                SeatStateEnum.Occupied :
                SeatStateEnum.Unoccupied;
            OnSeatStatePropertyChanged(this , new DependencyPropertyChangedEventArgs(SeatStateProperty , null , SeatState));
        }

        #region SeatStateProperty
        public enum SeatStateEnum {
            Occupied, Unoccupied, Highlighted
        }

        public SeatStateEnum SeatState {
            get { return (SeatStateEnum)GetValue(SeatStateProperty); }
            set { SetValue(SeatStateProperty , value); }
        }

        public static readonly DependencyProperty SeatStateProperty =
            DependencyProperty.Register("SeatState" , typeof(SeatStateEnum) , typeof(SingleSeat) , new PropertyMetadata(SeatStateEnum.Unoccupied , OnSeatStatePropertyChanged));

        private static void OnSeatStatePropertyChanged(DependencyObject d , DependencyPropertyChangedEventArgs e) {
            var newValue = (SeatStateEnum)e.NewValue;
            var seat = d as SingleSeat;
            if (seat == null) return;
            switch (newValue) {
                case SeatStateEnum.Highlighted:
                    seat.Image.Source = new BitmapImage(new Uri(@"seat_black.png" , UriKind.Relative));
                    seat.Label.Foreground = Brushes.White;
                    break;
                case SeatStateEnum.Occupied:
                    seat.Image.Source = new BitmapImage(new Uri(@"seat_red.png" , UriKind.Relative));
                    seat.Label.Visibility = Visibility.Hidden;
                    break;
                case SeatStateEnum.Unoccupied:
                    seat.Image.Source = new BitmapImage(new Uri(@"seat_blue.png" , UriKind.Relative));
                    seat.Label .Visibility = Visibility.Visible;
                    seat.Label.Foreground = Brushes.Black;
                    break;
            }
        }

        #endregion

        #region SeatNumberProperty



        public int SeatNumber {
            get { return (int)GetValue(SeatNumberProperty); }
            set { SetValue(SeatNumberProperty , value); }
        }

        // Using a DependencyProperty as the backing store for SeatNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SeatNumberProperty =
            DependencyProperty.Register("SeatNumber" , typeof(int) , typeof(SingleSeat) , new PropertyMetadata(0 , OnSeatNumberPropertyChanged));

        private static void OnSeatNumberPropertyChanged(DependencyObject d , DependencyPropertyChangedEventArgs e) {
            var seat = d as SingleSeat;
            if (seat == null) return;
            var newValue = (int)e.NewValue;
            seat.Label.Content = newValue;
        }

        #endregion
        private void Button_OnClick(object sender , RoutedEventArgs e) {
            switch (SeatState) {
                case SeatStateEnum.Occupied:
                    return;
                case SeatStateEnum.Unoccupied:
                    SeatState = SeatStateEnum.Highlighted;
                    break;
                case SeatStateEnum.Highlighted:
                    SeatState = SeatStateEnum.Unoccupied;
                    break;
            }
            Clicked?.Invoke(this,null);
        }

    }
}

