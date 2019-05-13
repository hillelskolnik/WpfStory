using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfStory.Data.Shapse
{
    public class Square : ShapeBase
    {
        public Square()
        {
            Fill = new SolidColorBrush(Colors.Turquoise);
            Stroke = new SolidColorBrush(Colors.Black);
            StrokeThickness = 2;
        }
        public override double Area => HightWidth * HightWidth;
        private double hightWidth = 40;

        public double HightWidth
        {
            get { return hightWidth; }
            set
            {
                if (hightWidth == value)
                {
                    return;
                }
                hightWidth = value;
                Notify("HightWidth");
                Notify("Area");
            }
        }
    }
}
