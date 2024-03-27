
public static class GameTools
{
    public static bool ReturnCount = true;
    private static Random random = new Random();


    public static string CoinFlip(int number)
    { 
        string[] side = "Tails,Heads".Split(",");
        
    
        if (ReturnCount)
        {   

        
            for (int i = 0; i < number; i++)
            {   string  randomside= side[random.Next(side.Length)];
                return randomside;
            }
        }
        else
        {
            int Heads = 0;
            int Tails = 0;
            for (int i = 0; i < number; i++)
            {   
                if (randomside == "Heads" )
                {
                    Heads++;
                }
                else
                {
                    Tails++;
                }
            }
            return $"Heads: {Heads}\nTails: {Tails}";
        }
        
    }

    public static string DiceRoll(int sides, int rolls)
    {    

        int randomside = random.Next(1,sides +1);
        if (sides < 3)
        {
            return "Invalid number of die sides";
        }
        if (!ReturnCount )
        {   
            List<string> results = new List<string>();
            for (int i = 0; i < rolls; i++)
            {
                results.Add($"Roll {i + 1}: {randomside}");
            }
            return string.Join("\n", results);

        }
        else 
        {   
            Dictionary<int,int> counter = new Dictionary<int, int>();
            for (int i = 1 ; i < rolls; i++)
            {   
                if (! counter.ContainsKey(randomside))
                {   
                    counter[randomside] = 1;
                }
                else
                {
                    counter[randomside]++;
                }
            }

             List<string> values = new List<string>();   
            foreach (KeyValuePair<int,int> pair in counter)
            {
                values.Add( $"{pair.Key} was rolled {pair.Value} times");
            
            return string.Join("\n", values);
        }
        }
    } 
}