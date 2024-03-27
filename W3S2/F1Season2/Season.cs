
class Season
{   
    public int Year;
    public List<Race> Races;
    public List<Team> Teams;

    
    public Season(int year, List<Race> races, List<Team> teams)
    {
        this.Year = year;
        this.Races = races;
        this.Teams = teams;
    }
    

    public void SeasonResults()
    {
        Random random = new Random();
        Dictionary<string, int> TotalPoints = new Dictionary<string, int>();
        List<int> Points = new List<int>{25, 18, 15, 12, 10, 8, 6, 4, 2, 1};


        foreach (Race race in Races)
        {
            var results = new List<(Driver driver, int position)>();

            foreach (Team team in Teams)
            {
                foreach (Driver driver in team.Drivers)
                {
                    int rank = random.Next(1, 21); 
                    results.Add((driver, rank));
                }
            }
        
                Console.WriteLine("Season results:");
                int position = 1;
                foreach (var pair in TotalPoints.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{position}. {pair.Key}: {pair.Value}");
                    position++;
                }
        }
    }

    public void RunSeason()
    {
        Random random = new Random();
        foreach (Race race in Races)
        {
            var results = new List<(Driver driver, int position)>();

            foreach (Team team in Teams)
            {
                foreach (Driver driver in team.Drivers)
                {
                    int position = random.Next(1, 21); 
                    results.Add((driver, position));
                }
            }

            results = results.OrderBy(r => r.position).ToList();

            for (int i = 0; i < results.Count && i < 10; i++)
            {
                results[i].driver.Points += Punten(i);
            }

            string winningTeam = "";
            foreach (Team team in Teams)
            {
                if (team.Drivers.Contains(results[0].driver))
                {
                    winningTeam = team.Name;
                    break;
                }
            }

   
            Console.WriteLine($"{results[0].driver.Name} of {winningTeam} has won the {race.Country} Grand Prix!");
        }
    }

    private int Punten(int position)
    {
        int[] points = { 25, 18, 15, 12, 10, 8, 6, 4, 2, 1 };
        if (position < points.Length)
        {
            return points[position];
        }
        return 0;
    }


}



