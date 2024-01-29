public class App {
    public static void main(String[] args) throws Exception {
        //String mesaj = "bugun hava cok guzel";
        String yeniMesaj = sehir(); 
        System.out.println(yeniMesaj);
        int sayi = topla(15,5);
        System.out.println(sayi);
        int sayi2 = topla2(1,2,3,4,5,6,7,8,9);
        System.out.println(sayi2);
    }

    public static void ekle() {
        System.out.println("eklendi");
    }

    public static void sil() {
        System.out.println("silindi");
    }

    public static void guncelle() {
        System.out.println("guncellendi");
    }

    public static int topla(int sayi1 , int sayi2) {
        return sayi1 + sayi2;
    }

    public static int topla2(int... sayilar) {
        int toplam = 0;
        for (int sayi : sayilar) {
            toplam += sayi;
        }
        return toplam;        
    }

    public static String sehir() {
        return "ankara";
    }
}
