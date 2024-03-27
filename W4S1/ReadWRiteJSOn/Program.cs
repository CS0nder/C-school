using Newtonsoft.Json;

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


    public static void StoreInMemory(double valueToWrite)
    {   
        string fileName = "Memory.json";
        StreamWriter writer = new StreamWriter(fileName); 
        //maakt er json string van
        writer.Write(JsonConvert.SerializeObject(valueToWrite));
        writer.Close();
    }
    public static double RestoreFromMemory()
    {   
        string fileName = "Memory.json";
        StreamReader reader = new StreamReader(fileName); 
        string jsonString = reader.ReadToEnd();
        reader.Close();
        //haalt de json string eruit en is het weer een double
        var fromjson = JsonConvert.DeserializeObject<double>(jsonString)!;
        return fromjson;
    }
}