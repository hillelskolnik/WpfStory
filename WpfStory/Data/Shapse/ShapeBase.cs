using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfStory.Data.Shapse
{
    public abstract class ShapeBase : NotifyChange, IShape
    {
        public static PropertyInfo[] ColorsList => typeof(Colors).GetProperties();

        private PropertyInfo colorPropertyInfoFill;

        public PropertyInfo ColorPropertyInfoFill
        {
            get { return colorPropertyInfoFill; }
            set
            {
                if (colorPropertyInfoFill == value)
                {
                    return;
                }
                colorPropertyInfoFill = value;
                Color color = (Color)colorPropertyInfoFill.GetValue(null, null);
                Fill = new SolidColorBrush(color);
            }
        }

        abstract public double  Area { get; }

        private Brush fill;

        public Brush Fill
        {
            get { return fill; }
            set
            {
                if (fill == value)
                {
                    return;
                }
                fill = value;
                Notify("Fill");
                SolidColorBrush b = fill as SolidColorBrush;
                if (b !=null)
                {
                    Color c = b.Color;
                    PropertyInfo colorProperty =
                        ColorsList.FirstOrDefault(p => Color.AreClose((Color)p.GetValue(null), c));
                    if (colorProperty != null)
                    {
                        ColorPropertyInfoFill = colorProperty;
                    }
                }
                
            }
        }

        private Brush stroke;

        public Brush Stroke
        {
            get { return stroke; }
            set
            {
                if (stroke == value)
                {
                    return;
                }
                stroke = value;
                Notify("Stroke");
            }
        }

        private double strokeThickness;

        public double StrokeThickness
        {
            get { return strokeThickness; }
            set
            {
                if (strokeThickness == value)
                {
                    return;
                }
                strokeThickness = value;
                Notify("Stroke");
            }
        }

    }
}
