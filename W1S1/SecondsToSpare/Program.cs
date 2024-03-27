
Console.Write("How many seconds?");
int Seconds = Convert.ToInt32(Console.ReadLine());

double Hours = Seconds / 3600;
double Minutes = Seconds % 3600 / 60 ;
double RemainingSeconds = Seconds % 60;

Console.WriteLine($"Hours: {Hours}\nMinutes: {Minutes}\nSeconds left: {RemainingSeconds}");