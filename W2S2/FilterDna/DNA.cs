
class DNA
{
    public string Seq;
    
    public DNA(string seq)
    {
        this.Seq = seq;
    }
    public int Length => Seq.Length;
}