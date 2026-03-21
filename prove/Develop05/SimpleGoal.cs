public class SimpleGoal : Goal
{

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

    public override int scorePoints()
    {
        if (_isFinished == true)
        {
            _totalPoints = _totalPoints + _goalPoints;
        }
        return _totalPoints;
    }

    public override void Display()
    {
        Console.WriteLine($"[{_x}] {_name} ({_description})");
    }

    public override string Serialize()
    {
        return $"simple|{_name}|{_description}|{_goalPoints}|{_isFinished}";
    }


}