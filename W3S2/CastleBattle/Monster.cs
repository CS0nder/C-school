/*Create the Player and Monster classes.

Monster

This class has at least the following fields:

    Name, a read-only string
    CurrentHP, an int
    Strength, an int
    Experience, an int

It also has at least the following methods:

    constructor: it takes the name, current HP, strength, and experience; set these to their respective fields.
    Attack: takes a player, and calls that player's TakeDamage method with this monster's strength.
    TakeDamage: takes an amount of damage (an int) and reduce the current HP with the amount. The amount may not become negative; make it 0 instead.
    IsAlive: returns whether the monster still has HP left.

*/

class Monster
{
    public readonly string Name;
    public int CurrentHP;
    public int Strength;
    public int Experience;

    public Monster(string name, int hp, int strength, int experience)
    {
        this.Name = name;
        this.CurrentHP = hp;
        this.Strength = strength;
        this.Experience = experience;
    }

    public void Attack(Player player)
    {
        player.TakeDamage(Strength);
    }

    public void TakeDamage(int Damage)
    {
        CurrentHP -= Damage;
        if ((CurrentHP -= Damage ) < 0)
        {
            CurrentHP = 0;
        }
       
    }
    public bool IsAlive()
    {   

        if (CurrentHP > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}