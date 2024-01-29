public class App {
    public static void main(String[] args) throws Exception {
        //double[] myList = new double[4];
        double[] myList = {1.2, 3.4, 4.5, 3.6};
        double total = 0;
        double max = myList[0];
        for (double number:myList) {
            if (max < number) {
                max = number;
                
            }
            total = total + number;
            System.out.println(number);                        
        }

        System.out.println("toplam = "+ total);
        System.out.println("en buyuk = "+ max);
    }
}
