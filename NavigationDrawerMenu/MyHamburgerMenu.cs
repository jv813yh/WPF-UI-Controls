using System.Windows;
using System.Windows.Controls;

namespace NavigationDrawerMenu
{

    public class MyHamburgerMenu : Control
    {
        public static readonly DependencyProperty IsOpenProperty = 
            DependencyProperty.Register(nameof(IsOpen), typeof(bool), typeof(MyHamburgerMenu), new PropertyMetadata(false));

        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        public static readonly DependencyProperty IsClosedProperty =
            DependencyProperty.Register(nameof(IsClosed), typeof(bool), typeof(MyHamburgerMenu), new PropertyMetadata(false));

        public bool IsClosed
        {
            get { return (bool)GetValue(IsClosedProperty); }
            set { SetValue(IsClosedProperty, value); }
        }

        public static readonly DependencyProperty MenuContentProperty =
            DependencyProperty.Register(nameof(MenuContent), typeof(object), typeof(MyHamburgerMenu), new PropertyMetadata(null));
        public object MenuContent
        {
            get { return (object)GetValue(MenuContentProperty); }
            set { SetValue(MenuContentProperty, value); }
        }
        static MyHamburgerMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyHamburgerMenu), new FrameworkPropertyMetadata(typeof(MyHamburgerMenu)));
        }
    }
}