using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfDemo5
{
     public  class Mypanel:Panel
    {
         List<Visual> Visuals = new List<Visual>();
         protected override Visual GetVisualChild(int index)
         {
             return Visuals[index];
         }
         protected override int VisualChildrenCount
         {
             get
             {
                 return Visuals.Count;
             }
         }
         public void addVisual(Visual visual)
         {
             Visuals.Add(visual);
             base.AddLogicalChild(visual);
             base.AddVisualChild(visual);
         }
         public DrawingVisual getVisual(Point point)
         {
             HitTestResult hittestResult = VisualTreeHelper.HitTest(this, point);
             return hittestResult.VisualHit as DrawingVisual;
         }
    }
}
