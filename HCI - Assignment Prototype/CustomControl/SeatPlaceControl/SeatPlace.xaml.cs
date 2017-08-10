using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using HCI___Assignment_Prototype.CustomControl.SeatPlace;

namespace HCI___Assignment_Prototype.CustomControl.SeatPlaceControl {
    /// <summary>
    /// Interaction logic for SeatPlace.xaml
    /// </summary>
    public partial class SeatPlace : UserControl {
        public SeatPlace() {
            InitializeComponent();
            InitializeAreaGrid();
            BuildSeats();
            BuildLabelling();
        }

        private void BuildLabelling() {
            for (int i = 0 ; i < LabelArea.RowDefinitions.Count ; i++) {
                var label = new Label() {
                    Content = (char)('A' + i) ,
                    VerticalAlignment = VerticalAlignment.Center ,
                    FontWeight = FontWeights.Bold ,
                    FontSize = 20
                };
                LabelArea.Children.Add(label);
                Grid.SetColumn(label , 0);
                Grid.SetRow(label , i);
            }
        }

        private void BuildSeats() {
            //  BuildSeat(LeftArea);
            BuildSeat(MiddleArea);
            //BuildSeat(RightArea);
        }

        private void BuildSeat(Grid g) {
            int columnNo = g.ColumnDefinitions.Count;
            int rowNo = g.RowDefinitions.Count;
            for (int i = 0 ; i < columnNo ; i++) {
                for (int j = 0 ; j < rowNo ; j++) {
                    var seat = new SingleSeat() { SeatNumber = i + 1 };
                    seat.Clicked += Seat_Clicked;
                    g.Children.Add(seat);
                    Grid.SetColumn(seat , i);
                    Grid.SetRow(seat , j);
                }
            }
        }

        private void Seat_Clicked(object sender , System.EventArgs e) {
            var s = sender as SingleSeat;
            int number = s.SeatNumber;
            char rowLabel = (char)(Grid.GetRow((UIElement)sender) + 'A');
            string seatLabel = rowLabel.ToString() + number;
            if (s.SeatState == SingleSeat.SeatStateEnum.Highlighted) {
                HighlightedSeats += " " + seatLabel;
            }
            else {
                HighlightedSeats = HighlightedSeats.Replace(seatLabel, "");
            }
            HighlightedSeatsLabel.Content = HighlightedSeats.Trim();
        }



        private void InitializeAreaGrid() {
            //label area = 10 x 1
            SetColumns(LabelArea , 1);
            SetRows(LabelArea , 10);

            //left area = 10 x 4 ; 
            SetColumns(LeftArea , 4);
            SetRows(LeftArea , 10);

            //right area = 10 x 4
            SetColumns(RightArea , 4);
            SetRows(RightArea , 10);

            //mid area = 14 x 10
            SetColumns(MiddleArea , 14);
            SetRows(MiddleArea , 10);
        }

        private void SetColumns(Grid g , int howManyColumns) {
            for (int i = 0 ; i < howManyColumns ; i++) { //initialize 
                g.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }

        private void SetRows(Grid g , int howManyRows) {
            for (int i = 0 ; i < howManyRows ; i++) {
                g.RowDefinitions.Add(new RowDefinition());
            }
        }

        public string HighlightedSeats { get; private set; } = "";
    }
}
