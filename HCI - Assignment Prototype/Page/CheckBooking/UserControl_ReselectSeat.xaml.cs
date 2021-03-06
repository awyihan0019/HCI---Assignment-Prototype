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

namespace HCI___Assignment_Prototype.Page.CheckBooking
{
    /// <summary>
    /// Interaction logic for UserControl_ReselectSeat.xaml
    /// </summary>
    public partial class UserControl_ReselectSeat : UserControl
    {
        public int Seat;
        public UserControl_ReselectSeat()
        {
            InitializeComponent();
            String numberOfSeat = Global.Global.MovieReservation.NormalSeat;
            Seat = coutSeat(numberOfSeat, ' ');
            String[] seats = numberOfSeat.Split(' ');
            for(int i = 0; i < seats.Count(); i++)
            {
                Char row = seats[i][0];
                int column = int.Parse(seats[i].Substring(1));
                SeatPlace.SelectSeat(row, column);
            }
        }

        private void SeatReselect_Next(object sender, RoutedEventArgs e)
        {
            if (coutSeat(SeatPlace.HighlightedSeats, ' ') == Seat)
            {
                DialogBox.ReturnedValue = SeatPlace.HighlightedSeats;
                DialogBox.CloseDialog();
            }
            else if(coutSeat(SeatPlace.HighlightedSeats, ' ') < Seat)
            {
                
                DialogBox.Show("Your selected seat does not match the original amount. Original Seat Amount: " + (Seat + 1), "", "OK");
                switch (DialogBox.Result)
                {
                    case DialogBox.ResultEnum.LeftButtonClicked:
                        DialogBox.ReturnedValue = SeatPlace.HighlightedSeats;
                        DialogBox.CloseDialog();
                        break;
                    case DialogBox.ResultEnum.RightButtonClicked:
                        break;
                }
            }
            else
                DialogBox.Show("Seat Editing must not exceed the original amount :" + (Seat + 1), "", "OK");
        }

        private void BackButton_onClick(object sender, RoutedEventArgs e)
        {
            DialogBox.CloseDialog();
        }

        private int coutSeat(String seat, Char coutValue)
        {
            int count = seat.Count(ch => ch == coutValue);
            return count;
        }
    }
}
