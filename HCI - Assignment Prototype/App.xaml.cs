using System.Windows;

namespace HCI___Assignment_Prototype {
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        private void App_OnExit(object sender, ExitEventArgs e) {
            Application.Current.Shutdown();
        }
    }
}