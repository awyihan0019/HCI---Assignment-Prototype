using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace HCI___Assignment_Prototype.Class {
    public class MovieReservation_Admin {
        public MovieReservation_Admin(string movieName, string category, string trailerLink, string releaseDate, string cinemas, string description, string runningTime, string director, string cast, BitmapImage image) {
            MovieName = movieName;
            Category = category;
            TrailerLink = trailerLink;
            ReleaseDate = releaseDate;
            Cinemas = cinemas;
            Description = description;
            RunningTime = runningTime;
            Director = director;
            Cast = cast;
            Image = image;
        }
        public string MovieName { get; set; }
        public string Category { get; set; }
        public string TrailerLink { get; set; }
        public string ReleaseDate { get; set; }
        public string Cinemas { get; set; }
        public string Description { get; set; }
        public string RunningTime { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }
        public BitmapImage Image { get; set; }

        public MovieReservation_Admin() {
            
        }
    }
}
