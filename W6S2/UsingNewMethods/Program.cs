class Program
{
    public static void Main()
    {
        Employee employee = new Employee("John", "Doe", "john.doe@example.com");
        Manager manager = new Manager("Jane", "Doe", "jane.doe@example.com", "Sales");
        SalesPerson salesp = new SalesPerson("Bob", "Smith", "bob.smith@example.com", 100000);
    	

        employee.PrintEmployeeInfo();
        ((Employee)manager).PrintEmployeeInfo();
        ((Employee)salesp).PrintEmployeeInfo();

        employee.PrintEmployeeInfo();
        manager.PrintEmployeeInfo();
        salesp.PrintEmployeeInfo();
        
    }
}