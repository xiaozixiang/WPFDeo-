using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemo4单例
{
    class SingelWraper:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
    {
        public SingelWraper()
        {
            this.IsSingleInstance = true;
        }
       private  Wpfapp app;
        protected override bool OnStartup(Microsoft.VisualBasic.ApplicationServices.StartupEventArgs eventArgs)
        {
            app = new Wpfapp();
            app.Run();
            return false;
        }
        protected override void OnStartupNextInstance(Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs eventArgs)
        {
            base.OnStartupNextInstance(eventArgs);
            app.showDailog();
        }

        
    }
}
