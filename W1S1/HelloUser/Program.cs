Console.Write("Please enter your Lastname:");
string? LastName = Console.ReadLine();

Console.Write("What is the initial of your first name?");
char Initial = Convert.ToChar(Console.ReadLine());


Console.WriteLine($"Welcome to the course, {Initial} {LastName}. We will watch your career with great interest.");
