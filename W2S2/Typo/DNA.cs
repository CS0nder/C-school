class DNA
{
    public DNA Ancestor;
    public string? Seq;

    public DNA(DNA dna, string seq)
    {
        this.Ancestor = dna;
        this.Seq = seq.ToUpper();
    }
    private static Random _rand = new Random(0); //Seeded Random

    //Fields, constructor and Replicate here
    private string MutateTransition()
    {
        var indexToMutate = _rand.Next(0, Seq.Length);
        var mutatedSeq = Seq[0 .. indexToMutate] //Left of mutation
            + MutateTransitionTable(Seq[indexToMutate]) //Mutation
            + Seq[(indexToMutate+1) .. Seq.Length]; //Right of mutation
        return mutatedSeq;
    }

    private char MutateTransitionTable(char nucleotide) => nucleotide switch
    {
        'A' => 'G',
        'G' => 'A',
        'C' => 'T',
        'T' => 'C',
        _ => throw new ArgumentOutOfRangeException($"{nucleotide}", $"Unexpected nucleotide value: {nucleotide}"),
    };
    public DNA Replicate()
    {   
 
        DNA newobj = new DNA(this.Ancestor, MutateTransition());
        return newobj;
    }
}

/*

Complete the DNA class. You'll need to add two public fields, a constructor, and a method.

Fields:

    Ancestor of type DNA (so a field of this class' own type)
    Seq of type string.

Constructor: takes a DNA object and a string; set them to their respective fields. Make sure Seq is uppercase.

Replicate: a method that takes no parameters, but returns a new DNA object. The parameters for the DNA object are:

    a reference to this object
    the Seq of this object, but mutated. To get a mutated Seq, call the MutateTransition method.

*/