

Console.Write("What is your age?");
int Age = Convert.ToInt32(Console.ReadLine());
Console.Write("What is the age of the student next to you?");
int ClassmateAge = Convert.ToInt32(Console.ReadLine());

if (Age == ClassmateAge)
{
   Console.WriteLine("Your ages are equal");
}
else if (Age <= ClassmateAge)
{
    Console.WriteLine("You are younger");
}
else
{
    Console.WriteLine("You are older ");
}