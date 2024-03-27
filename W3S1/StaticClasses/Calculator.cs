using n
class Calculator
{  
    public static double Add(double number1, double number2) =>number1 + number2;
    
    public static double Subtract(double number1, double number2) => number1 - number2;
    public static double Multiply(double number1, double number2) => number1 * number2;
    public static double Divide(double number1, double number2) => number1 / number2;
    public static double Modulo(double number1, double number2) => number1 % number2;


    public static void Main2()
    {
        Console.WriteLine("Give the First number:");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Give the Second number:");
        double number2 =  Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"{number1} + {number2} = {Add(number1, number2)}");
        Console.WriteLine($"{number1} - {number2} = {Subtract(number1, number2)}");
        Console.WriteLine($"{number1} * {number2} = {Multiply(number1, number2)}");
        Console.WriteLine($"{number1} / {number2} = {Divide(number1, number2)}");
        Console.WriteLine($"{number1} % {number2} = {Modulo(number1, number2)}");
    }

    //StoreInMemory: takes a double and stores this in the JSON file
    //RestoreFromMemory: returns the double stored in the JSON file
    public void StoreInMemory(double number)
    {   
        string fileName = "Memory.json";
        StreamWriter writer = new StreamWriter(fileName); //fileName is "Memory.json"
        writer.Write(JsonConvert.SerializeObject(valueToWrite));
        writer.Close();
    }
    public double RestoreFromMemory()
    {   
        string fileName = "Memory.json";
        StreamReader reader = new StreamReader(fileName); //fileName is 
        string jsonString = reader.ReadToEnd();
        reader.Close();
        var fromjson = JsonConvert.DeserializeObject<double>(jsonString)!;
    }


}

/*
Give the first number:
Give the second number:
55 + 5.5 = 60.5
55 - 5.5 = 49.5
55 * 5.5 = 302.5
55 / 5.5 = 10
55 % 5.5 = 0
*/
