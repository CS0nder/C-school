/*
class Program
{
    public static void Main(string[] args)
    {
        Square square1 = new Square(5);
        Console.WriteLine($"Side: {square1.Side}\nArea: {square1.Area()}\nPerimeter: {square1.Perimeter()}");
        
        Square square2 = new Square(10);
        Console.WriteLine($"Side: {square2.Side}\nArea: {square2.Area()}\nPerimeter: {square2.Perimeter()}");
    } 
}
class Square
{
    public int Side;
    public Square(int side)
    {
        this.Side = side;
    }

    public int Area() => this.Side * this.Side;
    public int Perimeter() => 4 * this.Side;
}
*/


/*
fields

Finish the Person class by writing the fields and the constructor, so that the Main can create Person objects and print their introductions.*/


class Person
{
    //Write the fields and the constructor here
    string FirstName;
    string LastName;
    public Person(string firstName, string lastName)
    {   //init in python en this. is self. in c#
        this.FirstName = firstName;
        this.LastName = lastName;

    }
    public string Introduce() =>  $"I am {FirstName} {LastName}";
}

class Program
{
    static void Main()
    {   
     
        Person person1 = new Person("Bruce", "Wayne");
        Person person2 = new Person("Clark", "Kent");
        Person person3 = new Person("Diana", "Prince");

        var personList = new List<Person>() { person1, person2, person3 };
        foreach (var person in personList)
            Console.WriteLine(person.Introduce());
    }
}
