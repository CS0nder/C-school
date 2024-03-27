

Console.Write("Enter a age:");
int Age = Convert.ToInt32(Console.ReadLine());

string UserAge = Age switch
{ 
    int age when age >= 0 && age <= 12 => $"Age {Age}: a child",

    int age when age >= 13 && age <= 19 => $"Age {Age}: a teenager",

    int age when age >=20 && age <= 150 => $"Age {Age}: an adult",
    _ => $"Age {Age}: invalid"
};
Console.WriteLine(UserAge);