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

namespace WpfApp9
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

        private void box1_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void img_box_Click(object sender, RoutedEventArgs e)
        {
            if (img1.Visibility == Visibility.Visible)
            {
                img1.Visibility = Visibility.Hidden;
            }
            else
            {
                img1.Visibility = Visibility.Visible;
            }
        }

        private void rad1_Checked(object sender, RoutedEventArgs e)
        {
            text4.Text = "Пол: " + rad1.Content;
        }
        private void rad2_Checked(object sender, RoutedEventArgs e)
        {
            text4.Text = "Пол: " + rad2.Content;
        }

        private void rad3_Checked(object sender, RoutedEventArgs e)
        {
            text3.Text = "Возраст: " + rad3.Content;
        }

        private void rad4_Checked(object sender, RoutedEventArgs e)
        {
            text3.Text = "Возраст: " + rad4.Content;
        }

        private void rad5_Checked(object sender, RoutedEventArgs e)
        {
            text3.Text = "Возраст: " + rad5.Content;
        }

        private void rad6_Checked(object sender, RoutedEventArgs e)
        {
            text3.Text = "Возраст: " + rad6.Content;
        }

        private void rad7_Checked(object sender, RoutedEventArgs e)
        {
            text3.Text = "Возраст: " + rad7.Content;
        }

        private void rad8_Checked(object sender, RoutedEventArgs e)
        {
            text3.Text = "Возраст: " + rad8.Content;
        }

        private void rad9_Checked(object sender, RoutedEventArgs e)
        {
            text3.Text = "Возраст: " + rad9.Content;
        }

        private void rad10_Checked(object sender, RoutedEventArgs e)
        {
            text3.Text = "Возраст: " + rad10.Content;
        }

        private void tex1_TextChanged(object sender, TextChangedEventArgs e)
        {
            text2.Text = "Имя: " + tex1.Text;
        }

        private void box1_Click(object sender, RoutedEventArgs e)
        {
            string text_content = "Иннтересы: ";
            if (box1.IsChecked == true) text_content += box1.Content + " ";
            if (box2.IsChecked == true) text_content += box2.Content + " ";
            if (box3.IsChecked == true) text_content += box3.Content + " ";
            if (box4.IsChecked == true) text_content += box4.Content + " ";
            if (box5.IsChecked == true) text_content += box5.Content + " ";
            if (box6.IsChecked == true) text_content += box6.Content + " ";
            text5.Text = text_content;
        }
    }
}
