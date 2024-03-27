

Console.Write("What is the temperature of the water? (Celsius)");
double Temprature = Convert.ToDouble(Console.ReadLine());
if (Temprature <= 0)
{
    Console.WriteLine($"At {Temprature} degrees Celsius, the water will be solid");
}
else if (Temprature >= 0 && Temprature < 100)
{
    Console.WriteLine($"At {Temprature} degrees Celsius, the water will be liquid");
}
else 
{
    Console.WriteLine($"At {Temprature} degrees Celsius, the water will be Gas");
}
