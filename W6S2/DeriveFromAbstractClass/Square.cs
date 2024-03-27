class Square : Shape
{
    public double Length;

    public Square(double length)
    {
        Length = length;
    }
    public override double Area{ get {return Math.Pow(Length, 2);}}
    public override double Perimeter{get{return Length * 4;}}

    public override string Info()
    {
        return $"Square with sides of {Length}";
    }
}