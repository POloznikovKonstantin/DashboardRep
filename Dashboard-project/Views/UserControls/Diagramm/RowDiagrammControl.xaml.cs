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
    /// Логика взаимодействия для RowDiagrammControl.xaml
    /// </summary>
    public partial class RowDiagrammControl : UserControl
    {
        public RowDiagrammControl()
        {
            InitializeComponent();

            LinearGradientBrush oneGrdientBrush = new LinearGradientBrush();
            oneGrdientBrush.GradientStops.Add(new GradientStop(Color.FromRgb(248, 155, 41), 0));
            oneGrdientBrush.GradientStops.Add(new GradientStop(Color.FromRgb(255, 15, 123), 1));

            LinearGradientBrush SecondLinegradient = new LinearGradientBrush();
            SecondLinegradient.GradientStops.Add(new GradientStop(Color.FromRgb(96, 239, 255), 0));
            SecondLinegradient.GradientStops.Add(new GradientStop(Color.FromRgb(0, 97, 255), 1));

            SeriesCollection = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "2015",
                    Values = new ChartValues<double> { 10, 50, 39, 50 },
                    Fill = oneGrdientBrush
                }
            };

            //adding series will update and animate the chart automatically
            SeriesCollection.Add(new RowSeries
            {
                Title = "2016",
                Values = new ChartValues<double> { 11, 56, 42 },
                Fill = SecondLinegradient
            });

            //also adding values updates and animates the chart automatically
            SeriesCollection[1].Values.Add(48d);

            Labels = new[] { "Maria", "Susan", "Charles", "Frida" };
            Formatter = value => value.ToString("N");

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }
    }
}
