using LiveCharts;
using LiveCharts.Wpf;
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

namespace Dashboard_project.Views.UserControls.Diagramm
{
    /// <summary>
    /// Логика взаимодействия для LineDiagrammControl.xaml
    /// </summary>
    public partial class LineDiagrammControl : UserControl
    {
        public LineDiagrammControl()
        {
            InitializeComponent();

            LinearGradientBrush gradientBrush = new LinearGradientBrush();
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromRgb(91, 196, 255), 0));
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromRgb(255, 91, 239), 1));

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double> { 4, 6, 5, 2 ,4 },
                    PointGeometrySize = 0,
                    Stroke = gradientBrush,
                    LineSmoothness = 0,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0)) { Opacity = 0 },
                },
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double> { 10, 7, 1, 4 ,2 },
                    PointGeometrySize = 10,
                    Stroke = gradientBrush,
                    LineSmoothness = 0,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0)) { Opacity = 0 },
                },
            };


            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" };
            YFormatter = value => value.ToString("C");

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

        private void BorderLineDiagramm_MouseEnter(object sender, MouseEventArgs e)
        {
           DropShadow.Visibility = Visibility.Visible;
        }

        private void BorderLineDiagramm_MouseLeave(object sender, MouseEventArgs e)
        {
            DropShadow.Visibility = Visibility.Collapsed;
        }
    }
}
