
class Program
{
    public static void Main()
    {
        Console.Write("What is your name?");
        string name = Console.ReadLine();
        Console.Write("What is your last name");
        string lastName = Console.ReadLine();
        DisplayName(name,lastName);
    }
    public static string Name(string firstName, string lastName) => $"{firstName} {lastName}";
    public static void DisplayName(string firstName, string lastName) => Console.WriteLine(Name(firstName,lastName));
}
