using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfDemo2
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        Button button2;
        public Window1()
        {
            InitializeComponent();
        }
        public Window1(string xaml)
        {
            this.Width = this.Height = 200;
            this.Left = this.Top = 100;
            this.Title = "开始";
            DependencyObject rootEmelment;
            using (FileStream fs = new FileStream(xaml,  FileMode.Open,FileAccess.Read))
            {
                rootEmelment = (DependencyObject)XamlReader.Load(fs);
            }
            this.Content = rootEmelment;
            button2 = (Button)LogicalTreeHelper.FindLogicalNode(rootEmelment,"button1");
            button2.Click+=button2_Click;
        }

        public void button2_Click(Object sender, RoutedEventArgs e)
        {
            this.Content = "abs";
        }
    }
}
