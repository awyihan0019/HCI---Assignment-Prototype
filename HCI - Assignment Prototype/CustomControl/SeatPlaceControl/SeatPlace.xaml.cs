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
        }

        private void BuildSeats() {
            BuildSeat(LeftArea);
            BuildSeat(MiddleArea);
            BuildSeat(RightArea);
        }

        private void BuildSeat(Grid g) {
            int columnNo = g.ColumnDefinitions.Count;
            int rowNo = g.RowDefinitions.Count;
            for (int i = 0; i < columnNo; i++) {
                for (int j = 0; j < rowNo; j++) {
                    var seat = new SingleSeat();
                    g.Children.Add(seat);
                    Grid.SetColumn(seat,i);
                    Grid.SetRow(seat,j);
                }
            }
        }

        private void InitializeAreaGrid() {
            //left area = 10 x 4 
            SetColumns(LeftArea , 4);           
            SetRows(LeftArea,10);

            //right area = 10 x 4
            SetColumns(RightArea , 4);
            SetRows(RightArea,10);

            //mid area = 14 x 10
            SetColumns(MiddleArea , 14);
            SetRows(MiddleArea, 10);
        }

        private void SetColumns(Grid g , int howManyColumns) {
            for (int i = 0 ; i < howManyColumns ; i++) { //initialize 
                g.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }

        private void SetRows(Grid g, int howManyRows) {
            for (int i = 0; i < howManyRows; i++) {
                g.RowDefinitions.Add(new RowDefinition());
            }
        }
    }
}
