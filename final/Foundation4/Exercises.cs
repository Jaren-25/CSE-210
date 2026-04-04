public abstract class Exercise
{
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected string _date;
    protected int _duration;

    public Exercise(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual double CalcDist()
    {
        return _distance;
    }

    public abstract double CalcSpeed();

    public virtual double CalcPace()
    {
        return _duration / CalcDist();
    }

    public string GetSummary()
    {
        return $"{_date} {GetType()} ({_duration} min)- Distance {CalcDist().ToString("F2")} miles, Speed: {CalcSpeed().ToString("F2")} mph, Pace: {CalcPace().ToString("F2")} min per mile";
    }

}
