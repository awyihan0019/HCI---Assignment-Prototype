﻿using System;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace HCI___Assignment_Prototype.CustomControl {
    /// <summary>
    /// Interaction logic for DialogBox.xaml
    /// </summary>
    public partial class ProgressDialog : Window {
        public ProgressDialog() {
            InitializeComponent();
        }      

        public static void Show(string title , string message) {
            var p = new ProgressDialog();
            p.SetContent(title , message);
            p.DialogHost.IsOpen = true;
            var timer = new DispatcherTimer {Interval = TimeSpan.FromSeconds(3)};
            timer.Tick += (sender, args) => {
                p.Hide();
            };
            timer.Start();
            p.ShowDialog();            
        }

        private void SetContent(string title , string message) {            
            TextBlock_Title.Text = title;
            TextBlock_Message.Text = message;                        
        }

        private void SampleCode() {
            ProgressDialog.Show("Loading" , "message");
            switch (DialogBox.Result) {
                case DialogBox.ResultEnum.LeftButtonClicked:
                    MessageBox.Show("You clicked left button");
                    break;
                case DialogBox.ResultEnum.RightButtonClicked:
                    MessageBox.Show("you clicked right button");
                    break;

            }
        }
    }
}

