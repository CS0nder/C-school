
Console.WriteLine("What is the amount to pay?");
int Amount = Convert.ToInt32(Console.ReadLine());
int AmountPaid = 0;
int PaidTooMuch = 0;
int AmountMinus = Amount;
string Answer = "";
while (AmountPaid <= Amount)
{
    Console.WriteLine($"{AmountMinus} left to pay");
    Console.WriteLine("How much?\n1: 5\n2: 10\n3: 20\n4: 50");
    int Choice = Convert.ToInt32(Console.ReadLine());
    if (Choice == 1)
    {   
        AmountMinus -= 5;
        AmountPaid += 5;
    }
    else if (Choice == 2)
    {  
        AmountMinus -= 10;
        AmountPaid += 10;
    }
    else if (Choice == 3)
    {   
        AmountMinus -= 20;
        AmountPaid += 20;
    }
    else if (Choice == 4)
    {   
        AmountMinus -= 50;
        AmountPaid += 50;
    }
    else
    {
        Console.WriteLine("Invalid choice. Please choose again.");
    }


    if (AmountPaid > Amount)
    {
        PaidTooMuch = AmountPaid -Amount;
        while (Answer.ToLower() != "y" && Answer.ToLower() != "n")
        {
            Console.WriteLine($"You paid {PaidTooMuch} too much. Give a tip? y/n");
            Answer = Console.ReadLine();

            if (Answer.ToLower() == "y")
            {
                Console.WriteLine($"You have paid {AmountPaid}");
            }
            else
            {
                Console.WriteLine($"You have paid {Amount}");
            }
        }
    }
    else if (AmountPaid == Amount)
    {
        Console.WriteLine($"You have paid {Amount}");
        break;
    }

}
