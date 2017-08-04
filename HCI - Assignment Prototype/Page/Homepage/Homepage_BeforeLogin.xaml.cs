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
using System.Windows.Threading;

namespace HCI___Assignment_Prototype.Page.Homepage
{
    /// <summary>
    /// Interaction logic for Homepage_BeforeLogin.xaml
    /// </summary>
    public partial class Homepage_BeforeLogin : UserControl
    {
        private List<string> posterListSource = new List<string>()
        {
            @"MoviePoster\815673_Wallpaper2.jpg",
            @"MoviePoster\LawlessUKquadPPP.jpg",
            @"MoviePoster\looper-movie-poster-large.jpg",
            @"MoviePoster\Shelter_Movie_poster.jpg",
            @"MoviePoster\the-chamber-2017-movie-poster.jpg",
        };
        public Homepage_BeforeLogin()
        {
            InitializeComponent();           
            var timer = new DispatcherTimer(){Interval = TimeSpan.FromSeconds(2)};
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender , EventArgs e) {
            var rand = new Random();
            int nextNumber = rand.Next(posterListSource.Count - 1);
            Poster.Source = new BitmapImage(new Uri(posterListSource[nextNumber], UriKind.Relative)); 
        }

        private void LogInButton_OnClick(object sender, RoutedEventArgs e) {
            MainWindow.MainFrame.Navigate(new UserControl_Login());
        }

        private void SignUpButto_OnClick(object sender, RoutedEventArgs e) {
            MainWindow.MainFrame.Navigate(new UserControl_SignUp());
        }
    }
}
