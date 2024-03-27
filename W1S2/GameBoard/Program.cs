
int size = 0;

while (size <= 2)
{
    Console.WriteLine("Size of board:");
    size = Convert.ToInt32(Console.ReadLine());
}
for (int row = 0; row < size; row++)
    
{    
    for (int col = 0; col < size; col++)
    {
        // kijkt of de size een oneven getal is
        // als het even is kijkt hij welke positie hij zit
        //als het een even getal is word het een w waardoor het met een linker b hoek is
        if (size % 2 == 0)
        {
            if ((row + col) % 2 == 0)
            {
                Console.Write("W");
            }
            else
            {
                Console.Write("B");
            }
         
        }
        // als het een oneven getal is begint hij met een B zodat de linker hoek zwart is aan het einde
        else
        {   // de eerste letter word een b zodat het aan de linkerhoek een xwart is 
            if ((row + col) % 2 == 0)
            {
                Console.Write("B");
            }
            else
            { 
                Console.Write("W");
            }
           
          
 
        }
    }
    Console.WriteLine();
}
