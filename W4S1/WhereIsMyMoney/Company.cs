class Company
{
    public List<Employee> Employees;
    public int WhatIsConsideredDistant;
    public int ExtraTravelAllowanceBudget;
    public int MaxExtraTravelAllowance;
    public string LogLocation;
    public Company()
    {
        Employees = new List<Employee>();
        WhatIsConsideredDistant = 25;
        ExtraTravelAllowanceBudget = 300;
        MaxExtraTravelAllowance = 100;
        LogLocation = "./Log.txt";
    }

    public void Hire(Employee employee) => Employees.Add(employee);

    public void PayMonthlySalary()
    {
        int howManyDistantEmployees = HowManyDistantEmployees();
        foreach (var employee in Employees)
        {
            int payout = employee.Salary + CalculateTravelAllowance(employee, howManyDistantEmployees);
            employee.SalaryEarned += payout;
        }
    }

    private int CalculateTravelAllowance(Employee employee, int howManyDistantEmployees)
    {
        var howManyCloseEmployees = Employees.Count - howManyDistantEmployees;
        var standardTravelAllowance = employee.DistanceFromCompany * 10;
        try
        {   if (howManyDistantEmployees == 0)
            {
                return standardTravelAllowance + (ExtraTravelAllowanceBudget / howManyCloseEmployees);
            }
            else
            {
                var extraTravelAllowanceDistant = Math.Min(ExtraTravelAllowanceBudget / howManyDistantEmployees, MaxExtraTravelAllowance);
                var extraTravelAllowanceClose = (ExtraTravelAllowanceBudget - (extraTravelAllowanceDistant * howManyDistantEmployees)) / howManyCloseEmployees;
                        
                return standardTravelAllowance +
                    (employee.DistanceFromCompany >= WhatIsConsideredDistant ?
                    extraTravelAllowanceDistant : extraTravelAllowanceClose);
            }
            

        }
        catch (DivideByZeroException ex)
        {
            string message = ex.Message;
            message =
                (howManyDistantEmployees == 0 ? "0 distant employees. " : "") +
                (howManyCloseEmployees == 0 ? "0 close employees. " : "") +
                message;
            LogException(message);
        }
        return 0;
    }

    private int HowManyDistantEmployees()
    {
        int howMany = 0;
        foreach (var employee in Employees)
        {
            if (employee.DistanceFromCompany >= WhatIsConsideredDistant)
                howMany++;
        }
        return howMany;
    }

    private void LogException(string message)
    {
        try
        {
            File.AppendAllText(LogLocation, DateTime.Now + "\n" + message + "\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

