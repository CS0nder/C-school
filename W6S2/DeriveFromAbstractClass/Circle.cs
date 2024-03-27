class Circle : Shape
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double Area{get{return Math.PI * Radius * Radius;}}

    public override double Perimeter {get{return 2 * (Math.PI * Radius);}}
    

    public override string Info()
    {
        return $"Circle with a radius of {Radius}";
    }
}


/*learning goals:

    creating classes derived from abstract classes

Create two classes: Square and Circle. Both have constructors that takes the Length (for the Square) or Radius (for the Circle).
Both inherit from the abstract class Shape and must implement the properties Area and Perimeter; and the method Info:

    Area is a read-only property that returns the Length squared (Square) or π times the Radius squared (Circle)
    Perimeter is a read-only property that returns 4 times the Length (Square) or 2 times π times the Radius
    Info returns:
    Square with sides of ...
    Circle with a radius of ...*/

