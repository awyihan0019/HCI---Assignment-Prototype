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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace HCI___Assignment_Prototype.Page.Homepage {
    /// <summary>
    /// Interaction logic for Homepage_BottomPart.xaml
    /// </summary>
    public partial class Homepage_BottomPart : UserControl {
        public Homepage_BottomPart() {
            InitializeComponent();
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(2) };
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private readonly List<string> posterListSource = new List<string>
        {
            @"MoviePoster\815673_Wallpaper2.jpg",
            @"MoviePoster\LawlessUKquadPPP.jpg",
            @"MoviePoster\looper-movie-poster-large.jpg",
            @"MoviePoster\Shelter_Movie_poster.jpg",
            @"MoviePoster\the-chamber-2017-movie-poster.jpg"
        };
   
        private void Timer_Tick(object sender , EventArgs e) {
            var rand = new Random();
            var nextNumber = rand.Next(posterListSource.Count - 1);
            Poster.Source = new BitmapImage(new Uri(posterListSource[nextNumber] , UriKind.Relative));
        }
    }
}