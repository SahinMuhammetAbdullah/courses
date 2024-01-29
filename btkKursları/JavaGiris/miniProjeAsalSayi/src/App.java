public class App {
    public static void main(String[] args) {
        /*int sayi = 2 ;
        if (sayi%2 != 0 && sayi%3 != 0 && sayi%5 != 0 && sayi%7 != 0 && sayi%11 != 0 ) {
            System.out.println(sayi + " " + "sayisi asal");
        }
        else{
            System.out.println(sayi + " " + "sayisi asal degil");
        }*/

        int number = 5;
        boolean isPrime = true;

        if (number == 1) {
            System.out.println(number + " " + "sayi asal degil");
            return;
        }

        if (number<1) {
            System.out.println(number + " " + "gecersiz sayi");
            return;
        }

        for (int i = 2; i < number; i++) {
            if (number % i == 0) {
                isPrime = false;
            }
        }
        if (isPrime) {
            System.out.println(number + " " + "sayi asal");
        } else {
            System.out.println(number + " " + "sayi asal");
        }
    }
}
