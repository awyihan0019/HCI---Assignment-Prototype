using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI___Assignment_Prototype.Class {
    public class Movie {
        public string Name { get; set; }
        public List<DateTime> Date { get; set; }
        public List<DateTime> Time { get; set; }
        public string Description { get; set; }
        public List<string> AvailableLocation { get; set; }

        public Movie(string name, List<DateTime> date, List<DateTime> time, string description, List<string> availableLocation) {
            Name = name;
            Date = date;
            Time = time;
            Description = description;
            AvailableLocation = availableLocation;
        }
    }
}
