
class LimitedEditionCar
{
    public const string Model = "McLaren F1";

    public static int Counter = 0;
    public readonly string ChassisNumber;
    public LimitedEditionCar?()
    {   
        int number = Counter + 1;
        ChassisNumber =  $"CHNO {number}";
        Counter++;
    }
}
