import java.util.*;

public class App {
    public static void main(String[] args) {
        
        Student ogr1 = new Student();
        ogr1.adi = "abdullah"; ogr1.soyadi = "sahin"; ogr1.yas = 19;
        Student ogr2 = new Student();
        ogr2.adi = "nuri can"; ogr2.soyadi = "acar"; ogr2.yas = 19;
        Student ogr3 = new Student();
        ogr3.adi = "jabir"; ogr3.soyadi = "vefai"; ogr3.yas = 19;
        Student ogr4 = new Student();
        ogr4.adi = "melih"; ogr4.soyadi = "artar"; ogr4.yas = 19;

        HashMap <Integer, Student> sinif = new HashMap<>();
        
        sinif.put(21060622, ogr1);
        sinif.put(21060666, ogr2);
        sinif.put(21060129, ogr3);
        sinif.put(21060688, ogr4);

        Scanner numaraAl = new Scanner(System.in);

        while (true) {
            System.out.println("ogrenci numarasi giriniz ");
            int numara = numaraAl.nextInt();
            System.out.println("Ad: " + ((sinif.get(numara)).adi)+ " Soyad: " +((sinif.get(numara)).soyadi)+ " No: " +((sinif.get(numara)).yas));
        }
    }
}