public class ChecklistGoal : Goal
{
    private int _loopAmt;
    private int _amtLooped;
    private int _bonusPoint;


    public ChecklistGoal()
    {

    }

    public ChecklistGoal(int loopAmt, int amtLooped, int bonusPoint, bool isFinished, string name, string desription, int totalPoints)
    {
        _loopAmt = loopAmt;
        _amtLooped = amtLooped;
        _bonusPoint = bonusPoint;
        _isFinished = isFinished;
        _totalPoints = totalPoints;
        _name = name;
        _description = desription;
    }

    public override int scorePoints()
    {
        if (_isFinished == true)
        {
            _totalPoints = _totalPoints + _goalPoints;
        }

        if(_amtLooped == _loopAmt)
        {
            _totalPoints = _totalPoints + _bonusPoint;
        }

        return _totalPoints;
    }

    public override void Display()
    {
        Console.WriteLine($"[{Complete()}] {_name} ({_description}) -- Currently completed: {_amtLooped}/{_loopAmt}");

    }

    public override string Serialize()
    {
        return $"checklist|{_name}|{_description}|{_goalPoints}|{_isFinished}|{_loopAmt}|{_amtLooped}|{_bonusPoint}";
    }
}