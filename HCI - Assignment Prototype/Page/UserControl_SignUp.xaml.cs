using HCI___Assignment_Prototype.CustomControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HCI___Assignment_Prototype.Page
{
    /// <summary>
    /// Interaction logic for UserControl_SignUp.xaml
    /// </summary>
    public partial class UserControl_SignUp : UserControl
    {
        public UserControl_SignUp()
        {
            InitializeComponent();
        }

        private void CreateProfile_Click(object sender, RoutedEventArgs e)
        {
            string email = Textbox_EmailFront.Text + "@" + Textbox_EmailBack.Text;
            string password = Passwordbox_Password.Password;
            string rePassword = Passwordbox_PasswordReenter.Password;
            if (Textbox_EmailFront.Text == null | Textbox_EmailBack.Text == null)
            {
                DialogBox.Show("Create Error", "you must enter email.", "OK");
            }
            else if(Passwordbox_Password.Password == null)
            {
                DialogBox.Show("Create Error", "you must enter the password.", "OK");
            }
            else if (Passwordbox_PasswordReenter.Password == null)
            {
                DialogBox.Show("Create Error", "you must enter the re-enter password.", "OK");
            }
            else if (password != rePassword)
            {
                DialogBox.Show("Create Error", "your enter password and re-enter password must be the same.", "OK");
            }
            if (email != "kowgau99@gmail.com")
            {

            }
            else{
                DialogBox.Show("Email already used", "Profile Not Created\nEmail already used !!!", "OK");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            //
        }
    }
}
