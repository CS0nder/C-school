


using System.Runtime.CompilerServices;

Console.WriteLine("For each direction, input YN if it is valid.");

Console.WriteLine("North Y/N");
string North = Console.ReadLine();

Console.WriteLine("East Y/N");
string East = Console.ReadLine();

Console.WriteLine("South Y/N");
string South = Console.ReadLine();

Console.WriteLine("West Y/N");
string West = Console.ReadLine();



if (North == "Y")
{
    Console.WriteLine("    N");
    Console.WriteLine("    |   ");
}
else if (North == "Y" && South == "Y")
{
    Console.WriteLine("    N");
    Console.WriteLine("    |");
    Console.WriteLine("    |");
    Console.WriteLine("    |");
    Console.WriteLine("    S");
}



if (West == "Y" && East == "Y")
{
    Console.WriteLine("W---|---E");
}
else if (West == "Y" && East == "N")
{
    Console.WriteLine("W---|");
}
else if (West == "N" && East == "Y")
{
    Console.WriteLine("    |---E");
}
else
{
    Console.WriteLine();
}

if (South == "Y")
{
    Console.WriteLine("    |");
    Console.WriteLine("    S");
}



Console.Write("");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 360)
{
    number = number - number / 360 * 360;
}
else if (number <= 0)
{
    number = 360 + (number % 360);
}


if (number > 315 || number <= 45)
{
    if (North == "Y")
    {
        Console.WriteLine("You are going North");
    }
    else if (North == "N")
    {
        Console.WriteLine("You can't go north");
    }
}

else if (number > 45 && number <= 135)
{
    if (East == "Y")
    {
        Console.WriteLine("You are going East");
    }
    else
    {
        Console.WriteLine("You can't go East");
    }
}

if (number > 135 && number <= 225)
{
    if (South == "Y")
    {
        Console.WriteLine("You are going South");
    }
    else if (South == "N")
    {
        Console.WriteLine("You can't go South");
    }
}

else if (number > 225 && number <= 315)
{
    if (West == "Y")
    {
        Console.WriteLine("You are going West");
    }
    else if (West == "N")
    {
        Console.WriteLine("You can't go West");
    }
}

