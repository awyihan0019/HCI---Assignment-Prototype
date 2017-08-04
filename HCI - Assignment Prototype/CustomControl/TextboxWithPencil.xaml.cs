using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using HCI___Assignment_Prototype.Class;
using static System.Windows.Visibility;

namespace HCI___Assignment_Prototype.CustomControl {
    /// <summary>
    ///     Interaction logic for TextboxWithPencil.xaml
    /// </summary>
    public partial class TextboxWithPencil : UserControl {
        public TextboxWithPencil() {
            InitializeComponent();
        }

        private void Button_Pencil_OnClick(object sender, RoutedEventArgs e) {
            GoToEditableMode();
            Keyboard.Focus(TextBox);
        }

        private void Button_Cancel_OnClick(object sender, RoutedEventArgs e) {
            TextBox.Text = TextBlock.Text;
            GoToUneditableMode();
        }

        private void Button_Save_OnClick(object sender, RoutedEventArgs e) {
            TextBlock.Text = TextBox.Text;
            GoToUneditableMode();
        }

        private void GoToEditableMode() {
            var da = CustomAnimation.GetEnteringScreenAnimation(0, 45, false);
            StackPanel_Bottom.BeginAnimation(HeightProperty, da);
            TextBox.Visibility = Visible;
            TextBlock.Visibility = Hidden;
            Button_Pencil.Visibility = Hidden;
        }

        private void GoToUneditableMode() {
            var da = CustomAnimation.GetLeavingScreenAnimation(45, 0, false);
            StackPanel_Bottom.BeginAnimation(HeightProperty, da);
            TextBox.Visibility = Collapsed;
            TextBlock.Visibility = Visible;
            Button_Pencil.Visibility = Visible;
        }


        #region LabelProperty

        public string Label {
            get => (string) GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        // Using a DependencyProperty as the backing store for LabelProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(TextboxWithPencil),
                new PropertyMetadata("Label", LabelPropertyChangedCallback));

        private static void LabelPropertyChangedCallback(DependencyObject dependencyObject,
                                                         DependencyPropertyChangedEventArgs e) {
            var d = dependencyObject as TextboxWithPencil;
            d.TextBlock_Label.Text = (string) e.NewValue;
        }

        #endregion

        #region TextProperty

        public string Text {
            get => (string) GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(TextboxWithPencil),
                new PropertyMetadata("sample text . . . ", TextPropertyChangedCallback));

        private static void TextPropertyChangedCallback(DependencyObject dependencyObject,
                                                        DependencyPropertyChangedEventArgs
                                                            dependencyPropertyChangedEventArgs) {
            var d = dependencyObject as TextboxWithPencil;
            var newValue = (string) dependencyPropertyChangedEventArgs.NewValue;
            d.TextBox.Text = newValue;
            d.TextBlock.Text = newValue;
        }

        #endregion
    }
}