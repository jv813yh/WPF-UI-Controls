using System.Configuration;
using System.Data;
using System.Windows;
using UIWPFDemo.Windows;

namespace UIWPFDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            
            HamburgerMenuDemoWindow hamWindow = new HamburgerMenuDemoWindow();

            hamWindow.Show();
        }
    }

}
