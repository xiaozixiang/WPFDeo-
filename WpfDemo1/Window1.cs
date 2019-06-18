using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace WpfDemo1
{
    class Window1:Window
    {
        private Button button1;
        public Window1()
        {
            InitializeComponet();
        }
        private void InitializeComponet()
        { 
            //配置窗体大小
            this.Width = 280;
            this.Height = 250;
            this.Left = this.Top = 100;
            this.Title = "CodeOnlyWindow";
            //创建面板对象
            DockPanel panel = new DockPanel();
            //创建按钮对象
            button1 = new Button();
            button1.Content = "点击我";
            button1.Margin = new Thickness(30);
            button1.Click += button1_click;
            IAddChild container = panel;
            container.AddChild(button1);
            container = this;
            container.AddChild(panel);
        }

        public void button1_click(object sender, RoutedEventArgs e)
        {
            button1.Content = "Thanks低价我a";
        }
    }
}
