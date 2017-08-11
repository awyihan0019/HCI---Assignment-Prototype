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
using MaterialDesignThemes.Wpf;

namespace HCI___Assignment_Prototype.CustomControl {
    /// <summary>
    /// Interaction logic for DropDownSelectionList.xaml
    /// </summary>
    public partial class DropDownSelectionList : UserControl {
        public DropDownSelectionList() {
            InitializeComponent();
        }

        private void ComboBox_OnDropDownClosed(object sender , EventArgs e) {
            UpdateDisplayingResult();
        }

        private void ButtonBase_OnClick(object sender , RoutedEventArgs e) {
            ComboBox.IsDropDownOpen = false;
        }

        private void ComboBox_OnDropDownOpened(object sender , EventArgs e) {
            UpdateDisplayingResult();
        }

        private void Checkbox_OnClicked(object sender , RoutedEventArgs e) {
            UpdateDisplayingResult();
        }

        private void UpdateDisplayingResult() {
            string result = "";
            foreach (Item item in ComboBox.Items) {
                if (item.IsSelected) result += item.Content + ", ";
            }
            result = result.TrimEnd(' ');
            result = result.TrimEnd(',');
            Text = result;
        }

        #region ItemsProperty


        public string Items {
            get { return (string)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty , value); }
        }

        // Using a DependencyProperty as the backing store for Items.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items" , typeof(string) , typeof(DropDownSelectionList) , new PropertyMetadata("apple,banana,cacing" , OnItemsPropertyChanged));

        private static void OnItemsPropertyChanged(DependencyObject d , DependencyPropertyChangedEventArgs e) {
            var dropDownWithSelectionList = d as DropDownSelectionList;
            string newValue = (string)e.NewValue;
            var tokens = newValue.Split(',');
            var list = new List<Item>();
            for (int i = 0 ; i < tokens.Length ; i++) {
                list.Add(new Item(tokens[i]));
            }
            dropDownWithSelectionList.DataContext = list;
        }
        #endregion


        #region TextProperty



        public string Text {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty , value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text" , typeof(string) , typeof(DropDownSelectionList) , new PropertyMetadata("(No items selected)" , OnTextPropertyChanged));

        private static void OnTextPropertyChanged(DependencyObject d , DependencyPropertyChangedEventArgs e) {
            var dropDownSelectionList = d as DropDownSelectionList;
            var newValue = ((string)e.NewValue).Trim();
            if (newValue != "") {
                dropDownSelectionList.ComboBox.Text = " ";
            }
            else {
                dropDownSelectionList.ComboBox.Text = "";
            }
            dropDownSelectionList.TextBlock.Text = newValue;
        }

        #endregion

        #region LabelProperty


        public string Label {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty , value); }
        }

        // Using a DependencyProperty as the backing store for Label.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label" , typeof(string) , typeof(DropDownSelectionList) , new PropertyMetadata("", OnLabelPropertyChanged));

        private static void OnLabelPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e) {
            var d = dependencyObject as DropDownSelectionList;
            var newValue = (string) e.NewValue;
            HintAssist.SetHint(d, newValue);
        }

        #endregion

    }
}
