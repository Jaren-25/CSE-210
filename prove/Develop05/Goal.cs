public class Goal
{
    protected int _totalPoints;
    protected int _goalPoints;
    protected string _name;
    protected string _description;
    protected bool _isFinished;
    protected string _x = "";


    public string Complete()
    {
        if(_isFinished == true)
        {
            _x = "X";
        }
        else
        {
            _x = " ";
        }
        return _x;
    }

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

    public virtual int scorePoints()
    {
        if (_isFinished == true)
        {
            _totalPoints = _totalPoints + _goalPoints;
        }

        return _totalPoints;
    }

    public virtual void Display()
    {
        Console.WriteLine($"[{_x}] {_name} ({_description})");
    }

    public virtual string Serialize()
    {
        return $"type|{_name}|{_description}|{_goalPoints}|{_isFinished}";

    }

}