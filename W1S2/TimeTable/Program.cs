
//basically maak een timetable tot en met de gegeven getal
//gebruik nested for- loop


Console.WriteLine("Give a number from 2-9");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9)
{
    number = 9;
}
if (number <= 2)
{
    number = 2;
}

Console.Write("  |");
for (int i = 1; i <= number; i++)
{
    Console.Write($"   {i}");
   
}
Console.WriteLine();

for (int i = 0; i<= number; i++)
{
    Console.Write("----");
}
Console.WriteLine();

for (int row = 1; row <= number;row++)
{  
   
    
    Console.Write($"{row} |");
    for (int col = 1 ;col <= number;col++)
    {   
        Console.Write($" {row * col,3}"); 
    }
    Console.WriteLine();
} 
