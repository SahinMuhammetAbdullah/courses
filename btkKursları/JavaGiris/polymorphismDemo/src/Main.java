public class Main {
    public static void main(String[] args) throws Exception {
        //EmainLogger logger = new EmainLogger();
        //logger.log("log mesaj");

        //BaseLogger[] loggers =  new BaseLogger[] {new FileLogger(), new EmainLogger(), new DataBaseLogger(), new ConsoleLogger()};

        //for (BaseLogger baseLogger : loggers) {
        //    baseLogger.log("log massage");
        //}

        CustomerManager customerManager = new CustomerManager(new DataBaseLogger());
        customerManager.add();
    }
}
