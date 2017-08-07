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
    }
}
