

string CorrectCode = "1234";
for (int attempts = 3; attempts > 0; attempts--)
{   
    Console.WriteLine("Enter your PIN");
    Console.WriteLine($"{attempts} attempts left");     
    string Code = Console.ReadLine();

    if (Code == CorrectCode)
    {
        Console.WriteLine("Correct");
        break;
    }
    else if (attempts == 1 && Code != CorrectCode)
    {
        Console.WriteLine("Your pass is confiscated");
        break;
    }

}
