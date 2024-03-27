/*The employees of a company have complained they have not received their travel reimbursement this month.
Find and fix the issue.

Some hints and pointers:

    Employees receive a travel reimbursement based on how far they live from the company.
        For employees that live really far (25+ km), there is a budget for extra reimbursement.
            This extra reimbursement is divided among the distant employees, with a maximum with 100 euros per employee.
            Whatever is left over from this budget is divided among the rest of the employees.
    Employee.cs has not not been modified in a while, but Company.cs has been.
        Therefore most likely the issue is to be found in Company.cs.
        You may modify Company.cs in any way, as long as it still works with the Employee and Program classes.
    Perhaps the log file can give a clue of what went wrong. Run the code to your IDE and check the file.

*/
class Program
{
    public static void Main()
    {
        var company = new Company();
        var people = new List<Employee>()
        {
            new Employee(3000, 10),
            new Employee(2500, 20),
            new Employee(3500, 15),
            new Employee(3000, 20),
        };
        foreach (var person in people)
        {
            company.Hire(person);
        }

        company.PayMonthlySalary();
        foreach (var employee in company.Employees)
        {
            Console.WriteLine($"Employee has earned {employee.SalaryEarned}");
        }
    }
}