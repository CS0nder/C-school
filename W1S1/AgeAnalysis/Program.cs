
Console.Write("What is your age?");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"You are {age}. That is old enough to Program!");
Console.ReadLine();

Console.WriteLine($"Last year you were {age-1}");


Console.WriteLine($"Next year you will be {age +1}");

int NextYearAge = age * 2;
Console.WriteLine($"At double your age you will be {NextYearAge}");


Console.WriteLine($"Next year, double your age will be {(age+1)*2}");


double DoubleAge = Convert.ToDouble(age);
DoubleAge = DoubleAge /2.0;
Console.WriteLine($"Half your age is {DoubleAge}");


double RoundedAge = Math.Floor(DoubleAge);
Console.WriteLine($"Half your age (rounded down) is {RoundedAge}");

double LastDigit = age % 10;
Console.WriteLine($"The last digit of your age is {LastDigit}");