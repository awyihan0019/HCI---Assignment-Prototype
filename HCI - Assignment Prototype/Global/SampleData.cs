﻿using HCI___Assignment_Prototype.Class;
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
            new MovieReservation("Beauty and The Beast", "8:00p.m. - 10:00p.m.",
                "30 June 2017", "GSC-MidValley", "A1 A2 A3", "-", new List<FoodAndDrinks>(){
                    new FoodAndDrinks("Combo A", 3, 7.99)

                }, new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/beauty&beast.jpg"))),

            new MovieReservation("Wolfenstein 2: The New Colossus", "1:00p.m. - 3:00p.m.",
                "10 July 2017", "GSC-NuSentral", "A6 A7", "-", new List<FoodAndDrinks>(){
                    new FoodAndDrinks("Combo B", 2, 11.99)

                }, new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/wolfenstein2.jpg"))),

            new MovieReservation("Der Untergang", "10:00p.m. - 12:00p.m.",
                "13 August 2017", "GSC-SunwayPyramid", "A10 A11 A12", "-", new List<FoodAndDrinks>(){
                    new FoodAndDrinks("Combo C", 3, 11.99)

                },new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/deruntergang.jpg"))),

            new MovieReservation("Beauty & The Beast", "3:00p.m. - 5:00p.m.",
                "14 August 2017", "GSC-OneU", "D3 D4", "-", new List<FoodAndDrinks>(){
                    new FoodAndDrinks("Combo D", 1 , 14.99)

                }, new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/beauty&beast.jpg"))),

            new MovieReservation("Wolfenstein 2: The New Colossus", "10:00p.m. - 12:00a.m.",
                "20 August 2017", "GSC-OneU", "B13 B14", "-", new List<FoodAndDrinks>(){
                    new FoodAndDrinks("Combo A", 1 , 7.99)

                }, new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/wolfenstein2.jpg"))),

            new MovieReservation("Dunkirk", "5:00p.m. - 7:00p.m.",
                "25 August 2017", "GSC-MidValley", "A7 A13 A14", "-", new List<FoodAndDrinks>(){
                    new FoodAndDrinks("Combo B", 2, 11.99)

                }, new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/dunkirk.jpg"))),

            new MovieReservation("Doom", "10:00a.m. - 12:00p.m.",
                "26 August 2017", "GSC-NuSentral", "A1 A2 A3", "-", new List<FoodAndDrinks>(){
                    new FoodAndDrinks("Combo C", 3, 11.99)

                }, new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/doom.png"))),

            new MovieReservation("Dunkirk", "12:00a.m. - 2:00a.m.",
                "29 August 2017", "GSC-OneU", "F1 F2", "-", new List<FoodAndDrinks>(){
                    new FoodAndDrinks("Combo D", 1, 14.99)

                }, new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/dunkirk.jpg"))),

            new MovieReservation("Doom", "8:00p.m. - 10:00p.m.",
                "30 August 2017", "GSC-Gardens", "E5 E6", "-", new List<FoodAndDrinks>(){
                    new FoodAndDrinks("Combo A", 1, 7.99)

                }, new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/doom.png"))),

            new MovieReservation("Der Untergang", "12:00p.m. - 2:00p.m.",
                "31 August 2017", "GSC-IpohParade", "G7", "CC4", new List<FoodAndDrinks>(){
                    new FoodAndDrinks ("Combo B", 1, 11.99)

                }, new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/deruntergang.jpg")))
            };

        public static List<Movie> SampleMovies = new List<Movie>()
        {
            new Movie("Dunkirk",
                new List<DateTime>(){
                    new DateTime(2017, 08, 19, 0, 0, 0),
                    new DateTime(2017, 08, 20, 0, 0, 0),
                    new DateTime(2017, 08, 21, 0, 0, 0),
                    new DateTime(2017, 08, 22, 0, 0, 0),
                    new DateTime(2017, 08, 23, 0, 0, 0)
                },
                new List<DateTime>(){
                    new DateTime(1, 1, 1, 8, 30, 0),
                    new DateTime(1, 1, 1, 12, 30, 0),
                    new DateTime(1, 1, 1, 16, 30, 0),
                    new DateTime(1, 1, 1, 20, 30, 0),
                    new DateTime(1, 1, 1, 00, 30, 0)
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
                new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/dunkirk.jpg")),
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
                    new DateTime(1, 1, 1, 12, 30, 0),
                    new DateTime(1, 1, 1, 16, 30, 0),
                    new DateTime(1, 1, 1, 20, 30, 0),
                    new DateTime(1, 1, 1, 22, 30, 0),
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
                    new DateTime(2017, 10, 19, 0, 0, 0),
                    new DateTime(2017, 10, 20, 0, 0, 0),
                    new DateTime(2017, 10, 21, 0, 0, 0),
                    new DateTime(2017, 10, 22, 0, 0, 0),
                    new DateTime(2017, 10, 23, 0, 0, 0)
                },
                new List<DateTime>(){
                    new DateTime(1, 1, 1, 8, 30, 0),
                    new DateTime(1, 1, 1, 12, 30, 0),
                    new DateTime(1, 1, 1, 14, 30, 0),
                    new DateTime(1, 1, 1, 18, 30, 0),
                    new DateTime(1, 1, 1, 23, 30, 0)
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
                    new DateTime(1, 1, 1, 11, 30, 0),
                    new DateTime(1, 1, 1, 13, 30, 0),
                    new DateTime(1, 1, 1, 15, 30, 0),
                    new DateTime(1, 1, 1, 19, 30, 0),
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
                new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/deruntergang.jpg")),
                "01 August 2017",
                "3 Hours",
                "Oliver Hirschbiegel",
                "Bruno Ganz, Alexandra Maria Lara, Ulrich Matthes"
                ),

            new Movie("Beauty and The Beast",
                new List<DateTime>(){
                    new DateTime(2017, 08, 24, 0, 0, 0),
                    new DateTime(2017, 08, 25, 0, 0, 0),
                    new DateTime(2017, 08, 26, 0, 0, 0),
                    new DateTime(2017, 08, 27, 0, 0, 0),
                    new DateTime(2017, 08, 28, 0, 0, 0)
                },
                new List<DateTime>(){
                    new DateTime(1, 1, 1, 10, 30, 0),
                    new DateTime(1, 1, 1, 12, 30, 0),
                    new DateTime(1, 1, 1, 17, 30, 0),
                    new DateTime(1, 1, 1, 20, 30, 0),
                    new DateTime(1, 1, 1, 00, 30, 0)
                }, "A live movie adaptation of the Disney classic animation, Beauty and The Beast.",
                new List<string>(){
                    "Mid Valley",
                    "OneU",
                    "Gardens",
                    "Sunway Pyramid",
                    "Ipoh Parade"
                }, "U",
                new BitmapImage( new Uri(@"pack://application:,,,/Global/MovieIcon/beauty&beast.jpg")),
                "07 August 2017",
                "2 Hours 30 Minutes",
                "Bill Condon",
                "Emma Watson, Dan Stevens, Luke Evans"
                )
        };

        public static List<MovieReservation_Admin> SampleReservationDetails_Admin = new List<MovieReservation_Admin>()
        {
            new MovieReservation_Admin("Fallout 4",
                "PG 18",
                "www.youtube.com/fallout4",
                "30 July 2017",
                "Mid Valley, " + "OneU, " + "Gardens," + "Sunway Pyramid," + "Ipoh Parade",
                "A story about a lone survivor in a post apocalytic world.",
                "2 Hours 30 Minutes",
                "Todd Howard",
                "Nate Dunkirque, Roger Maxson, Nick Valentine",
                new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/fallout4.png"))
                ),
            
            new MovieReservation_Admin("Emoji Movie",
                "U",
                "www.youtube.com/emojimovie",
                "01 August 2017",
                "Mid Valley, " + "OneU, " + "Gardens," + "Sunway Pyramid," + "NuSentral",
                "Meh story that should never be made. Damn you Sony Pictures.",
                "2 Hours",
                "Tony Leondis",
                "T.J. Miller, James Corden, Anna Faris",
                new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/emoji.jpg"))
                ),

            new MovieReservation_Admin("Guardians of The Galaxy Vol 2",
                "PG 13",
                "www.youtube.com/guardians2",
                "02 August 2017",
                "Mid Valley, " + "OneU, " + "NuSentral," + "Sunway Pyramid," + "Ipoh Parade",
                "The long awaited sequel to the hit superhero action movie.",
                "3 Hours",
                "James Gunn (II)",
                "Chris Pratt, Zoe Saldana, Dave Bautista",
                new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/guardians2.jpg"))
                ),

            new MovieReservation_Admin("Wonder Woman",
                "PG 13",
                "www.youtube.com/wonderwoman",
                "03 August 2017",
                "Mid Valley, " + "OneU, " + "NuSentral," + "Gardens," + "Ipoh Parade",
                "A movie about an Amazonian Princess that soon learns about the war that engulfs the planet.",
                "3 Hours",
                "Patty Jenkins",
                "Gal Gadot, Chris Pine, Connie Nielsen",
                new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/wonderwoman.jpg"))
                ),

            new MovieReservation_Admin("Despicable Me 3",
                "PG 13",
                "www.youtube.com/despicableme3",
                "04 August 2017",
                "Mid Valley, " + "Sunway Pyramid, " + "NuSentral," + "Gardens," + "Ipoh Parade",
                "The 3rd Movie where little yellow banana looking things get all the attention.",
                "2 Hours 30 Minutes",
                "Kyle Balda",
                "Steve Carell, Kristen Wiig, Trey Parker",
                new BitmapImage(new Uri(@"pack://application:,,,/Global/MovieIcon/dm3.jpg"))
                )


        };

        public static List<User> Users = new List<User>(
        )
        {
            new User("admin@admin.com", "admin", "Muthu", true)
            {
                IsAdmin = true
            },
            new User("clement@gmail.com", "clement99", "阿狗", true){
                ProfilePicture = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(@"pack://application:,,,/Page/Login/emptyuser.png")),
                Reservations = new List<MovieReservation>()
                {
                    SampleReservationDetails[0],
                    SampleReservationDetails[2],
                    SampleReservationDetails[5],
                    SampleReservationDetails[6]
                }
            },

            new User("abu@hotmail.com", "abu", "Abu", true){
                ProfilePicture = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(@"pack://application:,,,/Page/Login/abu.png")),
                Reservations = new List<MovieReservation>()
                {
                    SampleReservationDetails[1],
                    SampleReservationDetails[2],
                    SampleReservationDetails[3],
                    SampleReservationDetails[5]
                }
            },

            new User("donald@hotmail.com", "donald", "Donald Trump", true){
                ProfilePicture = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(@"pack://application:,,,/Page/Login/donald.png")),
                Reservations = new List<MovieReservation>()
                {
                    SampleReservationDetails[1],
                    SampleReservationDetails[2],
                    SampleReservationDetails[5]
                },
                PhoneNumber = "012-9172898",
                Address = "The White House"
            }
        };
    }
}
