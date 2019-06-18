using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemo4单例
{
    class StartUp
    {
        [STAThread]
        public static void Main(string[] args)
        {
            //Wpfapp app = new Wpfapp();
            //app.Run();
            SingelWraper wrapp = new SingelWraper();
            wrapp.Run(args);
        
        }
    }
}
