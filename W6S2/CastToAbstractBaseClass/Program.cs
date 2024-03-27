class Program
{
    public static void Main()
    {
        List<Bill> listOfBills = new List<Bill>
        {
            new ElectricityBill(50, "John Smith"),
            new ElectricityBill(75, "Jane Doe"),
            new GasBill(100, "Bob Johnson", false),
            new GasBill(124, "John Doe", true)
        };

        double totalAmount = 0;
        foreach (Bill bill in listOfBills)
        {   if (bill == (ElectricityBill)bill)
            {
                Console.WriteLine(bill.GetDescription());
                
            }
    
            totalAmount += bill.Amount;
        }
        Console.WriteLine($"Total amount: {(int)totalAmount}");
    }
}


/*
Learning goals:

    casting derived classes to their abstract base classes

Create Program.cs, and in the Main create a List of the following objects:

    ElectricityBill for John Smith, for an amount of 50
    ElectricityBill for Jane Doe, for an amount of 75
    GasBill for Bob Johnson, for an amount of 100
    GasBill for John Doe, for an amount of 125. He has the loyal customer program.

Loop through the bills, printing all their descriptions. Then print the total amount of the bills, cast to int.

Example output:

Electricity bill for John Smith: 50
Electricity bill for Jane Doe: 75
Gas bill for Bob Johnson: 100
Gas bill for John Doe: 112
Total amount: 337+*/
