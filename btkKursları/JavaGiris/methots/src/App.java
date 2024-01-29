public class App {
    public static void main(String[] args) throws Exception {
        sayiBulmaca();
    }

    public static void sayiBulmaca() {
        int [] sayilar =  new int [] {1,2,5,7,9,0};
        int aranan = 5;
        boolean varMi = false;

        for (int sayi : sayilar) {
            if (sayi == aranan) {
                varMi = true;
                break;
            }
        }

        if (varMi) {
            System.out.println("Sayi "+ aranan+ " var");
        }
        else {
            System.out.println("Sayi "+ aranan+ " yok");
        }
        
    }
}
