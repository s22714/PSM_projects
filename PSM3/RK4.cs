using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSM3
{
    internal class RK4
    {
        public List<double> X { get; set; }
        public List<double> Y { get; set; }
        public List<double> Alpha { get; set; }
        public List<double> Omega { get; set; }
        public List<double> Ep { get; set; }
        public List<double> Ek { get; set; }
        public List<double> Ec { get; set; }
        public List<double> T { get; set; }
        public double G { get; set; }
        public double L { get; set; }
        public double Dt { get; set; }

        public RK4(double dt, double g, double l, double m, double timer)
        {
            this.X = new List<double>();
            this.Y = new List<double>();
            this.Alpha = new List<double>();
            this.Omega = new List<double>();
            this.Ep = new List<double>();
            this.Ek = new List<double>();
            this.Ec = new List<double>();
            this.T = new List<double>();

            this.G = g;
            this.L = l;
            this.Dt = dt;

            double alpha = (45 * Math.PI) / 180;
            double omega = 0;

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

                var K1 = PP(alpha, omega);
                var K11 = RE(K1[0], K1[1], alpha, omega, dt/2);
                var K2 = PP(K11[0], K11[1]);
                var K22 = RE(K1[0], K1[1], alpha, omega, dt / 2);
                var K3 = PP(K22[0], K22[1]);
                var K33 = RE(K3[0], K3[1], alpha, omega, dt);
                var K4 = PP(K33[0], K33[1]);

                alpha = alpha + ((K1[0] + 2 * K2[0] + 2 * K3[0] + K4[0]) / 6) * dt;
                omega = omega + ((K1[1] + 2 * K2[1] + 2 * K3[1] + K4[1]) / 6) * dt;

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

        public List<double> PP(double alpha, double omega)
        {
            List<double> res = new List<double>();
            res.Add(omega);
            res.Add((this.G/this.L)*Math.Sin(alpha));

            return res;
        }

        public List<double> RE(double alpha, double omega, double alpha0, double omega0, double resT)
        {
            List<double> res = new List<double>();
            res.Add(alpha0 + alpha * resT);
            res.Add(omega0 + omega * resT);

            return res;
        }
    }
}
