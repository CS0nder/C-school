
class Circle
{
    public double Radius;
    public Circle(double radius)
    {
        this.Radius = radius;
    }
    
    public double Area()=> Math.PI * Math.Pow(this.Radius,2);

}    

class Program
{
    static void Main()
    {
        Console.WriteLine("Give the circle radius:");
        double radius = Convert.ToDouble(Console.ReadLine());
        var circle = new Circle(radius);
        Console.WriteLine($"Rounded circle area:{Math.Round(circle.Area())}");
    
    
    }
}




