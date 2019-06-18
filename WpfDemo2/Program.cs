using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfDemo2;

namespace WpfDemo1
{
    class Program:Application
    {
        [STAThread]
        public static void Main()
        {
            Program app = new Program();
            app.MainWindow = new Window1("Window1.xaml");  //new Window1();
            app.MainWindow.ShowDialog();  
        }
    }
}
