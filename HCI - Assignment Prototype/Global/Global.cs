﻿using System.Collections.Generic;
using HCI___Assignment_Prototype.Class;

namespace HCI___Assignment_Prototype.Global {
    public static class Global {
        public static string Email;
      //  public static User OnlyUser = new User("clement@gmail.com", "clement99", "阿狗");
        public static List<User> Users = new List<User>(
            )
        {
            new User("clement@gmail.com", "clement99", "阿狗"),

        };

        public static User CurrentUser = Users[0];
        public static MovieReservation MovieReservation = new MovieReservation();
    }
}