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
            ComboBox.ItemsSource = new List<string>() { "qwe" , "wer" , "asd" };

        }

        public void SetItems(string items) {
            ComboBox.ItemsSource = items.Split(',');
        }

        private void Button_Pencil_OnClick(object sender , RoutedEventArgs e) {
            GoToEditableMode();
            ComboBox.IsDropDownOpen = true;
        }

        private void Button_Cancel_OnClick(object sender , RoutedEventArgs e) {
            ComboBox.Text = TextBlock.Text;
            GoToUneditableMode();
        }

        private void Button_Save_OnClick(object sender , RoutedEventArgs e) {
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


        #region ItemsProperty
        public string Items {
            get { return (string)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty , value); }
        }

        // Using a DependencyProperty as the backing store for Items.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items" , typeof(string) , typeof(DropDownWithPencil) , new PropertyMetadata("" , OnItemsPropertyChanged));

        private static void OnItemsPropertyChanged
            (DependencyObject d , DependencyPropertyChangedEventArgs e) {
            var dropDownWithPencil = d as DropDownWithPencil;
            if (dropDownWithPencil == null) return;
            var newValue = (string)e.NewValue;
            dropDownWithPencil.SetItems(newValue);
        }
        #endregion

        #region LabelProperty

        public string Label {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty , value);
        }

        // Using a DependencyProperty as the backing store for LabelProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label" , typeof(string) , typeof(TextboxWithPencil) ,
                new PropertyMetadata("Label" , LabelPropertyChangedCallback));

        private static void LabelPropertyChangedCallback(DependencyObject dependencyObject ,
                                                         DependencyPropertyChangedEventArgs e) {
            var d = dependencyObject as DropDownWithPencil;
            d.TextBlock_Label.Text = (string)e.NewValue;
        }

        #endregion

        #region TextProperty

        public string Text {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty , value);
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text" , typeof(string) , typeof(TextboxWithPencil) ,
                new PropertyMetadata("sample text . . . " , TextPropertyChangedCallback));

        private static void TextPropertyChangedCallback(DependencyObject dependencyObject ,
                                                        DependencyPropertyChangedEventArgs
                                                            dependencyPropertyChangedEventArgs) {
            var d = dependencyObject as DropDownWithPencil;
            var newValue = (string)dependencyPropertyChangedEventArgs.NewValue;
            d.ComboBox.Text = newValue;
            d.TextBlock.Text = newValue;
        }

        #endregion

        private void DropDownWithPencil_OnLoaded(object sender, RoutedEventArgs e) {
            OnItemsPropertyChanged(this , new DependencyPropertyChangedEventArgs(ItemsProperty , "" , Items));
            LabelPropertyChangedCallback(this , new DependencyPropertyChangedEventArgs(LabelProperty , "" , Label));
            TextPropertyChangedCallback(this , new DependencyPropertyChangedEventArgs(TextProperty , "" , Text));
        }
    }
}
