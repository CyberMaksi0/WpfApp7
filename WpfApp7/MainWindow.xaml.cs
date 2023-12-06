using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnLabelMouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void OnLabelMouseLeave(object sender, MouseEventArgs e)
        {

        }
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            label.Content = textBox.Text;
        }

        private void CMO_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CMO.SelectedItem != null)
            {
                label1.Content = ((ComboBoxItem)CMO.SelectedItem).Content.ToString();
            }
        }
        private void OnToggleButtonChecked(object sender, RoutedEventArgs e)
        {
            popup.IsOpen = true;
        }

        private void OnToggleButtonUnchecked(object sender, RoutedEventArgs e)
        {
            popup.IsOpen = false;
        }

        private void xD_Checked(object sender, RoutedEventArgs e)
        {
            if((bool)xD.IsChecked)
            {
                Dx.Visibility = Visibility.Visible;
            }
            else
            {
                Dx.Visibility = Visibility.Hidden;
            }
        }
    }
}
