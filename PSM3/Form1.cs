using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PSM3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Chart Chart1 = new Chart();
            this.Controls.Add(EulerXY);
            DrawChart();
        }

        public void DrawChart()
        {
            EulerXY.Series.Clear();
            ChartArea chartArea = new ChartArea();
            EulerXY.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;

            double dt = Convert.ToDouble(DtPicker.Value);
            double l = Convert.ToDouble(LPicker.Value);
            double g = Convert.ToDouble(GPicker.Value) * -1;
            double m = Convert.ToDouble(MPicker.Value);
            double timer = Convert.ToDouble(Timer.Value);

            EulerXY.ChartAreas[0].AxisX.Minimum = -l;
            EulerXY.ChartAreas[0].AxisY.Minimum = -l;

            EulerXY.ChartAreas[0].AxisX.Maximum = l;
            EulerXY.ChartAreas[0].AxisY.Maximum = l;

            EulerXY.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;

            Series series = new Series();
            series.Name = "Euler";
            EulerXY.Series.Add(series);

            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 1;
            series.Color = Color.Blue;

            

            Euler m1 = new Euler(dt,g,l,m,timer);

            var m1x = m1.X;
            var m1y = m1.Y;

            for (int i = 0; i < m1x.Count; i++)
            {
                //Console.WriteLine(m1x[i] + " " + m1y[i]);
                series.Points.AddXY(m1x[i], m1y[i]);

            }

            EulerAlphaOmega.Series.Clear();
            ChartArea chartArea1 = new ChartArea();
            EulerAlphaOmega.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            EulerAlphaOmega.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;

            var m1Alpha = m1.Alpha;
            var m1Omega = m1.Omega;

            Series series1 = new Series();
            series1.Name = "Alpha Omega";
            EulerAlphaOmega.Series.Add(series1);

            series1.ChartType = SeriesChartType.Line;
            series1.BorderWidth = 1;
            series1.Color = Color.Blue;

            for (int i = 0; i < m1Alpha.Count; i++)
            {
                //Console.WriteLine(m1x[i] + " " + m1y[i]);
                series1.Points.AddXY(m1Alpha[i], m1Omega[i]);

            }

            var m1Ep = m1.Ep;
            var m1Ec = m1.Ec;
            var m1Ek = m1.Ek;
            var m1T = m1.T;

            EulerEnergia.Series.Clear();
            ChartArea chartArea2 = new ChartArea();
            EulerEnergia.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            EulerEnergia.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;

            Series series2 = new Series();
            series2.Name = "Ep";
            EulerEnergia.Series.Add(series2);

            series2.ChartType = SeriesChartType.Line;
            series2.BorderWidth = 1;
            series2.Color = Color.Green;

            Series series3 = new Series();
            series3.Name = "Ec";
            EulerEnergia.Series.Add(series3);

            series3.ChartType = SeriesChartType.Line;
            series3.BorderWidth = 1;
            series3.Color = Color.Blue;

            Series series4 = new Series();
            series4.Name = "Ek";
            EulerEnergia.Series.Add(series4);

            series4.ChartType = SeriesChartType.Line;
            series4.BorderWidth = 1;
            series4.Color = Color.Red;

            for (int i = 0; i < m1Ep.Count; i++)
            {
                //Console.WriteLine(m1x[i] + " " + m1y[i]);
                series2.Points.AddXY(m1T[i], m1Ep[i]);
                series3.Points.AddXY(m1T[i], m1Ec[i]);
                series4.Points.AddXY(m1T[i], m1Ek[i]);
            }

            BetterEuler bt = new BetterEuler(dt, g, l, m, timer);

            BetterEulerXY.Series.Clear();
            ChartArea chartArea3 = new ChartArea();
            BetterEulerXY.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            BetterEulerXY.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;

            BetterEulerXY.ChartAreas[0].AxisX.Minimum = -l;
            BetterEulerXY.ChartAreas[0].AxisY.Minimum = -l;

            BetterEulerXY.ChartAreas[0].AxisX.Maximum = l;
            BetterEulerXY.ChartAreas[0].AxisY.Maximum = l;

            var btX = bt.X;
            var btY = bt.Y;

            Series seriesbtXY = new Series();
            seriesbtXY.Name = "Better Euler";
            BetterEulerXY.Series.Add(seriesbtXY);

            seriesbtXY.ChartType = SeriesChartType.Line;
            seriesbtXY.BorderWidth = 1;
            seriesbtXY.Color = Color.Blue;

            for (int i = 0; i < btX.Count; i++)
            {
                //Console.WriteLine(m1x[i] + " " + m1y[i]);
                seriesbtXY.Points.AddXY(btX[i], btY[i]);

            }

            BetterEulerAlphaOmega.Series.Clear();
            ChartArea chartArea4 = new ChartArea();
            BetterEulerAlphaOmega.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            BetterEulerAlphaOmega.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;

            var btAlpha = bt.Alpha;
            var btOmega = bt.Omega;

            Series seriesbtAlphaOmega = new Series();
            seriesbtAlphaOmega.Name = "Better Euler\nAlpha Omega";
            BetterEulerAlphaOmega.Series.Add(seriesbtAlphaOmega);

            seriesbtAlphaOmega.ChartType = SeriesChartType.Line;
            seriesbtAlphaOmega.BorderWidth = 1;
            seriesbtAlphaOmega.Color = Color.Blue;

            for (int i = 0; i < btAlpha.Count; i++)
            {
                //Console.WriteLine(m1x[i] + " " + m1y[i]);
                seriesbtAlphaOmega.Points.AddXY(btAlpha[i], btOmega[i]);

            }

            BetterEulerEnergie.Series.Clear();
            ChartArea chartArea5 = new ChartArea();
            BetterEulerEnergie.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            BetterEulerEnergie.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;

            var btEc = bt.Ec;
            var btEp = bt.Ep;
            var btEk = bt.Ek;
            var btT = bt.T;

            Series seriesbtEc = new Series();
            seriesbtEc.Name = "Better Euler Ec";
            BetterEulerEnergie.Series.Add(seriesbtEc);

            seriesbtEc.ChartType = SeriesChartType.Line;
            seriesbtEc.BorderWidth = 1;
            seriesbtEc.Color = Color.Blue;

            Series seriesbtEp = new Series();
            seriesbtEp.Name = "Better Euler Ep";
            BetterEulerEnergie.Series.Add(seriesbtEp);

            seriesbtEp.ChartType = SeriesChartType.Line;
            seriesbtEp.BorderWidth = 1;
            seriesbtEp.Color = Color.Green;

            Series seriesbtEk = new Series();
            seriesbtEk.Name = "Better Euler Ek";
            BetterEulerEnergie.Series.Add(seriesbtEk);

            seriesbtEk.ChartType = SeriesChartType.Line;
            seriesbtEk.BorderWidth = 1;
            seriesbtEk.Color = Color.Red;

            for (int i = 0; i < btEc.Count; i++)
            {
                //Console.WriteLine(m1x[i] + " " + m1y[i]);
                seriesbtEc.Points.AddXY(btT[i], btEc[i]);
                seriesbtEp.Points.AddXY(btT[i], btEp[i]);
                seriesbtEk.Points.AddXY(btT[i], btEk[i]);
            }

            RK4 rk = new RK4(dt, g, l, m, timer);

            RK4XY.Series.Clear();
            ChartArea chartArea6 = new ChartArea();
            RK4XY.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            RK4XY.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;

            RK4XY.ChartAreas[0].AxisX.Minimum = -l;
            RK4XY.ChartAreas[0].AxisY.Minimum = -l;

            RK4XY.ChartAreas[0].AxisX.Maximum = l;
            RK4XY.ChartAreas[0].AxisY.Maximum = l;

            var rkX = rk.X;
            var rkY = rk.Y;

            Series seriesrkXY = new Series();
            seriesrkXY.Name = "RK4 XY";
            RK4XY.Series.Add(seriesrkXY);

            seriesrkXY.ChartType = SeriesChartType.Line;
            seriesrkXY.BorderWidth = 1;
            seriesrkXY.Color = Color.Blue;

            for (int i = 0; i < rkX.Count; i++)
            {
                //Console.WriteLine(m1x[i] + " " + m1y[i]);
                seriesrkXY.Points.AddXY(rkX[i], rkY[i]);

            }

            RK4AlphaOmega.Series.Clear();
            ChartArea chartArea7 = new ChartArea();
            RK4AlphaOmega.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            RK4AlphaOmega.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;

            var rkAlpha = rk.Alpha;
            var rkOmega = rk.Omega;

            Series seriesrkAlphaOmega = new Series();
            seriesrkAlphaOmega.Name = "RK4\n Alpha\n Omega";
            RK4AlphaOmega.Series.Add(seriesrkAlphaOmega);

            seriesrkAlphaOmega.ChartType = SeriesChartType.Line;
            seriesrkAlphaOmega.BorderWidth = 1;
            seriesrkAlphaOmega.Color = Color.Blue;

            for (int i = 0; i < rkAlpha.Count; i++)
            {
                //Console.WriteLine(m1x[i] + " " + m1y[i]);
                seriesrkAlphaOmega.Points.AddXY(rkAlpha[i], rkOmega[i]);

            }

            RK4Energie.Series.Clear();
            ChartArea chartArea8 = new ChartArea();
            RK4Energie.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            RK4Energie.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;

            var rkEc = rk.Ec;
            var rkEp = rk.Ep;
            var rkEk = rk.Ek;
            var rkT = rk.T;

            Series seriesrkEc = new Series();
            seriesrkEc.Name = "RK4 Ec";
            RK4Energie.Series.Add(seriesrkEc);

            seriesrkEc.ChartType = SeriesChartType.Line;
            seriesrkEc.BorderWidth = 1;
            seriesrkEc.Color = Color.Blue;

            Series seriesrkEp = new Series();
            seriesrkEp.Name = "RK4 Ep";
            RK4Energie.Series.Add(seriesrkEp);

            seriesrkEp.ChartType = SeriesChartType.Line;
            seriesrkEp.BorderWidth = 1;
            seriesrkEp.Color = Color.Green;

            Series seriesrkEk = new Series();
            seriesrkEk.Name = "RK4 Ek";
            RK4Energie.Series.Add(seriesrkEk);

            seriesrkEk.ChartType = SeriesChartType.Line;
            seriesrkEk.BorderWidth = 1;
            seriesrkEk.Color = Color.Red;

            for (int i = 0; i < rkEc.Count; i++)
            {
                //Console.WriteLine(m1x[i] + " " + m1y[i]);
                seriesrkEc.Points.AddXY(rkT[i], rkEc[i]);
                seriesrkEp.Points.AddXY(rkT[i], rkEp[i]);
                seriesrkEk.Points.AddXY(rkT[i], rkEk[i]);
            }

            AllEcsChart.Series.Clear();
            ChartArea chartArea9 = new ChartArea();
            AllEcsChart.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            AllEcsChart.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;

            Series seriesEcEuler = new Series();
            seriesEcEuler.Name = "Euler Ec";
            AllEcsChart.Series.Add(seriesEcEuler);

            seriesEcEuler.ChartType = SeriesChartType.Line;
            seriesEcEuler.BorderWidth = 1;
            seriesEcEuler.Color = Color.Blue;

            Series seriesEcBtEuler = new Series();
            seriesEcBtEuler.Name = "Better Euler Ec";
            AllEcsChart.Series.Add(seriesEcBtEuler);

            seriesEcBtEuler.ChartType = SeriesChartType.Line;
            seriesEcBtEuler.BorderWidth = 1;
            seriesEcBtEuler.Color = Color.Green;

            Series seriesrkEcRK4 = new Series();
            seriesrkEcRK4.Name = "RK4 Ec";
            AllEcsChart.Series.Add(seriesrkEcRK4);

            seriesrkEcRK4.ChartType = SeriesChartType.Line;
            seriesrkEcRK4.BorderWidth = 1;
            seriesrkEcRK4.Color = Color.Red;

            for (int i = 0; i < rkEc.Count; i++)
            {
                //Console.WriteLine(m1x[i] + " " + m1y[i]);
                seriesEcEuler.Points.AddXY(m1T[i], m1Ec[i]);
                seriesEcBtEuler.Points.AddXY(btT[i], btEc[i]);
                seriesrkEcRK4.Points.AddXY(rkT[i], rkEc[i]);
            }
        }
    }
}
