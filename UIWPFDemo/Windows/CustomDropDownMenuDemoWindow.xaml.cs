using System.Windows;

namespace UIWPFDemo.Windows
{
    /// <summary>
    /// Interaction logic for CustomDropDownMenuDemoWindow.xaml
    /// </summary>
    public partial class CustomDropDownMenuDemoWindow : Window
    {
        public CustomDropDownMenuDemoWindow()
        {
            InitializeComponent();

            lvNames.ItemsSource = new string[] { "John", "Jane", "Jack", "Jill" };
        }

        private void OnEditClick(object sender, RoutedEventArgs e)
        {

        }

        private void OnDeleteClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
