using System;
using System.Collections.Generic;

namespace PSM5
{
    public class Planet
    {
        public List<double> Sx { get; set; }
        public List<double> Sy { get; set; }
        public Planet(double G, double M, double R, double all_dt) 
        {
            this.Sx = new List<double>();
            this.Sy = new List<double>();

            double dt = 100;

            double V0 = Math.Sqrt(G * M / R);

            double t = 0;
            double Sx = 0;
            double Sy = R;
            double Wx = -Sx;
            double Wy = -Sy;
            double W_len = Math.Sqrt(Math.Pow(Wx, 2) + Math.Pow(Wy, 2));
            double Ux = Wx / W_len;
            double Uy = Wy / W_len;
            double A = G * M / Math.Pow(W_len, 2);
            double Ax = A * Ux;
            double Ay = A * Uy;
            double Vx = V0;
            double Vy = 0;
            double Vx_2 = Vx + Ax * (dt / 2);
            double Vy_2 = Vy + Ay * (dt / 2);
            double DSx = Vx_2 * dt;
            double DSy = Vy_2 * dt;
            double Sx_2 = Sx + Vx * (dt / 2);
            double Sy_2 = Sy + Ay * (dt / 2);
            double Wx_2 = -Sx_2;
            double Wy_2 = -Sy_2;
            double W_2_len = Math.Sqrt(Math.Pow(Wx_2, 2) + Math.Pow(Wy_2, 2));
            double Ux_2 = Wx_2 / W_2_len;
            double Uy_2 = Wy_2 / W_2_len;
            double A_2 = G * M / Math.Pow(W_2_len, 2);
            double Ax_2 = A_2 * Ux_2;
            double Ay_2 = A_2 * Uy_2;
            double DVx = Ax_2 * dt;
            double DVy = Ay_2 * dt;

            this.Sx.Add(Sx);
            this.Sy.Add(Sy);

            while (t <= all_dt)
            {
                Console.WriteLine($"Sx {Sx} | Sy {Sy}");
                t += dt;
                Sx = Sx + DSx;
                Sy = Sy + DSy;
                Wx = -Sx;
                Wy = -Sy;
                W_len = Math.Sqrt(Math.Pow(Wx, 2) + Math.Pow(Wy, 2));
                Ux = Wx / W_len;
                Uy = Wy / W_len;
                A = G * M / Math.Pow(W_len, 2);
                Ax = A * Ux;
                Ay = A * Uy;
                Vx = Vx + DVx;
                Vy = Vy + DVy;
                Vx_2 = Vx + Ax * (dt / 2);
                Vy_2 = Vy + Ay * (dt / 2);
                DSx = Vx_2 * dt;
                DSy = Vy_2 * dt;
                Sx_2 = Sx + Vx * (dt / 2);
                Sy_2 = Sy + Ay * (dt / 2);
                Wx_2 = -Sx_2;
                Wy_2 = -Sy_2;
                W_2_len = Math.Sqrt(Math.Pow(Wx_2, 2) + Math.Pow(Wy_2, 2));
                Ux_2 = Wx_2 / W_2_len;
                Uy_2 = Wy_2 / W_2_len;
                A_2 = G * M / Math.Pow(W_2_len, 2);
                Ax_2 = A_2 * Ux_2;
                Ay_2 = A_2 * Uy_2;
                DVx = Ax_2 * dt;
                DVy = Ay_2 * dt;

                this.Sx.Add(Sx);
                this.Sy.Add(Sy);
            }
        }
    }
}
