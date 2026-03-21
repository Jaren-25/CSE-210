using System.Security.Cryptography.X509Certificates;

public class Goal
{
    protected int _totalPoints;
    protected int _goalPoints;
    protected string _name;
    protected string _description;
    protected bool _isFinished;
    protected string _x = "";
    protected Goal _chosen;

    public Goal()
    {

    }

    public Goal(int totalPoints)
    {
        _totalPoints = totalPoints;
    }


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


    public virtual int scorePoints()
    {
        // Console.WriteLine("yat");
        // Console.WriteLine($"{_isFinished}..");
        if (_isFinished != true)
        {
            _totalPoints = _totalPoints + _goalPoints;
            _isFinished = true;
        }
        return _totalPoints;
    }

    public virtual void Display()
    {
        Console.WriteLine($"[{Complete()}] {_name} ({_description})");
    }

    public virtual string Serialize()
    {
        return $"type|{_name}|{_description}|{_goalPoints}|{_isFinished}";
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void SetTotalPoints(int totalpoints)
    {
        _totalPoints = totalpoints;
    }

    public int GetPoints()
    {
        return _goalPoints;
    }

    public bool GetIsFinished()
    {
        return _isFinished;
    }

    public void SetIsFinished(bool isFinished)
    {
        _isFinished = isFinished;
    }

    public Goal getChosen()
    {
        return _chosen;
    }
    public void SetChosen(Goal chosen)
    {
        _chosen = chosen;
    }

}