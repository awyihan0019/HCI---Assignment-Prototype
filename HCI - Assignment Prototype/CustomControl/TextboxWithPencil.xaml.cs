using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using HCI___Assignment_Prototype.Class;
using static System.Windows.Visibility;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

namespace HCI___Assignment_Prototype.CustomControl
{
    /// <summary>
    ///     Interaction logic for TextboxWithPencil.xaml
    /// </summary>
    public partial class TextboxWithPencil : UserControl
    {
        public event EventHandler PencilButtonOnClick;

        public TextboxWithPencil() {
            InitializeComponent();
        }

        private void Button_Pencil_OnClick(object sender, RoutedEventArgs e)
        {
            GoToEditableMode();
            Keyboard.Focus(TextBox);
            PencilButtonOnClick?.Invoke(this , null);
        }

        private void Button_Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBlock.Text;
            GoToUneditableMode();
        }

        private void Button_Save_OnClick(object sender, RoutedEventArgs e)
        {
            if (PhoneNumberOnly)
            {
                if (!IsNumeric(TextBox.Text))
                {
                    DialogBox.Show("Please Enter A Valid Phone Number", "", "Continue");
                    TextBox.Text = "";
                    return;
                }
            }
            TextBlock.Text = TextBox.Text;
            Text = TextBlock.Text;
            GoToUneditableMode();
        }

        bool IsNumeric(string text)
        {

            //regex that matches disallowed text
            Regex regex = new Regex("[^0-9.-]+");
            return !regex.IsMatch(text);
        }


        private void GoToEditableMode()
        {
            var da = CustomAnimation.GetEnteringScreenAnimation(0, 45, false);
            StackPanel_Bottom.BeginAnimation(HeightProperty, da);
            TextBox.Visibility = Visible;
            TextBlock.Visibility = Hidden;
            if (IsEditableByTyping)
                Button_Pencil.Visibility = Hidden;
        }

        private void GoToUneditableMode()
        {
            var da = CustomAnimation.GetLeavingScreenAnimation(45, 0, false);
            StackPanel_Bottom.BeginAnimation(HeightProperty, da);
            TextBox.Visibility = Collapsed;
            TextBlock.Visibility = Visible;
            Button_Pencil.Visibility = Visible;
        }

        public string PendingText {
            get { return TextBox.Text; }
            set { TextBox.Text = value; }
        }

        public bool IsEditableByTyping {
            get { return !TextBox.IsReadOnly; }
            set { TextBox.IsReadOnly = !value; }
        }

        public object PencilToolTip {
            get { return Button_Pencil.ToolTip; }
            set { Button_Pencil.ToolTip = value; }
        }

        #region LabelProperty

        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        // Using a DependencyProperty as the backing store for LabelProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(TextboxWithPencil),
                new PropertyMetadata("Label", LabelPropertyChangedCallback));

        private static void LabelPropertyChangedCallback(DependencyObject dependencyObject,
                                                         DependencyPropertyChangedEventArgs e)
        {
            var d = dependencyObject as TextboxWithPencil;
            d.TextBlock_Label.Text = (string)e.NewValue;
        }

        #endregion

        #region TextProperty

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(TextboxWithPencil),
                new PropertyMetadata("sample text . . . ", TextPropertyChangedCallback));

        private static void TextPropertyChangedCallback(DependencyObject dependencyObject,
                                                        DependencyPropertyChangedEventArgs
                                                            dependencyPropertyChangedEventArgs)
        {
            var d = dependencyObject as TextboxWithPencil;
            var newValue = (string)dependencyPropertyChangedEventArgs.NewValue;
            if (d.IsPassword == true)
            {
                newValue = ToSecure(newValue);
            }
            d.TextBox.Text = newValue;
            d.TextBlock.Text = newValue;
        }

        #endregion

        #region NumericProperty



        public Boolean PhoneNumberOnly
        {
            get { return (Boolean)GetValue(NumericProperty); }
            set { SetValue(NumericProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Numeric.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NumericProperty =
            DependencyProperty.Register("Numeric", typeof(Boolean), typeof(TextboxWithPencil), new PropertyMetadata(false));




        #endregion

        #region IsPasswordProperty



        public Boolean IsPassword
        {
            get { return (Boolean)GetValue(IsPasswordProperty); }
            set { SetValue(IsPasswordProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsPassword.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsPasswordProperty =
            DependencyProperty.Register("IsPassword", typeof(Boolean), typeof(TextboxWithPencil), new PropertyMetadata(false));

        #endregion

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (IsPassword == false)
                return;
            TextBox.Text = ToSecure(TextBox.Text);
        }

        private static String ToSecure(String s)
        {
            var sb = new StringBuilder(s);
            for (int i = 0; i < s.Length; i++)
            {
                sb[i] = '*';
            }
            return sb.ToString();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            TextPropertyChangedCallback(this, new DependencyPropertyChangedEventArgs(TextProperty, null, Text));
        }
    }
}