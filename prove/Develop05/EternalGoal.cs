public class EternalGoal : Goal
{
    private string PH;
    public EternalGoal()
    {

    }

    public override void scorePoints()
    {

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