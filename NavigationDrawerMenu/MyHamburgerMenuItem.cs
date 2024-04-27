using System.Windows;
using System.Windows.Controls;

namespace NavigationDrawerMenu
{
    public class MyHamburgerMenuItem : RadioButton
    {
        static MyHamburgerMenuItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyHamburgerMenuItem), new FrameworkPropertyMetadata(typeof(MyHamburgerMenuItem)));
        }
    }
}
