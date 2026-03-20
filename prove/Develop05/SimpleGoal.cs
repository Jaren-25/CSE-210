public class SimpleGoal : Goal
{
    private bool _isFinished;

    string x = "";

    public SimpleGoal()
    {

    }
    public SimpleGoal(bool isFinished,  string name, string desription, int goalPoints)
    {
        _isFinished = isFinished;
        _name = name;
        _description = desription;
        _goalPoints = goalPoints;
    }

    public override void scorePoints()
    {
        if (_isFinished == true)
        {
            _totalPoints = _totalPoints + _goalPoints;
        }
    }
    public string Complete()
    {
        if(_isFinished == true)
        {
            x = "X";
        }
        else
        {
            x = " ";
        }
        return x;
    }
    public override void Display()
    {
        Console.WriteLine($"[{x}]{_name} ({_description})");
    }

    public override string Serialize()
    {
        return $"simple|{_name}|{_description}|{_goalPoints}|{_isFinished}";
    }


}