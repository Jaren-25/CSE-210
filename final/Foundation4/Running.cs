public class Running : Exercise
{
    public double _runDist;

    public Running(double runDist, string date, int duration) : base(date, duration)
    {
        _runDist = runDist;
        _date = date;
        _duration = duration;
    }


    public override double CalcDist()
    {
        return _runDist;
    }

    public override double CalcPace()
    {
        return _duration / _runDist;
    }

    public override double CalcSpeed()
    {
        return (_runDist / _duration) * 60;
    }
}