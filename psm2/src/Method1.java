import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.io.UnsupportedEncodingException;

public class Method1 {

    public Method1(double dt, double gx, double gy, double m, double q){

        double Sx0 = 0;
        double Sy0 = 0;
        double Vx0 = 10;
        double Vy0 = 10;

        double Sx = 0;
        double Sy = 0;
        double Vx = 10;
        double Vy = 10;

        double ax = 0;
        double ay = 0;

        double DSx = 0;
        double DSy = 0;
        double DVx = 0;
        double DVy = 0;

        try {
            PrintWriter writer = new PrintWriter("method1.txt","UTF-8");


            do {

                ax = (m * gx - q * Vx) / m;
                ay = (m * gy - q * Vy) / m;

                DSx = dt * Vx;
                DSy = dt * Vy;
                DVx = ax * dt;
                DVy = ay * dt;

                System.out.println("Sx " + Sx);
                System.out.println("Sy " + Sy);
                System.out.println("Vx " + Vx);
                System.out.println("Vy " + Vy);
                System.out.println("ax " + ax);
                System.out.println("ay " + ay);
                System.out.println("DSx " + DSx);
                System.out.println("DSy " + DSy);
                System.out.println("DVx " + DVx);
                System.out.println("DVy " + DVy);
                System.out.println();

                writer.println(Sx+";"
                        +Sy+";"
                        /*+Vx+";"
                        +Vy+";"
                        +ax+";"
                        +ay+";"
                        +DSx+";"
                        +DSy+";"
                        +DVx+";"
                        +DVy*/);

                Sx = Sx + DSx;
                Sy = Sy + DSy;
                Vx = Vx + DVx;
                Vy = Vy + DVy;

            }while (Sy >= 0);

            writer.close();

        } catch (FileNotFoundException | UnsupportedEncodingException e) {
            throw new RuntimeException(e);
        }
    }
}
