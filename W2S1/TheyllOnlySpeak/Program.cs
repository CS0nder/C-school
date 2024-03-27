/*Player

Create the class Player in your IDE:

    Fields: Name (string), HealthPoints and Power (both ints).
    Constructor:
        Parameters: a string and an int.
        Field setup: assign the parameters to Name and Power; set HealthPoints to 100.
    Methods:
        IsAlive: returns whether the value of HealthPoints is more than 0.
        TakeDamage: reduces HealthPoints by the given amount. HealthPoints may not go below 0.

Main

For the Main method, open Program.cs in the template files.

Uncomment the Main method. Then complete it by replacing the ... dots, in order to play a small game.

First create two Players (p1 and p2) using the following information:

    Name: "John Snow"; Power: 30
    Name: "Night King"; Power: 60

Then create a Player named winner that is initialized to null. As long as winner is null do the following:

    Have player 1 take damage from player 2 (by using the TakeDamage method). The amount of damage should be equal to the Power that player 2 has.
    The same, but now player 2 takes damage from player 1.
    After each player has taken damage from the other:
    if player 1 is dead (IsAlive returns false), set winner to player 2; otherwise, if player 2 is dead, set winner to player 1.
        This means that no draws will occur.

*/

public class Program
{
    public static void Main()
    {
        Player p1 = new Player(Name:"John Snow",Power:30);
        Player p2 = new Player(Name:"Night King", Power:60);
        Player winner = null;
        Console.WriteLine($"{p1.Name}: {p1.Power} Power; {p1.HealthPoints} Healthpoints");
        Console.WriteLine($"{p2.Name}: {p2.Power} Power; {p2.HealthPoints} Healthpoints");
        while (winner == null)
        {
            p1.TakeDamage(p2.Power);
            p2.TakeDamage(p1.Power);
            if (!p1.IsAlive())
                winner = p2;
            else if (!p2.IsAlive())
                winner = p1;
            Console.WriteLine($"{p1.Name}: {p1.Power} Power; {p1.HealthPoints} Healthpoints");
            Console.WriteLine($"{p2.Name}: {p2.Power} Power; {p2.HealthPoints} Healthpoints");
        }

        Console.WriteLine($"-----The winner is:-----\n{winner.Name}: {winner.Power} Power; {winner.HealthPoints} Healthpoints");
    }
}


class Player
{
    public string Name;
    public int HealthPoints = 100;
    public int Power;
    public Player(string Name, int Power)
    {
        this.Name = Name;
        this.Power = Power;
    }
    public bool IsAlive()
    {

        return HealthPoints > 0 ;
    }
    public void TakeDamage(int damage)
    {
        if (IsAlive())
        {
            HealthPoints -= damage;
            if (HealthPoints < 0)
            {
                HealthPoints = 0;
            }
        }
    }
}