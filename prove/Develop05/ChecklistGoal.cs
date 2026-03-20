public class ChecklistGoal : Goal
{
    private int _loopAmt;
    private int _amtLooped;
    private int _bonusPoint;
    private bool _isFinished;

    public ChecklistGoal()
    {

    }

    public ChecklistGoal(int loopAmt, int amtLooped, int bonusPoint, bool isFinished, int totalPoints, string name, string desription)
    {
        _loopAmt = loopAmt;
        _amtLooped = amtLooped;
        _bonusPoint = bonusPoint;
        _isFinished = isFinished;
        _totalPoints = totalPoints;
        _name = name;
        _description = desription;
    }

    public override void scorePoints()
    {
        if (_isFinished == true)
        {
            _totalPoints = _totalPoints + _goalPoints;
        }

        if(_amtLooped == _loopAmt)
        {
            _totalPoints = _totalPoints + _bonusPoint;
        }
    }

    public override void Display()
    {
        Console.WriteLine($"");
    }

    public override string Serialize()
    {
        return $"{_name}|{_description}|{_goalPoints}";
    }
}