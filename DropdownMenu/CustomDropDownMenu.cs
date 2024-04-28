using System.Windows;
using System.Windows.Controls;

namespace DropdownMenu
{

    public class CustomDropDownMenu : ContentControl
    {
        public static readonly DependencyProperty IsOpenProperty = 
            DependencyProperty.Register(nameof(IsOpen), typeof(bool), typeof(CustomDropDownMenu), new PropertyMetadata(false));

        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        static CustomDropDownMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomDropDownMenu), new FrameworkPropertyMetadata(typeof(CustomDropDownMenu)));
        }
    }
}