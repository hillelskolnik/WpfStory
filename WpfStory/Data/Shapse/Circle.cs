using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfStory.Data.Shapse
{
    public class Circle : ShapeBase
    {
        public Circle()
        {
            Fill = new SolidColorBrush(Colors.Crimson);
            Stroke = new SolidColorBrush(Colors.Black);
            StrokeThickness = 2;
        }
        public override double Area => Math.PI * Radius * Radius;

        private double radius = 20;

        public double Radius
        {
            get { return radius; }
            set
            {
                if (radius == value)
                {
                    return;
                }
                radius = value;
                Notify("Diameter");
                Notify("Area");
            }
        }

        public double Diameter => Radius * 2;
    }
}
