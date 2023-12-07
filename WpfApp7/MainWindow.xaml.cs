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
            DataContext = this;
        }

        public static readonly DependencyProperty TextBoxTextProperty =
            DependencyProperty.Register("TextBoxText", typeof(string), typeof(MainWindow));

        public string TextBoxText
        {
            get { return (string)GetValue(TextBoxTextProperty); }
            set { SetValue(TextBoxTextProperty, value); }
        }
        private void OnLabelMouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void OnLabelMouseLeave(object sender, MouseEventArgs e)
        {

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
            toggleButton.Content = "Ukryj Popup";
        }

        private void OnToggleButtonUnchecked(object sender, RoutedEventArgs e)
        {
            popup.IsOpen = false;
            toggleButton.Content = "Pokaż Popup";
        }
        private void RadioButtonOther_Checked(object sender, RoutedEventArgs e)
        {
            otherTextBox.Visibility = Visibility.Visible;
        }
        private void RadioButtonOther_Unchecked(object sender, RoutedEventArgs e)
        {
            otherTextBox.Visibility = Visibility.Collapsed;
        }
        private void TextBox_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.Foreground = Brushes.Red;
                textBox.FontSize = FontSize + 3;
            }
        }
        private void TextBox_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.Foreground = Brushes.Black;
                textBox.FontSize = FontSize - 3;
            }
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ListBox listBox && listBox.SelectedItem is ListBoxItem selectedItem)
            {
                foreach (var item in listBox.Items)
                {
                    if (item is ListBoxItem listBoxItem)
                    {
                        listBoxItem.Foreground = Brushes.Black;
                    }
                }
                selectedItem.Foreground = Brushes.Cyan;
            }
        }
    }
}
