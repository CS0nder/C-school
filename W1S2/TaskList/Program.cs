
class Program
{
    static void Main(string[] args)
    {
        List<string> Tasks = new List<string>() {};



        int TasksCounter = Tasks.Count();
        Console.WriteLine($"Amount of tasks: {TasksCounter}");

        Tasks.Add("Mow lawn");
        Tasks.Add("Pay taxes");

        TasksCounter = Tasks.Count();
        Console.WriteLine($"Amount of tasks: {TasksCounter}");        

        foreach (string task in Tasks)
        {   
            Console.WriteLine(task);
        }

        Tasks.Remove("Mow lawn");
        Tasks.Add("Shopping");
        
        TasksCounter = Tasks.Count();

        Console.WriteLine($"Amount of tasks: {TasksCounter}");

        foreach(string task in Tasks)
        {
            Console.WriteLine(task);
        }
    }
}