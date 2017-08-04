﻿using HCI___Assignment_Prototype.Class;
using HCI___Assignment_Prototype.CustomControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI___Assignment_Prototype.Global
{
    public static class SampleData
    {
        public static List<MovieReservation> SampleReservationDetails = new List<MovieReservation>(){
            new MovieReservation("The Red Menace", "8:00p.m. - 10:00p.m.",
                "8 August 2017", "GSC-MidValley", "A1, A2, A3", "-", "Comba A(3)"),

            new MovieReservation("Wolfenstein 2: The New Colossus", "1:00p.m. - 3:00p.m.",
                "10 August 2017", "GSC-NuSentral", "A6, A7", "-", "Comba B(2)"),

            new MovieReservation("Metro 2033", "10:00p.m. - 12:00p.m.",
                "13 August 2017", "GSC-SunwayPyramid", "A10, A11, A12", "-", "Comba A(1), Combo B(2)"),

            new MovieReservation("Beauty & The Beast", "3:00p.m. - 5:00p.m.",
                "14 August 2017", "GSC-OneU", "A35", "-", "Comba A(1)"),

            new MovieReservation("Kaiserschlacht", "10:00p.m. - 12:00a.m.",
                "20 August 2017", "GSC-OneU", "-", "CC1", "Comba A(2)"),

            new MovieReservation("Saving Private Ryan", "5:00p.m. - 7:00p.m.",
                "25 August 2017", "GSC-MidValley", "A33, A34, A35", "-", "Comba B(3)"),

            new MovieReservation("Black Hawk Down", "10:00a.m. - 12:00p.m.",
                "26 August 2017", "GSC-NuSentral", "A1, A2, A3", "-", "-"),

            new MovieReservation("Dunkirk", "12:00a.m. - 2:00a.m.",
                "29 August 2017", "GSC-OneU", "-", "CC2", "Comba A(2)"),

            new MovieReservation("The Cabin In The Woods", "8:00p.m. - 10:00p.m.",
                "30 August 2017", "GSC-Gardens", "A54, A55", "-", "Comba A(3)"),

            new MovieReservation("Der Untergang", "12:00p.m. - 2:00p.m.",
                "31 August 2017", "GSC-IpohParade", "A40", "CC4", "Comba A(3)")
            };            
    }
}