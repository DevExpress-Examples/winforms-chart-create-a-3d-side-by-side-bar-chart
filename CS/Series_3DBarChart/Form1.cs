using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace Series_3DBarChart {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl BarChart3D = new ChartControl();

            // Add a bar series to it.
            Series series1 = new Series("Series 1", ViewType.Bar3D);
            Series series2 = new Series("Series 2", ViewType.Bar3D);

            // Add points to the series.
            series1.Points.Add(new SeriesPoint("A", 4));
            series1.Points.Add(new SeriesPoint("B", 7));
            series1.Points.Add(new SeriesPoint("C", 12));
            series1.Points.Add(new SeriesPoint("D", 17));
            series2.Points.Add(new SeriesPoint("A", 9));
            series2.Points.Add(new SeriesPoint("B", 11));
            series2.Points.Add(new SeriesPoint("C", 15));
            series2.Points.Add(new SeriesPoint("D", 23));

            // Add both series to the chart.
            BarChart3D.Series.AddRange(new Series[] { series1, series2 });

            // Access the series options.
            series1.Label.TextPattern = "{A}: {V}";
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;

            // Customize the view-type-specific properties of the series.
            Bar3DSeriesView myView = (Bar3DSeriesView)series1.View;
            myView.BarDepthAuto = false;
            myView.BarDepth = 1;
            myView.BarWidth = 1;
            myView.Transparency = 80;

            // Access the diagram's options.
            ((XYDiagram3D)BarChart3D.Diagram).ZoomPercent = 110;

            // Add a title to the chart and hide the legend.
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "3D Side-by-Side Bar Chart";
            BarChart3D.Titles.Add(chartTitle1);
            BarChart3D.Legend.Visibility =  DevExpress.Utils.DefaultBoolean.False;

            // Add the chart to the form.
            BarChart3D.Dock = DockStyle.Fill;
            this.Controls.Add(BarChart3D);
        }

    }
}