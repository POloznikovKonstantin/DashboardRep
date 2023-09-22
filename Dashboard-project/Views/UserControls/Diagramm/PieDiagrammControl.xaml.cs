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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dashboard_project.Views.UserControls.Diagramm
{
    /// <summary>
    /// Логика взаимодействия для PieDiagrammControlControl.xaml
    /// </summary>
    public partial class PieDiagrammControl : UserControl
    {
        
        LinearGradientBrush gradientBrush = new LinearGradientBrush();

        DoubleAnimation AnimationWidth = new DoubleAnimation();
        DoubleAnimation AnimationHeight = new DoubleAnimation();

        double WidthBorder;
        public PieDiagrammControl()
        {
            InitializeComponent();

            WidthBorder = BorderDiagramm.ActualWidth;
            
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromRgb(91, 196, 255), 0));
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromRgb(255, 91, 239), 1));

            PointLabel = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            DataContext = this;
        }

        public Func<ChartPoint, string> PointLabel { get; set; }

        private void Chart_OnDataClick(object sender, ChartPoint chartpoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartpoint.ChartView;

            //clear selected slice.
            foreach (PieSeries series in chart.Series)
            {
                series.PushOut = 0;
            }

            var selectedSeries = (PieSeries)chartpoint.SeriesView;
            selectedSeries.PushOut = 8;
        }

        private void BorderDiagramm_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationHeight.From = BorderDiagramm.ActualHeight;
            AnimationHeight.To = BorderDiagramm.ActualHeight + 5;
            AnimationHeight.Duration = TimeSpan.FromSeconds(0.75);
            BorderDiagramm.BeginAnimation(Border.HeightProperty, AnimationHeight);

            AnimationWidth.From = BorderDiagramm.ActualWidth;
            AnimationWidth.To = BorderDiagramm.ActualWidth + 5;
            AnimationWidth.Duration = TimeSpan.FromSeconds(0.75);
            BorderDiagramm.BeginAnimation(Border.WidthProperty, AnimationWidth);
        }

        private void BorderDiagramm_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationHeight.From = BorderDiagramm.ActualHeight;
            AnimationHeight.To = BorderDiagramm.ActualHeight - 5;
            AnimationHeight.Duration = TimeSpan.FromSeconds(0.75);
            BorderDiagramm.BeginAnimation(Border.HeightProperty, AnimationHeight);

            AnimationWidth.From = BorderDiagramm.ActualWidth;
            AnimationWidth.To = BorderDiagramm.ActualWidth - 5;
            AnimationWidth.Duration = TimeSpan.FromSeconds(0.75);
            BorderDiagramm.BeginAnimation(Border.WidthProperty, AnimationWidth);
        }
    }
}

