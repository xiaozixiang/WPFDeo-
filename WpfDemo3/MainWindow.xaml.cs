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

namespace WpfDemo3
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

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(lbl1, lbl1.Content, DragDropEffects.Copy);
        }

        private void lbl2_Drop(object sender, DragEventArgs e)
        {
            lbl2.Content = e.Data.GetData(DataFormats.Text);
        }
    }
}
