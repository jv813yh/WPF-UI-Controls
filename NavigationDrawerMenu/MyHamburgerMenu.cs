using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace NavigationDrawerMenu
{

    public class MyHamburgerMenu : Control
    {
        public static readonly DependencyProperty IsOpenProperty = 
            DependencyProperty.Register(nameof(IsOpen), typeof(bool), typeof(MyHamburgerMenu), new PropertyMetadata(false, OnIsOpenPropertyChanged));

        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        public static readonly DependencyProperty OpenCloseDurationProperty =
            DependencyProperty.Register(nameof(OpenCloseDuration), typeof(Duration), typeof(MyHamburgerMenu), new PropertyMetadata(Duration.Automatic));

        public Duration OpenCloseDuration
        {
            get { return (Duration)GetValue(OpenCloseDurationProperty); }
            set { SetValue(OpenCloseDurationProperty, value); }
        }

        public static readonly DependencyProperty MenuContentProperty =
            DependencyProperty.Register(nameof(MenuContent), typeof(FrameworkElement), typeof(MyHamburgerMenu), new PropertyMetadata(null));
        public FrameworkElement MenuContent
        {
            get { return (FrameworkElement)GetValue(MenuContentProperty); }
            set { SetValue(MenuContentProperty, value); }
        }
        static MyHamburgerMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyHamburgerMenu), new FrameworkPropertyMetadata(typeof(MyHamburgerMenu)));
        }

        private static void OnIsOpenPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MyHamburgerMenu hamburgerMenu)
            {
                hamburgerMenu.OnIsOpenPropertyChanged();
            }
        }

        private void OnIsOpenPropertyChanged()
        {
            if(IsOpen)
            {
                OpenMenuAnimation();
            }
            else
            {
                CloseMenuAnimnation();
            }
        }

        private void CloseMenuAnimnation()
        {
            DoubleAnimation closeAnimation = new DoubleAnimation(0, OpenCloseDuration);
            BeginAnimation(WidthProperty, closeAnimation);
        }

        private void OpenMenuAnimation()
        {
            double contentWidth = MeasureContentWidth();

            DoubleAnimation openAnimation = new DoubleAnimation(contentWidth, OpenCloseDuration);
            BeginAnimation(WidthProperty, openAnimation);
        }

        private double MeasureContentWidth()
        {
            MenuContent.Measure(new Size(MaxWidth, MaxHeight));
            return MenuContent.DesiredSize.Width;
        }
    }
}