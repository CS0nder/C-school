/*Player

This class has similar fields and methods to those of the Monster class. These are the differences:

    .
    The constructor takes the maximum HP instead of the current HP, and sets this to the new MaxHP field.
        CurrentHP always starts at the maximum.
   
   
            Note that Program.cs refers to this field as Player.Experience instead of player.Experience; what does that tell you about the field?
            When the player dies, a new player is created with the same amount of experience (and thus level) as the dead one.
    Attack: the attack targets are of course monsters instead of players.
        Additionally, if the player has killed a monster, increase the player's experience by that monster's experience. Read below for more details.
    TakeDamage: the taken damage is reduced by the -- player's strength divided by 4, rounded down --.
    GetLevel: returns the player's current level.

Gaining experience

The player starts at level 1 with 0 experience. In World.cs, you'll find an experience chart.
Each time a player gains experience, they may pass an experience threshold, gaining a level and increasing their stats:

    MaxHP is increased by 10;
    Strength is increased by 3.

For example, a player starts with 50 maximum HP and 20 strength, and with 30 experience they will will be at level 3 with 50 maximum HP and 26 strength.
*/





class Player
{
    
    public const string Name = "Simon Belmont";
    public int CurrentHP;
    public int MaxHP;
    public int Strength;
    public static int Experience = 0;

    public int Level = 1;

    public Player(int maxhp, int strength)
    {
        this.MaxHP = maxhp;
        this.Strength = strength;
    }
//    public static readonly List<int> ExperienceChart = new() { 10, 25, 45, 75, 115, 160, 235, 300 };
    public void Attack(Monster monster)
    {
        monster.TakeDamage(Strength);
        if (monster.CurrentHP == 0)
        {
            Experience += monster.Experience;
            Strength += 3;
            MaxHP += 10;
            Level += 1;
        }    

    }

    public void TakeDamage(int Damage)
    {   
        int reducedformula = (int)Math.Round(Strength / 4.0);
        CurrentHP -= Damage - reducedformula;
    }

    public int GetLevel()
    {
        return Level;
    }
    public bool IsAlive()
    {   
        if (CurrentHP > 0)
            return true;
        else
        {
            return false;
        }
    }
}
