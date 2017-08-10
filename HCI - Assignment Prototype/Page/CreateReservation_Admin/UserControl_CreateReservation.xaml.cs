﻿using HCI___Assignment_Prototype.CustomControl;
using Microsoft.Win32;
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

namespace HCI___Assignment_Prototype.Page.CreateReservation_Admin
{
    public partial class UserControl_CreateReservarion : UserControl
    {
        public UserControl_CreateReservarion()
        {
            InitializeComponent();
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.GoBack();
        }

        private void SaveReservationCreate_Click(object sender, RoutedEventArgs e)
        {
                DialogBox.Show("Do you really want to create this reservation", "", "CANCEL", "SAVE");
                switch (DialogBox.Result)
                {
                    case DialogBox.ResultEnum.LeftButtonClicked: return;
                    case DialogBox.ResultEnum.RightButtonClicked:
                        {
                            ProgressDialog.Show("Creating Reservation......", "", () => {
                                DialogBox.Show("", "Reservation successfully created!", "OK");
                                MainWindow.MainFrame.GoBack();
                            });
                            return;
                        }
                }
        }

        private void Click_UploadPoster(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                var newImage = new BitmapImage(new Uri(op.FileName));
                PosterImage.Source = newImage;
                
            }
        }
    }
}