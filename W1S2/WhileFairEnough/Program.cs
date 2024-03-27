
int Euro = 4;
while (Euro > 0)
{
    Console.WriteLine($"Money left: {Euro}");
    Console.Write("Look around (1) or go in a ride (2)?");
    int Choice = Convert.ToInt32(Console.ReadLine());
    if (Choice == 1)
    {
        Console.WriteLine("\nYay!");
    }
    else if (Choice == 2)
    {
        Console.WriteLine("\nWheee!");
        Euro--;
    }

}
Console.WriteLine("Time to go home");