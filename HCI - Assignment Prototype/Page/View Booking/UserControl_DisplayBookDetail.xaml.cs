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

namespace HCI___Assignment_Prototype.Page.View_Booking
{
    /// <summary>
    /// Interaction logic for UserControl_DisplayBookDetail.xaml
    /// </summary>
    public partial class UserControl_DisplayBookDetail : UserControl
    {
        public UserControl_DisplayBookDetail()
        {
            InitializeComponent();
        }

        private void Click_cancelDetail(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.GoBack();
        }

        private void Click_ConfirmBooking(object sender, RoutedEventArgs e)
        {
            DialogBox.Show("Comfirm Payment", "Do you really want to make the payment?", "CANCEL", "CONFIRM");
            switch (DialogBox.Result)
            {
                case DialogBox.ResultEnum.LeftButtonClicked: return;
                case DialogBox.ResultEnum.RightButtonClicked:
                    ProgressDialog.Show("Progress Payment", "", () =>
                    {

                    });
                    return;
            }
        }
    }
}