using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace HCI___Assignment_Prototype.Class {
    public class Movie {
        public BitmapImage ImageUri { get; set; }
        public string Name { get; set; }
        public List<DateTime> Date { get; set; }
        public List<DateTime> Time { get; set; }
        public string Description { get; set; }
        public List<string> AvailableLocation { get; set; }
        public string Category { get; set; }
        public string ReleaseDate { get; set; }
        public string RunningTime { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }
       

        public Movie(string name, List<DateTime> date, List<DateTime> time, string description, List<string> availableLocation, string category, BitmapImage imageUri, string releaseDate="", string runningTime="", string director="", string cast="") {
            Name = name;
            Date = date;
            Time = time;
            Description = description;
            AvailableLocation = availableLocation;
            Category = category;
            ImageUri = imageUri;
            ReleaseDate = releaseDate;
            RunningTime = runningTime;
            Director = director;
            Cast = cast;
        }

        public Movie(string releaseDate, string runningTime, string director, string cast) {
        }
    }
}
