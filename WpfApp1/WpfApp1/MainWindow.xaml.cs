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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool i = false;
        public bool f = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            but1.Visibility = Visibility.Hidden;

        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            but1.Visibility = Visibility.Visible;
        }

        private void but3_Click(object sender, RoutedEventArgs e)
        {
            if (i)
            {
                but3.Content = but3.Content.ToString().ToLower();
                i = false;
            } else
            {
                but3.Content = but3.Content.ToString().ToUpper();
                i = true;
            }
           
        }

        private void but4_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            but4.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
        }

        private void but5_Click(object sender, RoutedEventArgs e)
        {
            if (f)
            {
                but5.Width = 623;
                f = false;
                but5.Content = "Full size 623px)";
            }
            else
            {
                but5.Width = 300;
                but5.Content = "Short size 300px(";
                f = true;
            }
        }
    }
}
