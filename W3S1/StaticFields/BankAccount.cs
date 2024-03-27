/*Learning goals:

    static fields

Write a class BankAccount that has two fields: a static double InterestRatePercentage and a double Balance.
Both these fields should start at their default values (i.e. 0.0), so no need to write a constructor.

Write two methods:

    Deposit: takes a double and returns nothing. Increases the Balance by the given amount.
    ApplyInterest: takes no parameters and returns nothing. Applies the InterestRatePercentage to the Balance.
    Note that you will need to convert the InterestRatePercentage from, for example, 10 to 0.10.

Note: both inside and outside this course, whenever you are asked to create a class, write it in a CS file with the same name. So create the class BankAccount in the file BankAccount.cs and submit this.

This is the Main we will use to test your class:

class Program
{
    static void Main()
    {
        BankAccount.InterestRatePercentage = 10;
        var account1 = new BankAccount();

        account1.Deposit(1000);
        account1.ApplyInterest();

        var account2 = new BankAccount();
        account2.Deposit(2000);

        BankAccount.InterestRatePercentage = 5;
        account1.ApplyInterest();
        account2.ApplyInterest();

        Console.WriteLine(account1.Balance);
        Console.WriteLine(account2.Balance);
    }
}*/

class BankAccount
{
    public static double InterestRatePercentage = 0;
    public double Balance = 0;
    public void Deposit(double balance)
    {
        Balance += balance;
    }
    public void ApplyInterest()
    {   
        double newBalance =InterestRatePercentage / 100 * Balance;
        Balance += newBalance;
    }

}


class Program
{
    static void Main()
    {
        BankAccount.InterestRatePercentage = 10;
        var account1 = new BankAccount();

        account1.Deposit(1000);
        account1.ApplyInterest();

        var account2 = new BankAccount();
        account2.Deposit(2000);

        BankAccount.InterestRatePercentage = 5;
        account1.ApplyInterest();
        account2.ApplyInterest();

        Console.WriteLine(account1.Balance);
        Console.WriteLine(account2.Balance);
    }
}