﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using HCI___Assignment_Prototype.Page.Login;

namespace HCI___Assignment_Prototype.Page {
    /// <summary>
    ///     Interaction logic for UserControl_Login.xaml
    /// </summary>
    public partial class UserControl_Login : UserControl {
        public UserControl_Login() {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e) {
            var email = Textbox_EmailFront.Text + "@" + Textbox_EmailBack.Text;
            if (email == Global.Global.OnlyUser.Email) MainWindow.MainFrame.Navigate(new UserControl_Login2());
            else MainWindow.MainFrame.Navigate(new EmailDoesNotExist());
        }

        private void Textbox_EmailFront_TextChanged(object sender, TextChangedEventArgs e) { }

        private void Textbox_EmailBack_OnKeyUp(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) SubmitButton_Click(null, null);
        }
    }
}