Random random= new Random(1);

for (int i = 0; i <= 10; i++)
{
    int Dice = random.Next(1,7);
    Console.WriteLine(Dice);
}