using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfStory.Data.Shapse
{
    public interface IShape
    {
        double Area { get; }
        Brush Fill { get; set; }
        Brush Stroke { get; set; }
        double StrokeThickness { get; set; }

    }
}
