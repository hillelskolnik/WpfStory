using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WpfStory.Data;
using WpfStory.Data.Shapse;

namespace WpfStory.ViewModel
{
    public class DataTemplateViewVM : NotifyChange
    {
        public ObservableCollection<IShape> Shapes { get; private set; } = new ObservableCollection<IShape>();
        public DataTemplateViewVM()
        {
            Shapes.Add(new Circle() { });
            Shapes.Add(new Circle() { Fill = new SolidColorBrush(Colors.Blue), Radius = 50});
            Shapes.Add(new Square() { });
            Shapes.Add(new Triangle() { });
        }

        private int selectedIndex = 0;

        public int SelectedIndex
        {
            get { return selectedIndex; }
            set
            {
                selectedIndex = value;
                Notify("SelectedIndex");
            }
        }

    }
}
