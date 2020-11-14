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
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void but1_MouseEnter(object sender, MouseEventArgs e)
        {
            but1.Content = "Нажми на меня";
        }

        private void but1_MouseLeave(object sender, MouseEventArgs e)
        {
            but1.Content = "";
        }

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            b1.Visibility = Visibility.Hidden;
            b2.Visibility = Visibility.Hidden;
            b3.Visibility = Visibility.Hidden;
            b4.Visibility = Visibility.Hidden;
            b5.Visibility = Visibility.Hidden;
            b6.Visibility = Visibility.Hidden;
            b7.Visibility = Visibility.Hidden;
            b8.Visibility = Visibility.Hidden;
            b9.Visibility = Visibility.Hidden;
            b10.Visibility = Visibility.Hidden;
            b11.Visibility = Visibility.Hidden;
            but1.Visibility = Visibility.Hidden;
            Background = Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }
    }
}
