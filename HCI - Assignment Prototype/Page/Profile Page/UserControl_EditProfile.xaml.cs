using System.Windows;
using System.Windows.Controls;
using HCI___Assignment_Prototype.CustomControl;

namespace HCI___Assignment_Prototype.Page.Profile_Page {
    /// <summary>
    ///     Interaction logic for UserControl_EditProfile.xaml
    /// </summary>
    public partial class UserControl_EditProfile : UserControl {
        public UserControl_EditProfile() {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e) {
            ProgressDialog.Show("Updating profile......", "", () => {
                DialogBox.Show("", "Profile successfully updated!", "OK");
                MainWindow.MainFrame.GoBack();
            });
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e) {
            MainWindow.MainFrame.GoBack();
        }
    }
}