class Person
{
    public string Name;

    //maakt een variabel voor job class
    public Job? DayJob;
    public Person(string name, Job? dayjob)
    {
        this.Name = name;
        this.DayJob = dayjob;
    }
    public string Info()
    {
        if (DayJob == null)
        {
            return $"{Name} is in between jobs";
        }
        else
        {
            //pakt de naam van de Job class
            return $"{Name} works as a {DayJob.Name}";
        }
    } 
}