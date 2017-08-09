using System.Collections.Generic;
using HCI___Assignment_Prototype.Class;

namespace HCI___Assignment_Prototype.Global {
    public static class Global {
        public static string Email;
      //  public static User OnlyUser = new User("clement@gmail.com", "clement99", "阿狗");
        public static List<User> Users = new List<User>(
            )
        {
            new User("clement@gmail.com", "clement99", "阿狗", true){
                ProfilePicture = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(@"pack://application:,,,/Page/Login/emptyuser.png"))
            },

        };

        public static User CurrentUser = null;
        public static MovieReservation MovieReservation = new MovieReservation();
    }
}