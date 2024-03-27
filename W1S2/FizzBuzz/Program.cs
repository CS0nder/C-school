
Console.WriteLine("Startnumber:");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("End number");
int Num2 = Convert.ToInt32(Console.ReadLine());
// stelt de num gelijk aan num1 de conditie is date hij kleiner is bdan num 2 en dan voert hij 1+ uit
for (int num = Num1 ; num <= Num2; num++)
{   
    if (num % 3 == 0 && num % 5 == 0)
    {   
        Console.WriteLine("FizzBuzz");
    }
    else if (num % 3 == 0)
    {   
        Console.WriteLine("Fizz");
       
    }
    else if (num % 5 == 0)
    {   
        Console.WriteLine("Buzz");
        
    }
    else 
    {
        Console.WriteLine(num);
    }
    
} 


