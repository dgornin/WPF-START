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

namespace WpfApp4
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
            but1.Visibility = Visibility.Hidden;
            but2.Visibility = Visibility.Visible;

        }

        private void but2_MouseEnter(object sender, MouseEventArgs e)
        {
            but2.Visibility = Visibility.Hidden;
            Random rnd = new Random();
            int value = rnd.Next(0, 2);
            if (value == 1) but1.Visibility = Visibility.Visible;
            else but3.Visibility = Visibility.Visible;
        }

        private void but3_MouseEnter(object sender, MouseEventArgs e)
        {
            but3.Visibility = Visibility.Hidden;
            but2.Visibility = Visibility.Visible;
        }
    }
}
