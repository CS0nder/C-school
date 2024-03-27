/*Learning goals:

    Hard/soft copy of reference-type values

Create the class DNA which has one field: a string named Seq. It has a constructor that takes a string and sets Seq. This class has three methods:

    Replicate1: creates and returns a new DNA object with the same sequence
    Replicate2: returns this object (so just return this)
    Mutate: takes a string and sets Seq to this value

Program.cs is used to test your implementation of class DNA.
*/




class DNA
{
    public string Seq;
    public DNA(string seq)
    {
        this.Seq = seq;
    }

    public DNA Replicate1()
    {   

        DNA RepDNA = new DNA(this.Seq);
        return RepDNA;
    }
    public DNA Replicate2()
    {
        return this;
    }
    public string Mutate(string seq)
    {
        this.Seqq = seq;
    }
}