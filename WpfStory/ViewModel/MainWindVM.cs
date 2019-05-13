using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfStory.ViewModel
{
    public class MainWindVM
    {
        // Pure MVVM approach
        public ICommand ButtonCommand { get; set; }

        // For code injection approach
        private MainWindow mainWindow;

        // For code injection approach
        public MainWindow MainWindow
        {
            get { return mainWindow; }
            set
            {
                if (mainWindow != null)
                {
                    return;
                }
                mainWindow = value;
                mainWindow.btnResourcesTypes.Click += BtnResourcesTypes_Click;
                mainWindow.btnDataTemplates.Click += BtnDataTemplates_Click;
            }
        }

        // For code injection approach
        private void BtnDataTemplates_Click(object sender, RoutedEventArgs e)
        {
        }

        // For code injection approach
        private void BtnResourcesTypes_Click(object sender, RoutedEventArgs e)
        {
        }


        public MainWindVM()
        {
            // Pure MVVM approach
            ButtonCommand = new RelayCommand(new Action<object>(Button_Click), new Predicate<object>(Button_CanExecute) );
        }

        // Pure MVVM approach
        private void DataTemplate()
        {
            View.DataTemplateView dtv = new View.DataTemplateView();
            dtv.ShowDialog();

        }

        // Pure MVVM approach
        private void ResoucesTypes()
        {
            View.ResourceTypesView rtw = new View.ResourceTypesView();
            rtw.ShowDialog();

        }

        // Pure MVVM approach
        public bool Button_CanExecute(object sender)
        {
            return true;
        }

        // Pure MVVM approach
        public void Button_Click(object sender)
        {
            MethodInfo methodInfo = GetType().GetMethod(sender.ToString(), BindingFlags.NonPublic | BindingFlags.Instance);
            methodInfo?.Invoke(this, null);
        }
    }


}
