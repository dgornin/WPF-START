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

namespace WpfApp8
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
            string text_content = "Пица: ";
            if (rad1.IsChecked == true)
            {
                text_content += rad1.Content + " \b";
            }
            if (rad2.IsChecked == true)
            {
                text_content += rad2.Content + " \b";
            }
            if (rad3.IsChecked == true)
            {
                text_content += rad3.Content + " \b";
            }
            if (rad4.IsChecked == true)
            {
                text_content += rad4.Content + " \b";
            }
            if (rad5.IsChecked == true)
            {
                text_content += rad5.Content + " \b";
            }
            text_content += "Компаненты: \b";
            if (check1.IsChecked == true)
            {
                text_content += check1.Content + " \b";
            }
            if (check2.IsChecked == true)
            {
                text_content += check2.Content + " \b";
            }
            if (check3.IsChecked == true)
            {
                text_content += check3.Content + " \b";
            }
            if (check4.IsChecked == true)
            {
                text_content += check4.Content + " \b";
            }
            if (check5.IsChecked == true)
            {
                text_content += check5.Content + " \b";
            }
            if (check6.IsChecked == true)
            {
                text_content += check6.Content + " \b";
            }
            text1.Text = text_content;
        }
    }
}
