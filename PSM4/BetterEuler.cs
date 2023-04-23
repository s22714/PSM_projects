using System;
using System.Collections.Generic;

namespace PSM4
{
    public class BetterEuler
    {
        public List<double> X { get; set; }
        public List<double> Y { get; set; }
        public List<double> Xsm_r { get; set; }
        public List<double> Ysm_r { get; set; }
        public List<double> Ep { get; set; }
        public List<double> Ek { get; set; }
        public List<double> Ec { get; set; }
        public List<double> T { get; set; }

        public BetterEuler(double h, double dt, double r, double m, double g, double alpha, double l)
        {
            this.X = new List<double>();
            this.Y = new List<double>();
            this.Xsm_r = new List<double>();
            this.Ysm_r = new List<double>();
            this.Ep = new List<double>();
            this.Ek = new List<double>();
            this.Ec = new List<double>();
            this.T = new List<double>();

            double t = 0;
            double acc = g * Math.Sin(alpha) / (1 + l / (m * Math.Pow(r, 2)));
            double eps = acc / r;
            double d90 = (90 * Math.PI) / 180;

            double Sx = 0;
            double Sy = r;
            double V = 0;
            double V2 = V + acc * (dt / 2);

            double DSx = V2 * dt;
            double DV = acc * dt;

            double xsm_r = Sx * Math.Cos(-alpha) - Sy * Math.Sin(-alpha);
            double ysm_r = Sx * Math.Sin(-alpha) + Sy * Math.Cos(-alpha) + h;

            double b = 0;
            double w = 0;
            double w2 = w + eps * (dt / 2);
            double Db = w2 * dt;
            double Dw = eps * dt;

            double x = r * Math.Cos(d90 - b) + xsm_r;
            double y = r * Math.Sin(d90 - b) + ysm_r;

            double h2 = ysm_r - r;
            double Ep = m * g * h2;
            double Ek = m * Math.Pow(V, 2) / 2 + l * Math.Pow(w, 2) / 2;
            double Ec = Ep + Ek;

            this.X.Add(x);
            this.Y.Add(y);
            this.Ep.Add(Ep);
            this.Ec.Add(Ec);
            this.Ek.Add(Ek);
            this.Xsm_r.Add(xsm_r);
            this.Ysm_r.Add(ysm_r);
            this.T.Add(t);

            while(ysm_r >= r)
            {
                
                t += dt;
                
                Sx = Sx + DSx;
                V = V + DV;
                V2 = V + acc * (dt / 2);
                DSx = V2 * dt;
                DV = acc * dt;

                xsm_r = Sx * Math.Cos(-alpha) - Sy * Math.Sin(-alpha);
                ysm_r = Sx * Math.Sin(-alpha) + Sy * Math.Cos(-alpha) + h;

                b = b + Db;
                w = w + Dw;
                w2 = w + eps * (dt / 2);
                Db = w2 * dt;
                Dw = eps * dt;

                x = r * Math.Cos(d90 - b) + xsm_r;
                y = r * Math.Sin(d90 - b) + ysm_r;

                h2 = ysm_r - r;
                Ep = m * g * h2;
                Ek = m * Math.Pow(V, 2) / 2 + l * Math.Pow(w, 2) / 2;
                Ec = Ep + Ek;

                this.X.Add(x);
                this.Y.Add(y);
                this.Ep.Add(Ep);
                this.Ec.Add(Ec);
                this.Ek.Add(Ek);
                this.Xsm_r.Add(xsm_r);
                this.Ysm_r.Add(ysm_r);
                this.T.Add(t);
            }
            
        }
    }
}
