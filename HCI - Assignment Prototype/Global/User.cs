using System.Collections.Generic;
using System.Windows.Media.Imaging;
using HCI___Assignment_Prototype.Class;

namespace HCI___Assignment_Prototype.Global {
    public class User {
        public string Email;
        public string Password;
        public string Username;
        public bool IsVerified;
        public string PhoneNumber;
        public string Address;
        public BitmapImage ProfilePicture = new BitmapImage(new System.Uri(@"pack://application:,,,/Page/Login/emptyuser.png"));
        public List<MovieReservation> Reservations;
        public bool IsAdmin = false;

        public User() {
            
        }

        public User(string email, string password, string username, bool isVerified = false , List<MovieReservation> reservations = null) {
            Email = email;
            Password = password;
            Username = username;
            Reservations = reservations;
            IsVerified = isVerified;
        }
    }
}