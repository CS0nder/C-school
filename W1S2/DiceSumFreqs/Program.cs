/*


In this assignment, you will keep track of the sum of the results of rolling two six-sided dice.
Complete the program by writing a for-loop that adds a pipe (|) to the corresponding sum in freqs.
So for example, if the sum of two dice rolls is 5, add a | to the string that starts with 05: in freqs.

*/


Random rand = new(0);
var howManyTimes = 500;
var dieSides = 6;

List<List<int>> results = new();
for (int i = 0; i < howManyTimes; i++)
{
    List<int> rollResults = new();
    for (int j = 0; j < 2; j++)
    {
        rollResults.Add(rand.Next(1, dieSides + 1));
    }
    results.Add(rollResults);
}

List<string> freqs = new()
{
    " 2: ",
    " 3: ",
    " 4: ",
    " 5: ",
    " 6: ",
    " 7: ",
    " 8: ",
    " 9: ",
    "10: ",
    "11: ",
    "12: ",
};


// acces de inner list
foreach (List<int> result in results)
{   
    //voegt de elementen in de innerlist samen
    int sumResult = result[0] + result[1];
    switch (sumResult)
    {   
        // als de sumreasult 2 is voegt hij het toe aan nummer 2
        case 2:
            freqs[0] += "|";
            break;
        case 3:
            freqs[1] += "|";
            break;
        case 4:
            freqs[2] += "|";
            break;
        case 5:
            freqs[3] += "|";
            break;
        case 6:
            freqs[4] += "|";
            break;
        case 7:
            freqs[5] += "|";
            break;
        case 8:
            freqs[6] += "|";
            break;
        case 9:
            freqs[7] += "|";
            break;
        case 10:
            freqs[8] += "|";
            break;
        case 11:
            freqs[9] += "|";
            break;
        case 12:
            freqs[10] += "|";
            break;
    }
}

//gebruik switch stetement om te adden


//loopt door de reqs lijst en print leke rij uit
foreach (string freq in freqs)
{
    Console.WriteLine(freq);
}