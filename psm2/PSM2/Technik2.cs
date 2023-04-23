using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSM2
{
    internal class Technik2
    {
        public List<Double> x { get; set; }
        public List<Double> y { get; set; }
        public Technik2(double dt, double gx, double gy, double m, double q, double Vx, double Vy, double Sx, double Sy)
        {
            this.x = new List<Double>();
            this.y = new List<Double>();

            //double Sx = 0;
            //double Sy = 0;
            //double Vx = 10;
            //double Vy = 10;

            double ax;
            double ay;

            double ax2;
            double ay2;

            double Vx2;
            double Vy2;

            double DSx;
            double DSy;
            double DVx;
            double DVy;

            while(Sy >= 0)
            {
                this.x.Add(Sx);
                this.y.Add(Sy);

                ax = (m * gx - q * Vx) / m;
                ay =  (m * gy - q * Vy) / m;


                Vx2 = Vx + ax * (dt / 2);
                Vy2 = Vy + ay * (dt / 2);

                ax2 = (m * gx - q * Vx2) / m;
                ay2 = (m * gy - q * Vy2) / m;

                DVx = ax2 * dt;
                DVy = ay2 * dt;

                DSx = Vx2 * dt;
                DSy = Vy2 * dt;

                Vx += DVx;
                Vy += DVy;

                Sx += DSx;
                Sy += DSy;

                /*
                Console.WriteLine("Sx " + Sx 
                    + " Sy " + Sy 
                    + " Vx " + Vx 
                    + " Vy " + Vy
                    + " ax " + ax
                    + " ay " + ay
                    + " ax2 " + ax2
                    + " ay2 " + ay2);
                */

            }
        }
    }
}
