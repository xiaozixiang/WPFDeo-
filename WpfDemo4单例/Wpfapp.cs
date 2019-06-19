using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfDemo4单例
{
    class Wpfapp:Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            showDailog();
        }

        public void showDailog()
        {
            MainWindow app = new MainWindow();
            app.Show();
        }
    }
}
