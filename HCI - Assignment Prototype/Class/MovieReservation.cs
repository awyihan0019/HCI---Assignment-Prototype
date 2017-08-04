using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI___Assignment_Prototype.Class
{
    public class MovieReservation {
        public MovieReservation() : this("Spiderman: Homecoming", "8.00pm - 10.00pm", "8 June 2017", "GSC - Mid Valley", "A3, A4, A5", "-","Combo-A (2), Combo-B (1)"){
            
        }
        public MovieReservation(string movieName, string time, string date, string location, string normalSeat, string coupleSeat, string foodAndDrinks) {
            MovieName = movieName;
            Time = time;
            Date = date;
            Location = location;
            NormalSeat = normalSeat;
            CoupleSeat = coupleSeat;
            FoodAndDrinks = foodAndDrinks;
        }
        public string MovieName { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
        public string NormalSeat { get; set; }
        public string CoupleSeat { get; set; }
        public string FoodAndDrinks { get; set; }

    }
}
