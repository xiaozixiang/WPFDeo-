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
using System.Windows.Shapes;

namespace WpfDemo5
{
    /// <summary>
    /// VisualDemo.xaml 的交互逻辑
    /// </summary>
    public partial class VisualDemo : Window
    {
        public VisualDemo()
        {
            InitializeComponent();
        }

        //画一个正方形
        public void DrawSquare(DrawingVisual visual ,Point leftpoint)
        {
            DrawingContext dc = visual.RenderOpen();
            Brush brush = Brushes.CadetBlue;
            Pen Drawpen = new Pen(brush, 30);
            dc.DrawRectangle(brush, Drawpen, new Rect(leftpoint, new Size(40, 40)));
            dc.Close();
        }
    }
}
