
class Square : IResizable, IDrawable
{   

    public int Size;
    public void Resize(double scale)
    {   
        Size = (int)Math.Round(Size * scale);
    }
    public void Draw()
    {
        for (int i = 0; i < Size; i++)
        {   
            Console.WriteLine("*");
            for (int p = 0; i < Size; p++)
            {
                Console.WriteLine("*");
            }
        }
    }
}
