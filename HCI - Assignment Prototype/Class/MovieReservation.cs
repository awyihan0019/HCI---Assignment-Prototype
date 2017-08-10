using System.Windows.Media.Imaging;

namespace HCI___Assignment_Prototype.Class {
    public class MovieReservation {
        public MovieReservation(bool isEmpty) : this("-", "-", "-","-","-","-","-") {
            
        }
        public MovieReservation() : this("Spiderman: Homecoming", "8.00pm - 10.00pm", "8 June 2017", "GSC - Mid Valley",
            "A3, A4, A5", "-", "Combo-A (2), Combo-B (1)", null) { }

        public MovieReservation(string movieName, string time, string date, string location, string normalSeat,
                                string coupleSeat, string foodAndDrinks, BitmapImage image = null) {
            MovieName = movieName;
            Time = time;
            Date = date;
            Location = location;
            NormalSeat = normalSeat;
            CoupleSeat = coupleSeat;
            FoodAndDrinks = foodAndDrinks;
            Image = image;
        }

        public string MovieName { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
        public string NormalSeat { get; set; }
        public string CoupleSeat { get; set; }
        public string FoodAndDrinks { get; set; }
        public BitmapImage Image { get; set; }
    }
}