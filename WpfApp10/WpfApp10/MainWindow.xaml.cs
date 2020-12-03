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

namespace WpfApp10
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            list1.Items.Clear();
            list2.Items.Clear();
            list3.Items.Clear();
            list4.Items.Clear();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            string text_content;
            text_content = text_input.Text;
            list1.Items.Add(text_content);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            string text_content;
            text_content = text_input.Text;
            list2.Items.Add(text_content);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            string text_content;
            text_content = text_input.Text;
            list3.Items.Add(text_content);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            string text_content;
            text_content = text_input.Text;
            list4.Items.Add(text_content);
        }

        private void but_gen_Click(object sender, RoutedEventArgs e)
        {
            Random rnd1 = new Random();
            int value1 = rnd1.Next(0, list1.Items.Count);
            text1.Text = list1.Items[value1].ToString().Split().Last();
            Random rnd2 = new Random();
            int value2 = rnd2.Next(0, list2.Items.Count);
            text2.Text = list2.Items[value2].ToString().Split().Last();
            Random rnd3 = new Random();
            int value3 = rnd3.Next(0, list3.Items.Count);
            text3.Text = list3.Items[value3].ToString().Split().Last();
            Random rnd4 = new Random();
            int value4 = rnd4.Next(0, list4.Items.Count);
            text4.Text = list4.Items[value4].ToString().Split().Last();
        }
    }
}
