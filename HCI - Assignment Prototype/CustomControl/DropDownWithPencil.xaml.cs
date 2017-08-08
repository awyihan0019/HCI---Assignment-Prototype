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
using HCI___Assignment_Prototype.Class;
using static System.Windows.Visibility;


namespace HCI___Assignment_Prototype.CustomControl {
    /// <summary>
    /// Interaction logic for DropDownWithPencil.xaml
    /// </summary>
    public partial class DropDownWithPencil : UserControl {
        public DropDownWithPencil() {
            InitializeComponent();
            ComboBox.ItemsSource = new List<string>(){"qwe","wer","asd"};
        }

        public void SetItems(string items) {
            ComboBox.ItemsSource = items.Split(',');
        }

        private void Button_Pencil_OnClick(object sender, RoutedEventArgs e) {
            GoToEditableMode();
            ComboBox.IsDropDownOpen = true;
        }

        private void Button_Cancel_OnClick(object sender, RoutedEventArgs e) {
            ComboBox.Text = TextBlock.Text;
            GoToUneditableMode();
        }

        private void Button_Save_OnClick(object sender, RoutedEventArgs e) {
            TextBlock.Text = ComboBox.Text;
            GoToUneditableMode();
        }


        private void GoToEditableMode() {
            var da = CustomAnimation.GetEnteringScreenAnimation(0 , 45 , false);
            StackPanel_Bottom.BeginAnimation(HeightProperty , da);
            ComboBox.Visibility = Visible;
            TextBlock.Visibility = Hidden;
            Button_Pencil.Visibility = Hidden;
            
        }

        private void GoToUneditableMode() {
            var da = CustomAnimation.GetLeavingScreenAnimation(45 , 0 , false);
            StackPanel_Bottom.BeginAnimation(HeightProperty , da);
            ComboBox.Visibility = Collapsed;
            TextBlock.Visibility = Visible;
            Button_Pencil.Visibility = Visible;
        }

    }
}
