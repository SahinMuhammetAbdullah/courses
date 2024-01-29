public class App {
    public static void main(String[] args) throws Exception {
        //for
        for (int i = 1; i < 10; i++) {
            System.out.println(i);
            
        }
        for (int i = 1; i < 10; i+=2) {
            System.out.println(i);
            
        }

        //while
        int i = 1;
        while (i<10) {
            System.out.println(i);
            i++;
        }
        System.out.println("While dongusu bitti");
        
        // do whlie dongusu
        int j = 1;
        do {
            System.out.println(j);
            j++;
        } while (i<10);
        System.out.println("Do While dongusu bitti");
    }
}
