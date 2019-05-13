using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfStory.Data.Shapse
{
    class ShapesDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CircleDataTemplate { get; set; }
        public DataTemplate SquareDataTemplate { get; set; }
        public DataTemplate TriangleDataTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is Square)
            {
                return SquareDataTemplate;
            }
            else if (item is Triangle)
            {
                return TriangleDataTemplate;
            }

            return CircleDataTemplate;
        }
    }
}
