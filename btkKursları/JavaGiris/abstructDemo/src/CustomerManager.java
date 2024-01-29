public class CustomerManager {
    BaseDatabaseManager databaseManager;

    public void getCustomers() {
        databaseManager.getData();
        //OracleDatabaseManager oracleDatabaseManager = new OracleDatabaseManager();
        //oracleDatabaseManager.getData(); //hatali kullanim
    }
}
