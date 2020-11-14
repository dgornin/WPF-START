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

namespace WpfApp2
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

        private void but_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            but.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            var rotateTransform = but.RenderTransform as RotateTransform;
            var transform = new RotateTransform(25 + (rotateTransform?.Angle ?? 0));
            but.RenderTransform = transform;
            but_Copy.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy.RenderTransform = transform;
            but_Copy1.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy1.RenderTransform = transform;
            but_Copy2.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy2.RenderTransform = transform;
            but_Copy3.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy3.RenderTransform = transform;
            but_Copy4.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy4.RenderTransform = transform;
        }

        private void but_Click2(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            but_Copy5.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            var rotateTransform = but_Copy5.RenderTransform as RotateTransform;
            var transform = new RotateTransform(30 + (rotateTransform?.Angle ?? 0));
            but_Copy5.RenderTransform = transform;
            but_Copy6.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy6.RenderTransform = transform;
            but_Copy7.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy7.RenderTransform = transform;
            but_Copy8.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy8.RenderTransform = transform;
            but_Copy9.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy9.RenderTransform = transform;
            but_Copy10.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy10.RenderTransform = transform;
            but_Copy11.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy11.RenderTransform = transform;
        }

        private void but_Click3(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            but_Copy12.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            var rotateTransform = but_Copy12.RenderTransform as RotateTransform;
            var transform = new RotateTransform(35 + (rotateTransform?.Angle ?? 0));
            but_Copy12.RenderTransform = transform;
            but_Copy13.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy13.RenderTransform = transform;
            but_Copy14.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy14.RenderTransform = transform;
            but_Copy15.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy15.RenderTransform = transform;
            but_Copy16.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy16.RenderTransform = transform;
            but_Copy17.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy17.RenderTransform = transform;
        }

        private void but_Click4(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            but_Copy18.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            var rotateTransform = but_Copy18.RenderTransform as RotateTransform;
            var transform = new RotateTransform(40 + (rotateTransform?.Angle ?? 0));
            but_Copy18.RenderTransform = transform;
            but_Copy19.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy19.RenderTransform = transform;
            but_Copy20.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy20.RenderTransform = transform;
            but_Copy21.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy21.RenderTransform = transform;
            but_Copy22.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy22.RenderTransform = transform;
        }

        private void but_Click5(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            but_Copy23.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            var rotateTransform = but_Copy23.RenderTransform as RotateTransform;
            var transform = new RotateTransform(45 + (rotateTransform?.Angle ?? 0));
            but_Copy23.RenderTransform = transform;
            but_Copy24.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy24.RenderTransform = transform;
            but_Copy25.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy25.RenderTransform = transform;
            but_Copy26.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy26.RenderTransform = transform;
            but_Copy27.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy27.RenderTransform = transform;
            but_Copy28.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
            but_Copy28.RenderTransform = transform;
        }
    }
}
