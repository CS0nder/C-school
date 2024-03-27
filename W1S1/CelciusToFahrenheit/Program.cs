

Console.Write("What is the temprature in Celcius?");
double Celcius = Convert.ToDouble(Console.ReadLine());
double CelciusToFahrenheit = (Celcius * 1.8) + 32;
Console.WriteLine($"{Celcius} C = {CelciusToFahrenheit} F");
Console.WriteLine($"Truncated that is {Math.Floor(CelciusToFahrenheit)} F");