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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dashboard_project.Views.UserControls
{
    /// <summary>
    /// Логика взаимодействия для HeaderUserControl.xaml
    /// </summary>
    public partial class HeaderUserControl : UserControl
    {
        public static Window CurrentWindow;
        public HeaderUserControl()
        {
            InitializeComponent();

        }
        private void ApplicationQuit(object sender, RoutedEventArgs e)
        {
            CurrentWindow?.Close();
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                CurrentWindow.DragMove();
            }
        }

        private void HideWindow(object sender, RoutedEventArgs e)
        {
            CurrentWindow.WindowState = WindowState.Minimized;
        }

        private void Header_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            CurrentWindow.WindowState = WindowState.Normal;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CurrentWindow.WindowState = WindowState.Normal;
        }
    }
}
