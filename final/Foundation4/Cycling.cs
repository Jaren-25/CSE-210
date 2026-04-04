public class Cycling : Exercise
{
    private double _cycSpeed;

    public Cycling(double cycSpeed, string date, int duration) : base(date, duration)
    {
        _cycSpeed = cycSpeed;
        _date = date;
        _duration = duration;
    }
    public override double CalcDist()
    {
        return _cycSpeed * _duration / 60;
    }


    public override double CalcSpeed()
    {
        return _cycSpeed;
    }
}