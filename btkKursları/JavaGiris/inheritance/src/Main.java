public class Main {
    public static void main(String[] args) throws Exception {
        Customer customer = new Customer();
        Employee employee = new Employee();

        EmployeeManager employeeManager = new EmployeeManager();
        CustomerManager customerManager = new CustomerManager();

        customerManager.Liste();
    }
}
