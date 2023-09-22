using LiveCharts;
using LiveCharts.Defaults;
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
    /// Логика взаимодействия для BubbleDiagrammControl.xaml
    /// </summary>
    public partial class BubbleDiagrammControl : UserControl
    {
        public BubbleDiagrammControl()
        {
            InitializeComponent();

            RadialGradientBrush FirstRadialgradient = new RadialGradientBrush();
            FirstRadialgradient.GradientStops.Add(new GradientStop(Color.FromRgb(91, 196, 255), 1));
            FirstRadialgradient.GradientStops.Add(new GradientStop(Color.FromRgb(255, 91, 239), 0));
            
            
            RadialGradientBrush SecondRadialgradient = new RadialGradientBrush();
            SecondRadialgradient.GradientStops.Add(new GradientStop(Color.FromRgb(255, 147, 15), 1));
            SecondRadialgradient.GradientStops.Add(new GradientStop(Color.FromRgb(255, 249, 91), 0));

            SeriesCollection = new SeriesCollection
            {
                new ScatterSeries
                {
                    Values = new ChartValues<ScatterPoint>
                    {
                        new ScatterPoint(5, 5, 20),
                        new ScatterPoint(3, 4, 80),
                        new ScatterPoint(7, 2, 20),
                        new ScatterPoint(2, 6, 60),
                        new ScatterPoint(8, 2, 70)
                    },
                    MinPointShapeDiameter = 15,
                    MaxPointShapeDiameter = 45,
                    Fill = FirstRadialgradient

                },
                new ScatterSeries
                {
                    Values = new ChartValues<ScatterPoint>
                    {
                        new ScatterPoint(7, 5, 1),
                        new ScatterPoint(2, 2, 1),
                        new ScatterPoint(1, 1, 1),
                        new ScatterPoint(6, 3, 1),
                        new ScatterPoint(8, 8, 1)
                    },
                    PointGeometry = DefaultGeometries.Triangle,
                    MinPointShapeDiameter = 15,
                    MaxPointShapeDiameter = 45,
                    Fill=SecondRadialgradient
                }
            };

            DataContext = this;
        }
        public SeriesCollection SeriesCollection { get; set; }

        private void UpdateAllOnClick(object sender, RoutedEventArgs e)
        {
            var r = new Random();
            foreach (var series in SeriesCollection)
            {
                foreach (var bubble in series.Values.Cast<ScatterPoint>())
                {
                    bubble.X = r.NextDouble() * 10;
                    bubble.Y = r.NextDouble() * 10;
                    bubble.Weight = r.NextDouble() * 10;
                }
            }
        }

        private void BorderBubbleDiagramm_MouseEnter(object sender, MouseEventArgs e)
        {
            DropShadow.Visibility = Visibility.Visible;
        }

        private void BorderBubbleDiagramm_MouseLeave(object sender, MouseEventArgs e)
        {
            DropShadow.Visibility = Visibility.Collapsed;
        }
    }
}

