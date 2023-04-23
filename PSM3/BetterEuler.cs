using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSM3
{
    internal class BetterEuler
    {
        public List<double> X { get; set; }
        public List<double> Y { get; set; }
        public List<double> Alpha { get; set; }
        public List<double> Omega { get; set; }
        public List<double> Ep { get; set; }
        public List<double> Ek { get; set; }
        public List<double> Ec { get; set; }
        public List<double> T { get; set; }

        public BetterEuler(double dt, double g, double l, double m, double timer)
        {
            this.X = new List<double>();
            this.Y = new List<double>();
            this.Alpha = new List<double>();
            this.Omega = new List<double>();
            this.Ep = new List<double>();
            this.Ek = new List<double>();
            this.Ec = new List<double>();
            this.T = new List<double>();

            double alpha = (45 * Math.PI) / 180;
            double omega = 0;
            double Epsilon = (g / l) * Math.Sin(alpha);

            double omega2 = omega + Epsilon * (dt / 2);
            double alpha2 = alpha + omega * (dt / 2);
            double epsilon2 = (g / l) * Math.Sin(alpha2);

            double x = l * Math.Cos(alpha - ((90 * Math.PI) / 180));
            double y = l * Math.Sin(alpha - ((90 * Math.PI) / 180));

            double h = y + l;
            double V = l * omega;

            double ep = Math.Abs(m * g * h);
            double ek = m * Math.Pow(V, 2) / 2;
            double ec = ep + ek;

            double t = 0;

            this.X.Add(x);
            this.Y.Add(y);
            this.Alpha.Add(alpha);
            this.Omega.Add(omega);
            this.Ep.Add(ep);
            this.Ec.Add(ec);
            this.Ek.Add(ek);
            this.T.Add(t);

            while (t <= timer)
            {
                t += dt;
                alpha2 = alpha + omega * (dt / 2);
                epsilon2 = (g / l) * Math.Sin(alpha2);
                omega = omega + epsilon2 * dt;
                Epsilon = (g / l) * Math.Sin(alpha);
                omega2 = omega + Epsilon * (dt / 2);
                alpha = alpha + omega2 * dt;

                x = l * Math.Cos(alpha - ((90 * Math.PI) / 180));
                y = l * Math.Sin(alpha - ((90 * Math.PI) / 180));

                h = y + l;
                V = l * omega;

                ep = Math.Abs(m * g * h);
                ek = m * Math.Pow(V, 2) / 2;
                ec = ep + ek;

                this.X.Add(x);
                this.Y.Add(y);
                this.Alpha.Add(alpha);
                this.Omega.Add(omega);
                this.Ep.Add(ep);
                this.Ec.Add(ec);
                this.Ek.Add(ek);
                this.T.Add(t);
                //Console.WriteLine(t);
                
            }
        }
    }
}
