
class Task
{
    public string Name = "";
    public bool IsDone;
    public Task(string name)
    {
        this.Name = name;
    }
    public void Done()
    {   
        this.IsDone = true;
    }
    public string Info()
    {
        if (this.IsDone)
        {
            return $"Task: {this.Name}, Status: Done";
        }
        else
        {
            return $"Task: {this.Name}, Status: Pending";
        }
 
    }

}