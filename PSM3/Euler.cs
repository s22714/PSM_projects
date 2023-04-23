using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSM3
{
    public class Euler
    {
        public List<double> X { get; set; }
        public List<double> Y { get; set; }
        public List<double> Alpha { get; set; }
        public List<double> Omega { get; set; }
        public List<double> Ep { get; set; }
        public List<double> Ek { get; set; }
        public List<double> Ec { get; set; }
        public List<double> T { get; set; }

        public Euler(double dt, double g, double l, double m, double timer) 
        {
            this.X = new List<double>();
            this.Y = new List<double>();
            this.Alpha = new List<double>();
            this.Omega = new List<double>();
            this.Ep = new List<double>();
            this.Ek = new List<double>();
            this.Ec = new List<double>();
            this.T = new List<double>();

            double alpha = (45*Math.PI)/180;
            double omega = 0;
            double epsilon = (g / l)*Math.Sin(alpha);

            double Dalpha = omega * dt;
            double Domega = epsilon * dt;
            
            double x = l * Math.Cos(alpha - ((90 * Math.PI) / 180));
            double y = l * Math.Sin(alpha - ((90 * Math.PI) / 180));

            double h = y + l;
            double V = l * omega;

            double ep = Math.Abs(m*g*h);
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

            while(t <= timer)
            {
                t += dt;
                alpha += Dalpha;
                omega += Domega;
                epsilon = (g / l) * Math.Sin(alpha);

                Dalpha = omega * dt;
                Domega = epsilon * dt;

                ep = Math.Abs(m * g * h);
                ek = m * Math.Pow(V, 2) / 2;
                ec = ep + ek;

                x = l * Math.Cos(alpha - ((90 * Math.PI) / 180));
                y = l * Math.Sin(alpha - ((90 * Math.PI) / 180));

                h = y + l;
                V = l * omega;

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
