using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PSM5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            GalChart.Series.Clear();
            GalChart.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            GalChart.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;
            
            //===============================================================earth
            double G = 6.67259 * Math.Pow(10, -11);
            double Ms = 1.989 * Math.Pow(10, 30);
            double Rs = 1.5 * Math.Pow(10, 11);
            //double all_dt = 31558149.54;
            double all_dt = Convert.ToDouble(AllT.Value);
            Planet earth = new Planet(G, Ms, Rs, all_dt);

            Series earthSeries = new Series();
            earthSeries.Name = "earth";
            GalChart.Series.Add(earthSeries);

            earthSeries.ChartType = SeriesChartType.Line;
            earthSeries.BorderWidth = 1;
            earthSeries.Color = Color.Blue;
            //================================================================moon
            double Mz = 5.972 * Math.Pow(10, 24);
            double Rz = 384400000;
            //all_dt = 2358720;
            Planet moon = new Planet(G, Mz, Rz, all_dt);

            Series moonSeries = new Series();
            moonSeries.Name = "moon";
            GalChart.Series.Add(moonSeries);

            moonSeries.ChartType = SeriesChartType.Line;
            moonSeries.BorderWidth = 1;
            moonSeries.Color = Color.Black;

            //=================================================================mars
            
            double Rm = 228000000000;
            
            Planet mars = new Planet(G, Ms, Rm, 59356800);

            Series marsSeries = new Series();
            marsSeries.Name = "mars";
            GalChart.Series.Add(marsSeries);

            marsSeries.ChartType = SeriesChartType.Line;
            marsSeries.BorderWidth = 1;
            marsSeries.Color = Color.Red;

            //=================================================================mars

            double Rd = 23460 * 1000;
            double Rf = 9400 * 1000;
            double Mm = 6.4171 * Math.Pow(10,23);
            Planet Deimos = new Planet(G, Mm, Rd, 59356800);
            Planet Fobos = new Planet(G, Mm, Rf, 59356800);

            Series DeimosSeries = new Series();
            Series FobosSeries = new Series();
            DeimosSeries.Name = "deimos";
            FobosSeries.Name = "fobos";
            GalChart.Series.Add(DeimosSeries);
            GalChart.Series.Add(FobosSeries);

            DeimosSeries.ChartType = SeriesChartType.Line;
            FobosSeries.ChartType = SeriesChartType.Line;

            DeimosSeries.BorderWidth = 1;
            FobosSeries.BorderWidth = 1;

            DeimosSeries.Color = Color.Purple;
            FobosSeries.Color = Color.Plum;

            double dz = Convert.ToDouble(ScalePick.Value);

            for (int i = 0; i < earth.Sx.Count; i++)
            {
                earthSeries.Points.AddXY(earth.Sx[i], earth.Sy[i]);
                
            }
            for (int i = 0; i < moon.Sx.Count; i++)
            {
                moonSeries.Points.AddXY((moon.Sx[i]*dz + earth.Sx[i]), (moon.Sy[i]*dz + earth.Sy[i]));
            }
            /*for (int i = 0; i < mars.Sx.Count; i++)
            {

                marsSeries.Points.AddXY(mars.Sx[i], mars.Sy[i]);
            }
            for (int i = 0; i < Deimos.Sx.Count; i++)
            {

                DeimosSeries.Points.AddXY((Deimos.Sx[i] * dz + mars.Sx[i]), (Deimos.Sy[i] * dz + mars.Sy[i]));
            }
            for (int i = 0; i < Fobos.Sx.Count; i++)
            {

                FobosSeries.Points.AddXY((Fobos.Sx[i] * dz + mars.Sx[i]), (Fobos.Sy[i] * dz + mars.Sy[i]));
            }*/
            
        }
    }
}
