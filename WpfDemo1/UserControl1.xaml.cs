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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfDemo1
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public  class UserControl1 : Window
    {
        public UserControl1()
        {
            //InitializeComponent();
        }
        public UserControl1(String xaml)
        {
            initial(xaml);
        }
        public void initial(string xaml)
        {
            // DependencyObject RootElement;
            using (FileStream fs = new FileStream(xaml, FileMode.Open,FileAccess.Read))
            {
               
                this.Content = (DependencyObject)XamlReader.Load(fs);
            
            }

        }
    }

 
}
