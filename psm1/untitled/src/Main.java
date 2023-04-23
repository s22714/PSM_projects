public class Main {
    public static void main(String[] args) {

        double val = 2342.2323;
        String jed = "deg";

        sin(val, jed);
    }

    public static void sin(double x, String type){

        if(type.contains("deg")){
            System.out.println("Wartość podana w stopniach -> " + x);
            x = Math.toRadians(x);
        }

        System.out.println("Wartość podana w radianach -> " + x);
        x = x % (2 * Math.PI);
        System.out.println("Wartość sprowadzona do przedziału 0...2PI -> " + x);

        if(x >= Math.PI/2 && x <= Math.PI){
            x = Math.PI - x;
        } else if (x >= Math.PI && x <= Math.PI*(3.0/2.0)) {
            x = x - Math.PI;
            x *= -1;
        } else if (x >= Math.PI*(3.0/2.0) && x <= Math.PI*2) {
            x = 2*Math.PI - x;
            x *= -1;
        }

        System.out.println("Wartość gotowa -> " + x);
        double sum = 0;
        int pow = 1;

        for (int i = 1; i <= 10; i++){
            System.out.print("pętla " + i + ": ");
            if(i % 2 == 1){
                sum += Math.pow(x,pow)/factorial(pow);
            }
            else {
                sum -= Math.pow(x,pow)/factorial(pow);
            }
            System.out.print(sum + " - " + Math.sin(x) + " = " + Math.abs(sum-Math.sin(x)));
            System.out.println("");
            pow+=2;
        }

    }

    public static int factorial(int num){
        int result = 1;
        for(int i = 1; i <= num; i++){
            result = result * i;
        }
        return result;
    }
}