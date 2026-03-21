public class EternalGoal : Goal
{
    public EternalGoal()
    {

    }

    public EternalGoal(bool isFinished, string name, string description, int goalPoints)
    {
        _isFinished = isFinished;
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
    }

    public override int scorePoints()
    {
        return _totalPoints;
    }

    public override string Serialize()
    {
        return $"eternal|{_name}|{_description}|{_goalPoints}|{_isFinished}";
    }
}