using HCI___Assignment_Prototype.CustomControl;
using HCI___Assignment_Prototype.Page.Homepage_Admin;
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
            if (Textbox_MovieName.Text != "" && ComboBox_Rating.Text != "" && Textbox_TrailerURL.Text != "" && DatePicker_ReleaseDate.Text != "" && Cinemas.Text != "" && Textbox_Summary.Text != "" && RunningTime.Text != "" && Director.Text != "" && Cast.Text != "" && PosterImage.Source.ToString() != "pack://application:,,,/HCI - Assignment Prototype;component/page/createreservation_admin/insertimage.jpg") {
                DialogBox.Show("Do you really want to create this reservation", "", "CANCEL", "SAVE");
                switch (DialogBox.Result)
                {
                    case DialogBox.ResultEnum.LeftButtonClicked: return;
                    case DialogBox.ResultEnum.RightButtonClicked:
                        {
                            ProgressDialog.Show("Creating Reservation......", "", () => {
                                DialogBox.Show("", "Reservation successfully created!", "OK");

                                Global.SampleData.SampleReservationDetails_Admin.Add(
                                    new Class.MovieReservation_Admin(
                                        Textbox_MovieName.Text,
                                        ComboBox_Rating.Text,
                                        Textbox_TrailerURL.Text,
                                        DatePicker_ReleaseDate.Text, Cinemas.Text,
                                        Textbox_Summary.Text,
                                        RunningTime.Text,
                                        Director.Text,
                                        Cast.Text,
                                        (BitmapImage)PosterImage.Source));
                                MainWindow.MainFrame.Navigate(new UserControl_HomePage_Admin());
                            });
                            return;
                        }
                }
            }
            else
            {
                DialogBox.Show("You must complete your reservation detail before you create", "", "OK");
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
                UploadPosterButton.Content = "CHANGE IMAGE";
            }
        }
    }
}
