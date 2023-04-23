using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PSM4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            Chart Chart1 = new Chart();
            this.Controls.Add(EulerRownia);
            DrawChart();
        }

        public void DrawChart() 
        {
            double h = Convert.ToDouble(HPick.Value);
            double dt = Convert.ToDouble(DtPick.Value);
            double r = Convert.ToDouble(RPick.Value);
            double m = Convert.ToDouble(MPick.Value);
            double g = Convert.ToDouble(GPick.Value);
            int alpha = Convert.ToInt32(AlphaPick.Value);

            double alpha2 = (alpha * Math.PI) / 180;

            double l = (2 * m * Math.Pow(r, 2)) / 5;
            var euler = new BetterEuler(h, dt, r, m, g, alpha2, l);
            //================================================Euler kula
            EulerRownia.Series.Clear();
            EulerEnergie.Series.Clear();
            BetterEulerEnergie.Series.Clear();
            ChartArea EulerRow = new ChartArea();
            EulerRownia.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            EulerRownia.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;

            EulerRownia.ChartAreas[0].Axes[1].Minimum = -5;
            EulerRownia.ChartAreas[0].Axes[0].Minimum = -5;
            EulerRownia.ChartAreas[0].Axes[0].Maximum = h / Math.Tan(alpha2) + 2 * r;

            Series Rownia = new Series();
            Rownia.Name = "rownia";
            EulerRownia.Series.Add(Rownia);

            Rownia.ChartType = SeriesChartType.Line;
            Rownia.BorderWidth = 1;
            Rownia.Color = Color.Blue;

            Rownia.Points.AddXY(0, h);
            Rownia.Points.AddXY(h/Math.Tan(alpha2), 0);

            var eulerXsm_r = euler.Xsm_r;
            var eulerYsm_r = euler.Ysm_r;

            Series Kropki = new Series();
            Kropki.Name = "tor";
            EulerRownia.Series.Add(Kropki);

            Kropki.ChartType = SeriesChartType.Point;
            Kropki.BorderWidth = 1;
            Kropki.Color = Color.Orange;

            for (int i = 0; i < eulerXsm_r.Count; i++)
            {
                //Console.WriteLine(m1x[i] + " " + m1y[i]);
                Kropki.Points.AddXY(eulerXsm_r[i], eulerYsm_r[i]);

            }

            var Ex = euler.X;
            var Ey = euler.Y;

            Series trajectory = new Series();
            trajectory.Name = "trajektoria";
            EulerRownia.Series.Add(trajectory);

            trajectory.ChartType = SeriesChartType.Line;
            trajectory.BorderWidth = 1;
            trajectory.Color = Color.Black;

            for (int i = 0; i < Ex.Count; i++)
            {
                //Console.WriteLine(m1x[i] + " " + m1y[i]);
                trajectory.Points.AddXY(Ex[i], Ey[i]);

            }

            var Eec = euler.Ec;
            var Eek = euler.Ek;
            var Eep = euler.Ep;
            var Et = euler.T;

            Series EulerEc = new Series();
            EulerEc.Name = "Ec";
            EulerEnergie.Series.Add(EulerEc);

            EulerEc.ChartType = SeriesChartType.Line;
            EulerEc.BorderWidth = 1;
            EulerEc.Color = Color.Blue;

            Series EulerEk = new Series();
            EulerEk.Name = "Ek";
            EulerEnergie.Series.Add(EulerEk);

            EulerEk.ChartType = SeriesChartType.Line;
            EulerEk.BorderWidth = 1;
            EulerEk.Color = Color.Red;

            Series EulerEp = new Series();
            EulerEp.Name = "Ep";
            EulerEnergie.Series.Add(EulerEp);

            EulerEp.ChartType = SeriesChartType.Line;
            EulerEp.BorderWidth = 1;
            EulerEp.Color = Color.Green;

            for (int i = 0; i < Eec.Count; i++)
            {
                //Console.WriteLine(Eec[i]);
                EulerEc.Points.AddXY(Et[i], Eec[i]);
                EulerEk.Points.AddXY(Et[i], Eek[i]);
                EulerEp.Points.AddXY(Et[i], Eep[i]);
            }
            Console.WriteLine();
            //================================================Euler sfera
            l = (2 * m * Math.Pow(r, 2)) / 3;
            var euler2 = new BetterEuler(h, dt, r, m, g, alpha2, l);

            BetterEulerRownia.Series.Clear();
            ChartArea BetterEulerRow = new ChartArea();
            BetterEulerRownia.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            BetterEulerRownia.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;

            BetterEulerRownia.ChartAreas[0].Axes[1].Minimum = -5;
            BetterEulerRownia.ChartAreas[0].Axes[0].Minimum = -5;
            BetterEulerRownia.ChartAreas[0].Axes[0].Maximum = h / Math.Tan(alpha2) + 2 * r;

            Series BetterRownia = new Series();
            BetterRownia.Name = "rownia";
            BetterEulerRownia.Series.Add(BetterRownia);

            BetterRownia.ChartType = SeriesChartType.Line;
            BetterRownia.BorderWidth = 1;
            BetterRownia.Color = Color.Blue;

            BetterRownia.Points.AddXY(0, h);
            BetterRownia.Points.AddXY(h / Math.Tan(alpha2), 0);

            var eulerSXsm_r = euler2.Xsm_r;
            var eulerSYsm_r = euler2.Ysm_r;

            Series KropkiS = new Series();
            KropkiS.Name = "tor";
            BetterEulerRownia.Series.Add(KropkiS);

            KropkiS.ChartType = SeriesChartType.Point;
            KropkiS.BorderWidth = 1;
            KropkiS.Color = Color.Orange;

            for (int i = 0; i < eulerSXsm_r.Count; i++)
            {
                //Console.WriteLine(m1x[i] + " " + m1y[i]);
                KropkiS.Points.AddXY(eulerSXsm_r[i], eulerSYsm_r[i]);

            }

            var ESx = euler2.X;
            var ESy = euler2.Y;

            Series trajectoryS = new Series();
            trajectoryS.Name = "trajektoria";
            BetterEulerRownia.Series.Add(trajectoryS);

            trajectoryS.ChartType = SeriesChartType.Line;
            trajectoryS.BorderWidth = 1;
            trajectoryS.Color = Color.Black;

            for (int i = 0; i < ESx.Count; i++)
            {
                //Console.WriteLine(m1x[i] + " " + m1y[i]);
                trajectoryS.Points.AddXY(ESx[i], ESy[i]);

            }

            var EecS = euler2.Ec;
            var EekS = euler2.Ek;
            var EepS = euler2.Ep;
            var EtS = euler2.T;

            Series EulerEcS = new Series();
            EulerEcS.Name = "Ec";
            BetterEulerEnergie.Series.Add(EulerEcS);

            EulerEcS.ChartType = SeriesChartType.Line;
            EulerEcS.BorderWidth = 1;
            EulerEcS.Color = Color.Blue;

            Series EulerEkS = new Series();
            EulerEkS.Name = "Ek";
            BetterEulerEnergie.Series.Add(EulerEkS);

            EulerEkS.ChartType = SeriesChartType.Line;
            EulerEkS.BorderWidth = 1;
            EulerEkS.Color = Color.Red;

            Series EulerEpS = new Series();
            EulerEpS.Name = "Ep";
            BetterEulerEnergie.Series.Add(EulerEpS);

            EulerEpS.ChartType = SeriesChartType.Line;
            EulerEpS.BorderWidth = 1;
            EulerEpS.Color = Color.Green;

            for (int i = 0; i < EecS.Count; i++)
            {
                //Console.WriteLine(EecS[i]);
                EulerEcS.Points.AddXY(EtS[i], EecS[i]);
                EulerEkS.Points.AddXY(EtS[i], EekS[i]);
                EulerEpS.Points.AddXY(EtS[i], EepS[i]);
            }

            //==============================Energies comparison

            EnergiesComparison.Series.Clear();
            ChartArea EnComp = new ChartArea();
            EnergiesComparison.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            EnergiesComparison.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;
            
            
            Series Eck = new Series();
            Eck.Name = "Ec kula";
            EnergiesComparison.Series.Add(Eck);

            Eck.ChartType = SeriesChartType.Point;
            Eck.BorderWidth = 1;
            Eck.Color = Color.Blue;

            Series EcS2 = new Series();
            EcS2.Name = "Ec sfera";
            EnergiesComparison.Series.Add(EcS2);

            EcS2.ChartType = SeriesChartType.Point;
            EcS2.BorderWidth = 1;
            EcS2.Color = Color.Red;

            for (int i = 0; i < EecS.Count; i++)
            {
                //Console.WriteLine(EecS[i]);
                EcS2.Points.AddXY(EtS[i], EecS[i]);
                
            }

            for (int i = 0; i < Eec.Count; i++)
            {
                //Console.WriteLine(EecS[i]);
                Eck.Points.AddXY(Et[i], Eec[i]);
                
            }
        }
    }
}
