import java.util.*;

public class App {
    public static void main(String[] args) {
        HashMap <Integer, String> hm = new HashMap<>();

        Object sehir[][] = {{06, "ankara"}, {55, "samsun"}};

        for (int i = 0; i < sehir.length; i++) {
            hm.put((Integer)sehir[i][0], (String)sehir[i][1]);
        }

        System.out.println("ilgili eleman = "+ hm.get(06));
    }
}