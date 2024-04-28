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

            // For HamburgerMenuDemoWindow to work, you need to use the following lines
            //HamburgerMenuDemoWindow hamWindow = new HamburgerMenuDemoWindow();
            //hamWindow.Show();

            // For CustomDropDownMenuDemoWindow to work, you need to use the following lines
            CustomDropDownMenuDemoWindow customDropDownMenuDemoWindow = new CustomDropDownMenuDemoWindow();
            customDropDownMenuDemoWindow.Show();
        }
    }
}
