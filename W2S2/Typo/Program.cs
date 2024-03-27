class Program
{
    public static void Main()
    {
        DNA ancestor = new DNA(null, "acgt");
        var dnaLine = new List<DNA>() { ancestor };
        for (int i = 0; i < 25; i++)
        {
            ancestor = ancestor.Replicate();
            dnaLine.Add(ancestor);
        }

        while (ancestor.Ancestor != null)
        {
            Console.WriteLine(ancestor.Ancestor.Seq);
            ancestor = ancestor.Ancestor;
        }
        
        foreach (var dna in dnaLine)
        {
            Console.WriteLine(dna.Seq);
        }

    }
}

/*
Learning goal:

    classes can have objects of the same class as a field

Complete the DNA class. You'll need to add two public fields, a constructor, and a method.

Fields:

    Ancestor of type DNA (so a field of this class' own type)
    Seq of type string.

Constructor: takes a DNA object and a string; set them to their respective fields. Make sure Seq is uppercase.

Replicate: a method that takes no parameters, but returns a new DNA object. The parameters for the DNA object are:

    a reference to this object
    the Seq of this object, but mutated. To get a mutated Seq, call the MutateTransition method.

*/