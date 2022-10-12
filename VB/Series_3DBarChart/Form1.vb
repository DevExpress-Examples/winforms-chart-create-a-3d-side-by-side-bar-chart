Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

' ...
Namespace Series_3DBarChart

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Create a new chart.
            Dim BarChart3D As ChartControl = New ChartControl()
            ' Add a bar series to it.
            Dim series1 As Series = New Series("Series 1", ViewType.Bar3D)
            Dim series2 As Series = New Series("Series 2", ViewType.Bar3D)
            ' Add points to the series.
            series1.Points.Add(New SeriesPoint("A", 4))
            series1.Points.Add(New SeriesPoint("B", 7))
            series1.Points.Add(New SeriesPoint("C", 12))
            series1.Points.Add(New SeriesPoint("D", 17))
            series2.Points.Add(New SeriesPoint("A", 9))
            series2.Points.Add(New SeriesPoint("B", 11))
            series2.Points.Add(New SeriesPoint("C", 15))
            series2.Points.Add(New SeriesPoint("D", 23))
            ' Add both series to the chart.
            BarChart3D.Series.AddRange(New Series() {series1, series2})
            ' Access the series options.
            series1.Label.TextPattern = "{A}: {V}"
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
            ' Customize the view-type-specific properties of the series.
            Dim myView As Bar3DSeriesView = CType(series1.View, Bar3DSeriesView)
            myView.BarDepthAuto = False
            myView.BarDepth = 1
            myView.BarWidth = 1
            myView.Transparency = 80
            ' Access the diagram's options.
            CType(BarChart3D.Diagram, XYDiagram3D).ZoomPercent = 110
            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As ChartTitle = New ChartTitle()
            chartTitle1.Text = "3D Side-by-Side Bar Chart"
            BarChart3D.Titles.Add(chartTitle1)
            BarChart3D.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ' Add the chart to the form.
            BarChart3D.Dock = DockStyle.Fill
            Me.Controls.Add(BarChart3D)
        End Sub
    End Class
End Namespace
