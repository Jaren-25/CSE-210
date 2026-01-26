public class Resume
{
    public string _name;
    public List<Job> _jobList = new List<Job>();

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {_name}\nJobs:");

        foreach(Job j in _jobList)
        {
            j.DisplayJobInfo();
        }
    }


}