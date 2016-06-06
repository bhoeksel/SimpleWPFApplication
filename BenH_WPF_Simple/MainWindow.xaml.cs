using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
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

namespace BenH_WPF_Simple
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush selectedColor;

        public MainWindow()
        {
            InitializeComponent();
            colors.ItemsSource = typeof(Brushes).GetProperties();
        }

        private void colors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedColor = (Brush)(e.AddedItems[0] as PropertyInfo).GetValue(null, null);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != "")
            {
                yourName.FontSize = Convert.ToDouble(fontCombo.Text);
                yourName.Foreground = selectedColor;
                yourName.Content = textBox1.Text;
                yourName.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Please Enter Your Name", "Empty Name", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
