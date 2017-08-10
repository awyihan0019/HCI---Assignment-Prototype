using System.Collections.Generic;
using HCI___Assignment_Prototype.Class;

namespace HCI___Assignment_Prototype.Global {
    public static class Global {
        public static User CurrentUser = null;
        public static MovieReservation MovieReservation = new MovieReservation(true);
        public static Movie SelectedMovie;
    }
}