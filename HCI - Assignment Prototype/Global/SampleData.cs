using HCI___Assignment_Prototype.Class;
using HCI___Assignment_Prototype.CustomControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

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

        public static List<Movie> SampleMovies = new List<Movie>()
        {
            new Movie("Dunkirk",
                new List<DateTime>(){
                    new DateTime(2017, 07, 19, 0, 0, 0),
                    new DateTime(2017, 07, 20, 0, 0, 0),
                    new DateTime(2017, 07, 21, 0, 0, 0),
                    new DateTime(2017, 07, 22, 0, 0, 0),
                    new DateTime(2017, 07, 23, 0, 0, 0)
                },
                new List<DateTime>(){
                    new DateTime(1, 1, 1, 2, 30, 0),
                    new DateTime(1, 1, 1, 4, 30, 0),
                    new DateTime(1, 1, 1, 8, 30, 0),
                    new DateTime(1, 1, 1, 10, 30, 0),
                    new DateTime(1, 1, 1, 1, 30, 0)
                }, 
                "The story about the retreat of the British 4th Army from the Wehrmacht in Dunkirk.",
                new List<string>(){
                    "Mid Valley",
                    "OneU",
                    "NuSentral",
                    "Sunway Pyramid",
                    "Ipoh Parade"
                }, 
                "PG 13", 
                new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/dunkirk.png")),
                "13 July 2017", 
                "2 Hours", 
                "Christopher Nolan",
                "Fionn Whitehead, Tom Glynn-Carrey, Jack Lowden"),

            new Movie("Doom",
                new List<DateTime>(){
                    new DateTime(2017, 09, 19, 0, 0, 0),
                    new DateTime(2017, 09, 20, 0, 0, 0),
                    new DateTime(2017, 09, 21, 0, 0, 0),
                    new DateTime(2017, 09, 22, 0, 0, 0),
                    new DateTime(2017, 09, 23, 0, 0, 0)
                },
                new List<DateTime>(){
                    new DateTime(1, 1, 1, 2, 30, 0),
                    new DateTime(1, 1, 1, 4, 30, 0),
                    new DateTime(1, 1, 1, 8, 30, 0),
                    new DateTime(1, 1, 1, 10, 30, 0),
                    new DateTime(1, 1, 1, 1, 30, 0)
                }, "An action packed story about the being who sought to eliminate hell itself.",
                new List<string>(){
                    "Mid Valley",
                    "OneU",
                    "Gardens",
                    "Sunway Pyramid",
                    "Ipoh Parade"
                },
                "PG 18+", 
                new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/doom.png")),
                "06 September 2017",
                "2 Hours 30 Minutes",
                "Marty Stratton",
                "Samuel Hayden, Doom Slayer, Olivia Pierce"
                ),

            new Movie("Wolfenstein 2",
                new List<DateTime>(){
                    new DateTime(2017, 06, 19, 0, 0, 0),
                    new DateTime(2017, 06, 20, 0, 0, 0),
                    new DateTime(2017, 06, 21, 0, 0, 0),
                    new DateTime(2017, 06, 22, 0, 0, 0),
                    new DateTime(2017, 06, 23, 0, 0, 0)
                },
                new List<DateTime>(){
                    new DateTime(1, 1, 1, 2, 30, 0),
                    new DateTime(1, 1, 1, 4, 30, 0),
                    new DateTime(1, 1, 1, 8, 30, 0),
                    new DateTime(1, 1, 1, 10, 30, 0),
                    new DateTime(1, 1, 1, 1, 30, 0)
                }, "America has fallen into the hands of Nazi Germany, it is up to Captain B. J. Blazkowicz to wake America for the second revolution.",
                new List<string>(){
                    "Mid Valley",
                    "OneU",
                    "Gardens",
                    "Sunway Pyramid",
                    "Ipoh Parade"

                }, "PG 18+",
                new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/wolfenstein2.jpg")),
                "10 June 2017",
                "2 Hours",
                "Jens Matthies",
                "B.J. Blazkowicz, Wilhelm Strasse, Fergus Reid"
                ),

            new Movie("Der Untergang",
                new List<DateTime>(){
                    new DateTime(2017, 08, 19, 0, 0, 0),
                    new DateTime(2017, 08, 20, 0, 0, 0),
                    new DateTime(2017, 08, 21, 0, 0, 0),
                    new DateTime(2017, 08, 22, 0, 0, 0),
                    new DateTime(2017, 08, 23, 0, 0, 0)
                },
                new List<DateTime>(){
                    new DateTime(1, 1, 1, 2, 30, 0),
                    new DateTime(1, 1, 1, 4, 30, 0),
                    new DateTime(1, 1, 1, 8, 30, 0),
                    new DateTime(1, 1, 1, 10, 30, 0),
                    new DateTime(1, 1, 1, 1, 30, 0)
                }, "A story about the ending days of the Third Reich and the days leading to Hitler's suicide.",
                new List<string>(){
                    "Mid Valley",
                    "OneU",
                    "Gardens",
                    "Sunway Pyramid",
                    "Ipoh Parade"
                }, 
                "PG 13+", 
                new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/deruntergang.png")),
                "01 August 2017",
                "3 Hours",
                "Oliver Hirschbiegel",
                "Bruno Ganz, Alexandra Maria Lara, Ulrich Matthes"
                ),

            new Movie("Beauty and The Beast",
                new List<DateTime>(){
                    new DateTime(2017, 08, 19, 0, 0, 0),
                    new DateTime(2017, 08, 20, 0, 0, 0),
                    new DateTime(2017, 08, 21, 0, 0, 0),
                    new DateTime(2017, 08, 22, 0, 0, 0),
                    new DateTime(2017, 08, 23, 0, 0, 0)
                },
                new List<DateTime>(){
                    new DateTime(1, 1, 1, 2, 30, 0),
                    new DateTime(1, 1, 1, 4, 30, 0),
                    new DateTime(1, 1, 1, 8, 30, 0),
                    new DateTime(1, 1, 1, 10, 30, 0),
                    new DateTime(1, 1, 1, 1, 30, 0)
                }, "A live movie adaptation of the Disney classic animation, Beauty and The Beast.",
                new List<string>(){
                    "Mid Valley",
                    "OneU",
                    "Gardens",
                    "Sunway Pyramid",
                    "Ipoh Parade"
                }, "U",
                new BitmapImage( new Uri(@"pack://application:,,,/Global/MovieIcon/beauty&beast.png")),
                "07 August 2017",
                "2 Hours 30 Minutes",
                "Bill Condon",
                "Emma Watson, Dan Stevens, Luke Evans"
                )
        };

        public static Uri SampleUri = new Uri(@"pack://application:,,,/Global/MovieIcon/beauty&beast.png" , UriKind.RelativeOrAbsolute);
    }
}
