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

namespace HCI___Assignment_Prototype.Page.CheckBooking {
    /// <summary>
    /// Interaction logic for UserControl_ReservationEdit.xaml
    /// </summary>
    public partial class UserControl_ReservationEdit : UserControl {
        public UserControl_ReservationEdit() {
            InitializeComponent();
        }

        private void Cancel_OnClick(object sender , RoutedEventArgs e) {
            MainWindow.MainFrame.GoBack();
        }

        private void SaveReservationEdit_Click(object sender , RoutedEventArgs e) {
            DialogBox.Show("Do you really want to update this reservation" , "" , "CANCEL" , "SAVE");
            switch (DialogBox.Result) {
                case DialogBox.ResultEnum.LeftButtonClicked: return;
                case DialogBox.ResultEnum.RightButtonClicked:
                    {
                        ProgressDialog.Show("Updating profile......", "", () => {
                            DialogBox.Show("", "Profile successfully updated!", "OK");
                            MainWindow.MainFrame.GoBack();
                        });

                        return;
                    }
            }
        }
    }
}