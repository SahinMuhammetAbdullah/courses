public class LongDistanceCalculator implements BaseMarticCalculator {

    public double DistanceCalculator(double a) {
        double x;
        x = startFee();

        double t;
        t = 2.20;

        double b;
        b = (a*t) + x;

        return b;
    }

    @Override
    public double startFee() {

        return 10;
    }

}