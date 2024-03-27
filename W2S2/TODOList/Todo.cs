
class Todo
{
    public List<Task?> Tasklist = new List<Task?>();
    

    public void AddTask(string name)
    {   
        Tasklist.Add(new Task(name));

    }

    //kijkt eerst of de task null is
    public Task? GetTask(string name)
    {
        foreach (Task? task in Tasklist)
        {
            if (task?.Name == name)
            {
                return task;
            }
          
           
        }
        //zet de return null buiten de statements zodat als de if statement niet klopt het null returned
        return null;
    }
    public string Report()
    {   
        string TaskReport = "";
        foreach (Task? task in Tasklist)
        {   
            if (task != null)
            {
                TaskReport+= $"{task.Info()}\n";
            }
        }
        return TaskReport;
    }
}