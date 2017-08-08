using System;
using System.Windows;
using System.Windows.Threading;

namespace HCI___Assignment_Prototype.CustomControl {
    /// <summary>
    ///     Interaction logic for DialogBox.xaml
    /// </summary>
    public partial class ProgressDialog : Window {
        public ProgressDialog() {
            InitializeComponent();
        }

        public static void Show(string title, string message, Action action) {
            var p = new ProgressDialog();
            p.SetContent(title, message);
            p.DialogHost.IsOpen = true;
            var timer = new DispatcherTimer {Interval = TimeSpan.FromSeconds(3)};
            timer.Tick += (sender, args) => {
                p.Close();
                action();
                timer.Stop();
            };
            timer.Start();
            p.ShowDialog();
        }


        private void SetContent(string title, string message) {
            TextBlock_Title.Text = title;
            TextBlock_Message.Text = message;
        }
    }
}