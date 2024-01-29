public class App {
    public static void main(String[] args) throws Exception {
        String metin = "Bugun hava cok guzel.";
        String metin2 = "   Bugun hava cok guzel.    ";
        System.out.println(metin);
        //System.out.println("eleman sayisi:"+ metin.length());
        //System.out.println("5. eleman:"+ metin.charAt//(4));
        //System.out.println(metin.concat(" yasasin"));
        //System.out.println(metin);
        //System.out.println(metin.startsWith("b"));
        //System.out.println(metin.endsWith(","));
        //char[] karakter = new char[5];
        //metin.getChars(0, 5, karakter, //0);
        //System.out.println(karakter);
        //System.out.println(metin.indexOf("a"));
        //System.out.println(metin.lastIndexOf("a"));
        String yenimetin = metin.replace(" ", "-");
        System.out.println(metin.replace(" ", "-"));
        System.out.println(yenimetin);
        System.out.println(metin.substring(2));
        System.out.println(metin.substring(2,5));

        for (String kelime : metin.split(" ")) {
            System.out.println(kelime);
            
        }

        System.out.println(metin.toLowerCase());
        System.out.println(metin.toUpperCase());
        System.out.println(metin2.trim());

    }
}
