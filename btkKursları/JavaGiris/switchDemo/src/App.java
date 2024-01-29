public class App {
    public static void main(String[] args) throws Exception {
        char grade = 'D';
        
        switch (grade) {
            case 'A':
                System.out.println("mukemmel : gecdin");
                break;
            case 'B':
                System.err.println("cok guzel : gectin");
                break;
            case 'C':
                System.out.println("iyi : gectin");
                break;
            case 'D':
                System.out.println("kotu : kaldin");
                break;
            case 'F':
                System.out.println("cok kotu : kaldin");
                break;
            default:
                System.out.println("gecersiz not girdiniz");
                break;
        }

    }
}
