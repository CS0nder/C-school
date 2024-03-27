


class Program    
{   

    static void Main()
    {
        PrintIsLeapYear(1000);
    }
    static bool IsDivisibleBy(int num1, int num2) 
    {
        if (num1 % num2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    static bool IsLeapYear(int num)
    {
    
        if (IsDivisibleBy(num, 400) == true)
        {
            return true;
        }
        if (IsDivisibleBy(num, 4)== true && Program.IsDivisibleBy(num, 100) == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void PrintIsLeapYear(int num)
    {   
        if (IsLeapYear(num))
        {
            Console.WriteLine($"{num} is a leap year");
        }
        else
        {
            Console.WriteLine($"{num} is not a leapyear");
        }
        
    }
}