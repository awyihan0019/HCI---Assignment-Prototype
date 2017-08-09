using System.Windows.Media.Imaging;

namespace HCI___Assignment_Prototype.Global {
    public class User {
        public string Email;
        public string Password;
        public string Username;
        public bool IsVerified;
        public BitmapImage ProfilePicture;
        public User(string email, string password, string username, bool isVerified = false) {
            Email = email;
            Password = password;
            Username = username;
            IsVerified = isVerified;
        }
    }
}