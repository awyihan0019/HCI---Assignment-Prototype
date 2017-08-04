using System.Windows;

namespace HCI___Assignment_Prototype.CustomControl {
    /// <summary>
    ///     Interaction logic for DialogBox.xaml
    /// </summary>
    public partial class DialogBox : Window {
        public enum ResultEnum {
            LeftButtonClicked,
            RightButtonClicked
        }


        public static ResultEnum Result;

        private ResultEnum _result;

        public DialogBox() {
            InitializeComponent();
        }

        public static ResultEnum Show(string title, string message, string leftButtonText = "Got it!",
                                      string rightButtonText = null) {
            var p = new DialogBox();
            p.SetContent(title, message, leftButtonText, rightButtonText);
            p.DialogHost.IsOpen = true;
            p.ShowDialog();
            Result = p._result;
            return p._result;
        }

        private void SetContent(string title, string message, string leftButtonText, string rightButtonText) {
            Button_Right.Visibility = rightButtonText == null ? Visibility.Collapsed : Visibility.Visible;
            TextBlock_Title.Text = title;
            TextBlock_Message.Text = message;
            Button_Left.Content = leftButtonText;
            Button_Right.Content = rightButtonText;
        }

        private void Button_Left_OnClick(object sender, RoutedEventArgs e) {
            _result = ResultEnum.LeftButtonClicked;
            Hide();
        }

        private void Button_Right_OnClick(object sender, RoutedEventArgs e) {
            _result = ResultEnum.RightButtonClicked;
            Hide();
        }

        private void SampleCode() {
            Show("Title", "message", "OK", "Cancel");
            switch (Result) {
                case ResultEnum.LeftButtonClicked:
                    MessageBox.Show("You clicked left button");
                    break;
                case ResultEnum.RightButtonClicked:
                    MessageBox.Show("you clicked right button");
                    break;
            }
        }
    }
}