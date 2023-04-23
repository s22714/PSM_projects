using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSM6
{
    public class EulerString
    {
        public List<List<double>> F { get; set; }
        public List<double> Ek { get; set; }
        public List<double> Ep { get; set; }
        public List<double> Ec { get; set; }
        public List<double> T { get; set; }
        public EulerString(double L, double n, double dt, double lPow) 
        {
            this.F = new List<List<double>>();
            this.Ek = new List<double>();
            this.Ep = new List<double>();
            this.Ec = new List<double>();
            this.T = new List<double>();

            double dx = L / n;
            double mi = L / n;

            List<double> xi = new List<double>
            {
                0
            };
            for (int i = 0; i <= n; i++)
            {
                xi.Add(xi[i] + dx);
                //Console.Write(xi[i] + " | ");
            }
            //Console.WriteLine();

            List<double> f = new List<double>
            {
                0
            };
            for (int i = 1; i < n; i++)
            {
                f.Add(Math.Sin(xi[i])/100000);
                //Console.Write(f[i] + " | ");
            }
            f.Add(0);
            //Console.WriteLine();

            List<double> v = new List<double>();
            for (int i = 0; i <= n; i++)
            {
                v.Add(0);
                //Console.Write(v[i] + " | ");
            }
            //Console.WriteLine();

            List<double> a = new List<double>
            {
                0
            };
            for (int i = 1; i < n; i++)
            {
                a.Add((f[i + 1] - 2 * f[i] + f[i-1])/Math.Pow(dx,2));
                //Console.Write(a[i] + " | ");
            }
            a.Add(0);
            //Console.WriteLine();

            this.F.Add(f);
            double Ek = 0;
            foreach(var i in v)
            {
                Ek += Math.Pow(i, 2);
            }
            Ek = (mi / 2) * Ek;
            this.Ek.Add(Ek);

            double Ep = 0;
            for(int i = 1 ; i < f.Count; i++)
            {
                Ep += Math.Pow(f[i] - f[i - 1], 2);
            }
            Ep = 1 / (2 * dx) * Ep;
            this.Ep.Add(Ep);
            this.Ec.Add(Ep + Ek);
            double t = dt;
            this.T.Add(t);

            for(int i = 1; i < lPow; i++)
            {
                var newf = new List<double>
                {
                    0
                };
                for (int j = 1; j < n; j++)
                {
                    newf.Add(f[j] + (v[j] * dt));
                    //Console.Write(newf[j] + " | ");
                }
                newf.Add(0);
                //Console.WriteLine();

                var newv = new List<double>
                {
                    0
                };
                for (int j = 1; j < n; j++)
                {
                    newv.Add(v[j] + (a[j] * dt));
                    //Console.Write(newv[j] + " | ");
                }
                newv.Add(0);
                //Console.WriteLine();

                var newa = new List<double>
                {
                    0
                };
                for (int j = 1; j < n; j++)
                {
                    newa.Add((newf[j + 1] - 2 * newf[j] + newf[j - 1]) / Math.Pow(dx, 2));
                    //Console.Write(newa[j] + " | ");
                }
                newa.Add(0);
               //Console.WriteLine();

                this.F.Add(newf);

                f = newf;
                v = newv;
                a = newa;

                Ek = 0;
                foreach (var j in v)
                {
                    Ek += Math.Pow(j, 2);
                }
                Ek = (mi / 2) * Ek;
                this.Ek.Add(Ek);

                Ep = 0;
                for (int j = 1; j < f.Count; j++)
                {
                    Ep += Math.Pow(f[j] - f[j - 1], 2);
                }
                Ep = 1 / (2 * dx) * Ep;
                this.Ep.Add(Ep);
                this.Ec.Add((Ep + Ek));
                t += dt;
                this.T.Add(t);
            }
        }
    }
}
