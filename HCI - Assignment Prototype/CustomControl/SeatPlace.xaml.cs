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

namespace HCI___Assignment_Prototype.CustomControl {
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
            throw new NotImplementedException();
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
