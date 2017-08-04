﻿using HCI___Assignment_Prototype.CustomControl;
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
    /// Interaction logic for UserControl_SF_Verify.xaml
    /// </summary>
    public partial class UserControl_SF_Verify : UserControl
    {
        public UserControl_SF_Verify()
        {
            InitializeComponent();
        }

        private void Resend_Click(object sender, RoutedEventArgs e)
        {
            DialogBox.Show("Resend verify email", "The verify email already resend.", "OK");
        }
    }
}