import java.util.*;

public class App {
    public static void main(String[] args) throws Exception {
        LinkedList <String> java = new LinkedList<String>();
        java.addFirst("java1");
        java.addFirst("java2");
        java.addFirst("java3");
        while (!java.isEmpty()) {
            System.out.println("kuyruk = "+java.removeLast());
        }
    }
}
