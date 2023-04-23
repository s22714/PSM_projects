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

namespace PSM6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LPick.Value = Convert.ToDecimal(Math.PI);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            EulerString.Series.Clear();
            EulerEnergy.Series.Clear();
            BetterEulerString.Series.Clear();
            BetterEulerEnergy.Series.Clear();

            EulerString.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            EulerString.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;
            EulerEnergy.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            EulerEnergy.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;
            BetterEulerString.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            BetterEulerString.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;
            BetterEulerEnergy.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            BetterEulerEnergy.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;

            double L = Convert.ToDouble(LPick.Value);
            double n = Convert.ToDouble(NPick.Value);
            double dt = Convert.ToDouble(DtPick.Value);
            int lPow = Convert.ToInt32(LpowPick.Value);

            EulerString eulerString = new EulerString(L, n, dt, lPow);
            
            foreach(var l in eulerString.F)
            {
                Series s = new Series();
                EulerString.Series.Add(s);

                s.ChartType = SeriesChartType.Line;
                s.BorderWidth = 1;

                for(int i = 0; i < l.Count; i++)
                {
                    s.Points.AddXY(i, l[i]);
                }

            }

            Series sEp = new Series();
            sEp.Name = "Ep";
            EulerEnergy.Series.Add(sEp);

            sEp.ChartType = SeriesChartType.Line;
            sEp.BorderWidth = 1;

            Series sEk = new Series();
            sEk.Name = "Ek";
            EulerEnergy.Series.Add(sEk);

            sEk.ChartType = SeriesChartType.Line;
            sEk.BorderWidth = 1;

            Series sEc = new Series();
            sEc.Name = "Ec";
            EulerEnergy.Series.Add(sEc);

            sEc.ChartType = SeriesChartType.Line;
            sEc.BorderWidth = 1;

            for (int i = 0; i < eulerString.Ec.Count; i++)
            {
                sEp.Points.AddXY(eulerString.T[i], eulerString.Ep[i]);
                sEk.Points.AddXY(eulerString.T[i], eulerString.Ek[i]);
                sEc.Points.AddXY(eulerString.T[i], eulerString.Ec[i]);
            }

            BetterEulerString betterEulerString = new BetterEulerString(L, n, dt, lPow);

            foreach (var l in betterEulerString.F)
            {
                Series d = new Series();
                BetterEulerString.Series.Add(d);

                d.ChartType = SeriesChartType.Line;
                d.BorderWidth = 1;

                for (int i = 0; i < l.Count; i++)
                {
                    d.Points.AddXY(i, l[i]);
                }

            }

            Series bsEp = new Series();
            bsEp.Name = "Ep";
            BetterEulerEnergy.Series.Add(bsEp);

            bsEp.ChartType = SeriesChartType.Line;
            bsEp.BorderWidth = 1;

            Series bsEk = new Series();
            bsEk.Name = "Ek";
            BetterEulerEnergy.Series.Add(bsEk);

            bsEk.ChartType = SeriesChartType.Line;
            bsEk.BorderWidth = 1;

            Series bsEc = new Series();
            bsEc.Name = "Ec";
            BetterEulerEnergy.Series.Add(bsEc);

            bsEc.ChartType = SeriesChartType.Line;
            bsEc.BorderWidth = 1;

            for (int i = 0; i < betterEulerString.Ec.Count; i++)
            {
                bsEp.Points.AddXY(betterEulerString.T[i], betterEulerString.Ep[i]);
                bsEk.Points.AddXY(betterEulerString.T[i], betterEulerString.Ek[i]);
                bsEc.Points.AddXY(betterEulerString.T[i], betterEulerString.Ec[i]);
            }
        }
    }
}
