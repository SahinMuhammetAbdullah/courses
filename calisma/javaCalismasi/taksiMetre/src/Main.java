import java.util.*;

public class Main {
    public static void main(String[] args) throws Exception {
        LongDistanceCalculator longDistanceCalculator = new LongDistanceCalculator();
        ShortDistanceCalculator shortDistanceCalculator = new ShortDistanceCalculator();

        Scanner veri = new Scanner(System.in);
        System.out.print("km giriniz: ");
        double km = veri.nextDouble();
        double tutar;

        if (km > 0 && km <= 15) {
            tutar = shortDistanceCalculator.DistanceFee();

            System.out.println("Toplam ucret: " + tutar);
        }
        else if (km > 15) {
            tutar = longDistanceCalculator.DistanceCalculator(km);
            System.out.println("Toplam ucret: " + tutar);

        }
        else 
            System.out.println("yanlis uzunluk birimi");
    }
}
