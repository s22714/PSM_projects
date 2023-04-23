using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSM2
{
    public class Technik1
    {

        public List<Double> x { get; set; }
        public List<Double> y { get; set; }
        public Technik1(double dt, double gx, double gy, double m, double q, double Vx, double Vy, double Sx, double Sy)
        {

            this.x = new List<Double>();
            this.y = new List<Double>();

            //double Sx = 0;
            //double Sy = 0;
            //double Vx = 10;
            //double Vy = 10;

            double ax;
            double ay;

            double DSx;
            double DSy;
            double DVx;
            double DVy;

            while (Sy >= 0)
            {
                ax = (m * gx - q * Vx) / m;
                ay = (m * gy - q * Vy) / m;

                DSx = dt * Vx;
                DSy = dt * Vy;
                DVx = ax * dt;
                DVy = ay * dt;

                this.x.Add(Sx);
                this.y.Add(Sy);

                Sx += DSx;
                Sy += DSy;
                Vx += DVx;
                Vy += DVy;

            } 

            
        }

    }
}
