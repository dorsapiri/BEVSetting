using BEVSetting.View;
using BEVSetting.ViewModel;
using System.Configuration;
using System.Data;
using System.Windows;

namespace BEVSetting
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindowV mainWindowV = new MainWindowV();
            MainWindowVM mainWindowVM = new MainWindowVM();
            mainWindowV.DataContext = mainWindowVM;
            mainWindowV.Show();
        }
    }

}
