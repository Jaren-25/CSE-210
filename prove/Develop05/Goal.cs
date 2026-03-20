public abstract class Goal
{
    protected int _totalPoints;
    protected int _goalPoints;
    protected string _name;
    protected string _description;


    // public Goal(int point, string name, string desription)
    // {
    //     _point = point;
    //     _name = name;
    //     _description = desription;
    // }

    public abstract void scorePoints();

    public abstract void Display();


    public void setName(string name)
    {
        _name = name;
    }
    public void setDescription(string desription)
    {
        _description = desription;
    }
    public void setPoints(int goalPoints)
    {
        _goalPoints = goalPoints;
    }

    public abstract string Serialize();

}