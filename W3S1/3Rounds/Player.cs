
class Player
{
    public string Name;
    public double Points;
    public int Skill;
    public int Intelligence;
    public int Knowledge;

    public Player(string name, int skill, int Intelligence, int knowledge)
    {
        this.Name = name;
        this.Skill = skill;
        this.Intelligence = Intelligence;
        this.Knowledge = knowledge;
    }
    
    public void Score()
    {
        Points++;
    }

    public static Player? WhoIsWinning(Player player1, Player player2)
    {
        if (player1.Points > player2.Points)
        {
            return player1;
        }
        else if (player2.Points > player1.Points)
        {
            return player2;
        }
        else
        {
            return null;
        }
    }

}