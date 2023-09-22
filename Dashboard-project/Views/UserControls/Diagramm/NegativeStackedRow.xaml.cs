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
    /// Логика взаимодействия для NegativeStackedRow.xaml
    /// </summary>
    public partial class NegativeStackedRow : UserControl
    {
        public NegativeStackedRow()
        {
            InitializeComponent();

            LinearGradientBrush oneGrdientBrush = new LinearGradientBrush();
            oneGrdientBrush.GradientStops.Add(new GradientStop(Color.FromRgb(248, 155, 41), 1));
            oneGrdientBrush.GradientStops.Add(new GradientStop(Color.FromRgb(255, 15, 123), 0));

            LinearGradientBrush SecondLinegradient = new LinearGradientBrush();
            SecondLinegradient.GradientStops.Add(new GradientStop(Color.FromRgb(96, 239, 255), 0));
            SecondLinegradient.GradientStops.Add(new GradientStop(Color.FromRgb(0, 97, 255), 1));

            SeriesCollection = new SeriesCollection
            {
                new StackedRowSeries
                {
                    Title = "Male",
                    Values = new ChartValues<double> {.5, .7, .8, .8, .6, .2, .6, .7, .1, .4},
                    Fill = oneGrdientBrush
                },
                new StackedRowSeries
                {
                    Title = "Female",
                    Values = new ChartValues<double> {-.9, -.3, -.7, -.2, -.7, -.1, -.4, -.7, -.1, -.4},
                    Fill = SecondLinegradient
                }
            };

            Labels = new[] { "0-20", "20-35", "35-45", "45-55", "55-65", "65-70", ">70" };
            Formatter = value => Math.Abs(value).ToString("P");

            DataContext = this;

        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

    }
}

