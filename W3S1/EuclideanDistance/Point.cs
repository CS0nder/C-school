/*
class Point
{
    public double X;
    public double Y;

    public Point(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }
    public Point()
    {
        X = 0;
        Y = 0;
    }

    public Point(Point obj)
    {
        X = obj.X;
        Y = obj.Y;
    }
    public static double EuclideanDistance(Point num1 , Point num2)
    {   
        double deltaX = num1.X - num2.X;
        double deltaY = num1.Y - num2.Y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
}

/*
Last week you made a Point class. Modify it by overloading the constructor. You will need to:

    overload the default constructor, which simply leaves X and Y at 0.
    add a "copy" constructor, which takes a Point object and sets its its own X and Y to that of the given object.

*/


class Program
{
    public static void Main()
    {
        Person person = new Person("John Doe");
        person.Introduce();
        Student student = new Student("Jane Doe");
        student.Status();
        student.Graduate();
        student.Status();
    
    }
}