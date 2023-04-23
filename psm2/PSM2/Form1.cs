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

namespace PSM2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Layout(object sender, LayoutEventArgs e)
        {

        }
        

        private void firstSeries()
        {
            

            chart1.Series.Clear();
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            chart1.ChartAreas[0].AxisY.Interval = 1;
            
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;

            chart1.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(SxPicker.Value);
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            
            Series series = new Series();
            series.Name = "Techniqe 1";
            chart1.Series.Add(series);
            
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 1;
            series.Color = Color.Green;

            double dt = Convert.ToDouble(dtpick.Value);
            double gx = Convert.ToDouble(gxpick.Value);
            double gy = Convert.ToDouble(gypick.Value)*-1;
            double m = Convert.ToDouble(mpick.Value);
            double q = Convert.ToDouble(qpick.Value);
            double Vx = Convert.ToDouble(VxPicker.Value);
            double Vy = Convert.ToDouble(VyPicker.Value);
            double Sx = Convert.ToDouble(SxPicker.Value);
            double Sy = Convert.ToDouble(SyPicker.Value);
            
            Technik1 technik1 = new Technik1(dt, gx, gy, m, q, Vx, Vy, Sx, Sy);

            var t1x = technik1.x;
            var t1y = technik1.y;

            for (int i = 0; i < t1x.Count; i++)
            {
                series.Points.AddXY(t1x[i] , t1y[i]);
                
            }
            
            Technik2 technik2 = new Technik2(dt, gx, gy, m, q, Vx, Vy, Sx, Sy);

            Series series2 = new Series();
            series2.Name = "Techniqe 2";
            chart1.Series.Add(series2);
            
            series2.ChartType = SeriesChartType.Line;
            series2.BorderWidth = 1;
            series2.Color = Color.Red;

            var t2x = technik2.x;
            var t2y = technik2.y;

            for (int i = 0; i < t2x.Count; i++)
            {
                series2.Points.AddXY(t2x[i], t2y[i]);

            }
            
            if (t1x.Max() >= t2x.Max())
            {
                chart1.ChartAreas[0].AxisX.Interval = Math.Round(Math.Round(t1x.Max())/5);
            }
            if (t1x.Max() < t2x.Max())
            {
                chart1.ChartAreas[0].AxisX.Interval = Math.Round(Math.Round(t2x.Max()) / 5);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Chart chart1 = new Chart();
            this.Controls.Add(chart1);
            firstSeries();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }
    }
}
