
static class PersonalInformation
{
    public static void PrintName(string input)
    {
        Console.WriteLine(input);
    }
    public static void PrintName(string input , string input1)
    {
        Console.WriteLine($"{input} {input1}");
    }

    public static void PrintName(char input, string input1)
    {
        Console.WriteLine($"{input}. {input1}");
    }

    public static int IncreaseSalary(int number)
    {
        number += 100;

        return number;
    }

    public static double IncreaseSalary(int num, double num1)
    {   
        num1 ++;
        return num * num1;
    }
}