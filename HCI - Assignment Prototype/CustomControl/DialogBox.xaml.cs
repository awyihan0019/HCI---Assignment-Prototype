using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using HCI___Assignment_Prototype.Class;

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
            this.AllowsTransparency = true;
        }

        public static ResultEnum Show(string title , string message , string leftButtonText = "Got it!" ,
                                      string rightButtonText = null) {
            if (_singleton == null) _singleton = new DialogBox();
            var p = _singleton;
            p.SetContent(title , message , leftButtonText , rightButtonText);
            p.DialogHost.IsOpen = true;
            p.ShowDialog();
            Result = p._result;
            return p._result;
        }

        private void SetContent(string title , string message , string leftButtonText , string rightButtonText) {
            Button_Right.Visibility = rightButtonText == null ? Visibility.Collapsed : Visibility.Visible;
            TextBlock_Title.Text = title;
            TextBlock_Message.Text = message;
            Button_Left.Content = leftButtonText;
            Button_Right.Content = rightButtonText;
            Custom.Visibility = Visibility.Collapsed;
            Default.Visibility = Visibility.Visible;
        }

        private static DialogBox _singleton;
        public static void Show(UserControl content) {
            if (_singleton == null) _singleton = new DialogBox();
            var p = _singleton;
            p.SetContent(content);
            p.DialogHost.IsOpen = true;
            if (p.Visibility == Visibility.Visible) return;
            p.ShowDialog();
        }

        public static void CloseDialog() {
            _singleton.Hide();
        }

        public static void GoBack() {
            if (_singleton == null) return;
            if (_singleton.Frame.CanGoBack == false) return;
            _singleton.Frame.GoBack();
        }

        private void SetContent(UserControl content) {
            Custom.Visibility = Visibility.Visible;
            Default.Visibility = Visibility.Collapsed;
            Frame.Navigate(content);
        }

        private void Button_Left_OnClick(object sender , RoutedEventArgs e) {
            _result = ResultEnum.LeftButtonClicked;
            Hide();
        }

        private void Button_Right_OnClick(object sender , RoutedEventArgs e) {
            _result = ResultEnum.RightButtonClicked;
            Hide();
        }

        private void SampleCode() {
            Show("Title" , "message" , "OK" , "Cancel");
            switch (Result) {
                case ResultEnum.LeftButtonClicked:
                    MessageBox.Show("You clicked left button");
                    break;
                case ResultEnum.RightButtonClicked:
                    MessageBox.Show("you clicked right button");
                    break;
            }
        }

        private void Frame_OnNavigating(object sender , NavigatingCancelEventArgs e) {
            return;
            var ta = new ThicknessAnimation {
                Duration = CustomAnimation.FullScreenAnimationDuration ,
                DecelerationRatio = CustomAnimation.DecelerationConstant ,
                To = new Thickness(0 , 0 , 0 , 0)
            };
            if (e.NavigationMode == NavigationMode.New || e.NavigationMode == NavigationMode.Forward) {
                ta.From = new Thickness(ActualWidth / 3 , 0 , 0 , 0);
            }
            else if (e.NavigationMode == NavigationMode.Back) {
                ta.From = new Thickness(0 , 0 , ActualWidth / 3 , 0);
            }
                (e.Content as UIElement)?.BeginAnimation(MarginProperty , ta);
        }
    }
}