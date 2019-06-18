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

namespace WpfDemo5
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mouserEnter(object sender, MouseEventArgs e)
        {
            ((TextBlock)sender).Background = new SolidColorBrush(Colors.DarkGoldenrod);
            (sender as TextBlock).Foreground = new SolidColorBrush(Colors.LightCyan);
        }
        private void mouserleave(object sender, MouseEventArgs e)
        {
            (sender as TextBlock).Background = new SolidColorBrush(Colors.Honeydew);
            (sender as TextBlock).Foreground = new SolidColorBrush(Colors.IndianRed);
        }
    }
}
