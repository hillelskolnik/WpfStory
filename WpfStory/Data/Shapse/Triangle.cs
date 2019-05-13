using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WpfStory.Data.Shapse
{
    class Triangle : ShapeBase
    {
        public override double Area => Math.Abs(P1X * (P2Y - P3Y) +
            P2X * (P3Y - P1Y) +
            P3X * (P1Y - P2Y)) / 2;

        public Triangle()
        {
            Fill = new SolidColorBrush(Colors.DarkViolet);
            Stroke = new SolidColorBrush(Colors.Black);
            StrokeThickness = 2;
        }

        public double P1X
        {
            get { return points[0].X; }
            set
            {
                if (points[0].X == value)
                {
                    return;
                }
                points[0].X = value;
                Notify("Points");
                Notify("Area");
                Notify("Width");
                Notify("Height");
            }
        }
        public double P1Y
        {
            get { return points[0].Y; }
            set
            {
                if (points[0].Y == value)
                {
                    return;
                }
                points[0].Y = value;
                Notify("Points");
                Notify("Area");
                Notify("Width");
                Notify("Height");
            }
        }

        public double P2X
        {
            get { return points[1].X; }
            set
            {
                if (points[1].X == value)
                {
                    return;
                }
                points[1].X = value;
                Notify("Points");
                Notify("Area");
                Notify("Width");
                Notify("Height");
            }
        }
        public double P2Y
        {
            get { return points[1].Y; }
            set
            {
                if (points[1].Y == value)
                {
                    return;
                }
                points[1].Y = value;
                Notify("Points");
                Notify("Area");
                Notify("Width");
                Notify("Height");
            }
        }
        public double P3X
        {
            get { return points[2].X; }
            set
            {
                if (points[2].X == value)
                {
                    return;
                }
                points[2].X = value;
                Notify("Points");
                Notify("Area");
                Notify("Width");
                Notify("Height");
            }
        }
        public double P3Y
        {
            get { return points[2].Y; }
            set
            {
                if (points[2].Y == value)
                {
                    return;
                }
                points[2].Y = value;
                Notify("Points");
                Notify("Area");
                Notify("Width");
                Notify("Height");
            }
        }

        public double Height => points.Max(p => p.Y) + 10;
        public double Width => points.Max(p => p.X);

        private Point[] points = new Point[] {new Point(15,15), new Point(20, 30), new Point(50, 25)};
        public PointCollection Points
        {
            get
            {
                double max = points.Max(p => p.Y) + 5;

                return new PointCollection(points.Select(p => new Point(p.X, max - p.Y)));
            }
        }
    }
}
