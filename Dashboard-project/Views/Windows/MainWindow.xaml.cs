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
using Dashboard_project.Classes;
using Dashboard_project.ViewModels;
using Dashboard_project.Views.Pages;
using Dashboard_project.Views.UserControls;

namespace Dashboard_project
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HeaderUserControl.CurrentWindow = this;
            MainFrame.Navigate(new DashboardPage());
            ManagerClass.MainFrame = MainFrame;
        }
    }
}
