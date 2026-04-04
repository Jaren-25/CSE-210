public class Swimming : Exercise
{
    private int _laps;

    public Swimming(int laps, string date, int duration) : base(date, duration)
    {
        _laps = laps;
        _date = date;
        _duration = duration;
    }

    public override double CalcDist()
    {
        return _laps * 50 /1000 *.62;
    }



    public override double CalcSpeed()
    {
        return (CalcDist() / _duration) *60;
    }
}