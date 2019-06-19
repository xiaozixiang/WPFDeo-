using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfDemo1
{
    class Program:Application
    {
        [STAThread]
        public static void Main()
        {
            Program app = new Program();
            app.MainWindow = new UserControl1("UserControl1.xaml");  //new Window1();
            app.MainWindow.ShowDialog();  
        }
    }
}
