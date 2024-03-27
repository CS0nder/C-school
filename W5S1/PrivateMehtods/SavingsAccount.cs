class SavingsAccount : BankAccount
{
    private bool _locked = true;


    public SavingsAccount(double _balance, double interest) : base(_balance, interest) {}


    public override double Withdraw(double amount)
    {
       if (_locked)
       {
            return 0;
       }
       else
       {
            return base.Withdraw(amount);
       }
    }

    public override void NextYear()
    {
        YearsPassed++;

        if (YearsPassed < 5)
        {
            base.ApplyInterest();
        }
        else
        {
            _locked = false;
        }
    }
}