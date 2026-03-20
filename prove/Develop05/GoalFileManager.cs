class GoalFileManager
{
    private string _filename;
    private GoalParser _parser;


    public GoalFileManager(string filename)
    {
        _filename = filename;
        _parser = new GoalParser();
    }
    public void Save(List<Goal> goals)
    {
        using(StreamWriter writer = new StreamWriter(_filename))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }
    }

    public List<Goal> Load()
    {
        List<Goal> goals = new List<Goal>();

        if (!File.Exists(_filename))
        {
            return goals;
        }

        string[] lines = File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            Goal goal = _parser.CreateItem(line);
            if(goal != null)
            {
                goals.Add(goal);
            }
        }

        return goals;
    }

}