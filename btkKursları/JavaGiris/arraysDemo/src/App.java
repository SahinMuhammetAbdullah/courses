public class App {
    public static void main(String[] args) throws Exception {
        String ogrenci1 = "abdullah";
        String ogrenci2 = "sali";
        String ogrenci3 = "samet";

        System.out.println(ogrenci1);
        System.out.println(ogrenci2);
        System.out.println(ogrenci3);

        System.out.println("-------------");
        
        String[] ogrenciler = new String[3];
        ogrenciler[0] = "engin";
        ogrenciler[1] = "salih";
        ogrenciler[2] = "samet";

        for (int i = 0; i < ogrenciler.length; i++) {
            System.out.println(ogrenciler[i]);
        }
        System.out.println("-------------");

        for (String ogrenci:ogrenciler){
            System.out.println(ogrenci);
        }

    }
}
