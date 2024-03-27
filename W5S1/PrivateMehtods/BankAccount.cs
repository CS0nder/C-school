public class BankAccount
{
    private double _balance;
    protected int YearsPassed = 0;
    protected double InterestRate;

    public BankAccount(double balance, double interest)
    {
        _balance = balance;
        InterestRate = interest;
        
    }

    public double ReadBalance() => _balance;

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            _balance += amount;
        }
    }

    public virtual double Withdraw(double amount)
    {   
        if (SufficientBalance(amount))
        {   
            _balance -= amount;
            return amount;
        }
        else if (amount < 0)
        {
            return 0;
        }
        else
        {
            return 0;
        }
    }

    private bool SufficientBalance(double amount)
    {
        if (_balance >= amount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }



    public virtual void NextYear() => ApplyInterest();
    protected virtual void ApplyInterest()
    {
        _balance *= (1 +InterestRate);
    }

}


/*BankAccount

Modify the class BankAccount of the previous assignment. It has two additional fields:

    a protected int YearsPassed
    a protected double InterestRate

InterestRate is initialized through the constructor, so it will need a second parameter. YearsPassed is initialized at 0.

MODIFY Withdraw: it should be able to be overridden in derived classes.
ADD the following methods:

    NextYear: a public method that calls ApplyInterest. It can be overridden in derived classes.
    ApplyInterest: increases the balance by the interest rate (so a balance of 1000 and an interest rate of 0.05 would result in a balance of 1050). It can be called in this and in derived classes.

SavingsAccount

This class is derived from the class BankAccount. It has one additional field: _locked. Based on the underscore and lowercase L, you should be able to deduce its access modifier. This field is initialized as true.

Also add the following methods:

    Withdraw: an overridden method. If the account is _locked, return 0; otherwise use the functionality of the overridden method of the base class.
    NextYear: an overridden method. Increment YearsPassed by 1. Then apply the interest rate like in the base class, but only if the amount of YearsPassed is less than 5. If 5 years have passed, unlock this account.


We will test your solution with this program:
*/
class Program
{
    public static void Main()
    {
        var account1 = new BankAccount(1000, 0.05);
        var account2 = new SavingsAccount(2500, 0.04);
        var withdrawn = 0.0;
        for (int year = 0; year <= 6; year++)
        {
            foreach (var account in new BankAccount[] { account1, account2 })
            {
                account.NextYear();
                if (year > 0 && year % 3 == 0)
                {
                    withdrawn += account.Withdraw(500);
                }
            }
        }

        Console.WriteLine($"Balance account1: {Math.Round(account1.ReadBalance(), 2)}");
        Console.WriteLine($"Balance account2: {Math.Round(account2.ReadBalance(), 2)}");
        Console.WriteLine($"Total withdrawn: {withdrawn}");
    }
}