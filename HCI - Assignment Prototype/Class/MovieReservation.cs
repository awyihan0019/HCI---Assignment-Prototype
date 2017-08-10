﻿using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace HCI___Assignment_Prototype.Class {
    public class MovieReservation {
        public MovieReservation() : this("-", "-", "-","-","-","-",null) {
            
        }
        public MovieReservation(string movieName, string time, string date, string location, string normalSeat,
                                string coupleSeat, List<FoodAndDrinks> foodAndDrinks =null, BitmapImage image = null) {
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
        public List<FoodAndDrinks> FoodAndDrinks { get; set; }
        public BitmapImage Image { get; set; }
    }
}