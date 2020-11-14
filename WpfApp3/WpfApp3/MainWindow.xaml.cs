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

namespace WpfApp3
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

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            but1.Content = "123";
        }

        private void text_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text_out = "";
            String[] text_i = text.Text.ToString().Split();
            for(int i = 0; i < text_i.Length; i++)
            {
                if (text_i[i] == "красный") but1.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                else if (text_i[i] == "зеленый") but1.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                else if (text_i[i] == "белый") but1.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                else if (text_i[i] == "желтый") but1.Background = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                else if (text_i[i] == "голубой") but1.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                else if (text_i[i] == "фиолетовый") but1.Background = new SolidColorBrush(Color.FromRgb(162, 5, 248));
                else if (text_i[i] == "оранжевый") but1.Background = new SolidColorBrush(Color.FromRgb(255, 150, 0));
                else if (text_i[i] == "синий") but1.Background = new SolidColorBrush(Color.FromRgb(16, 52, 166));
                else text_out += text_i[i] + " ";
            }
            but1.Content = text_out;
        }
    }
}
