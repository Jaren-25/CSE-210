public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;

    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public int GetTop()
    {
        //Console.WriteLine(_top);
        return _top;
    }

    public int GetBottom()
    {
        //Console.WriteLine(_bottom);
        return _bottom;
    }

    public string GetFractionString()
    {
        string fracOutput = $"{_top}/{_bottom}";
        //Console.WriteLine(fracOutput);
        return fracOutput;
    }

    public double GetDecimalValue()
    {
        double decOutput = (double)_top / _bottom;
        //Console.WriteLine(decOutput);
        return decOutput;
    }


}