class Program
{   

    public static void Main()
    {
        List<DNA> DNALists = new List<DNA>{new DNA("ACGT"),new DNA("GCTTAC"), new DNA("CGTTAGCTT"), new DNA("TACA")};

        Console.Write("What is the minimum sequence length?");
        int Answer = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The filtered list:");
        foreach (DNA dna in DNALists)
        {
            if (dna.Length >= Answer)
            {   
                Console.WriteLine(dna.Seq);
            }
          
        }
    }
 
}