int attack = 50;
double critChance = 0.33;
int bossHP = 1000;

Random random = new Random();

while (bossHP > 0)
{   
    double Crit = random.NextDouble();
   if (Crit < critChance)
    {
        attack = 100;
    }
    else
    {
        attack = 50;
    }

    Console.WriteLine($"Boss HP: {bossHP}");
    bossHP = bossHP - attack;
    Console.WriteLine($"Damage: {attack}");

} 
Console.WriteLine("Boss defeated");
