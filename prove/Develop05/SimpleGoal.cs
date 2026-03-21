public class SimpleGoal : Goal
{

    public SimpleGoal()
    {

    }
    public SimpleGoal(bool isFinished,  string name, string desription, int goalPoints)
    {
        _isFinished = isFinished;
        _name = name;
        _description = desription;
        _goalPoints = goalPoints;
    }


    // public void Display();
    // // {
    // //     //Console.WriteLine($"[{Complete()}] {_name} ({_description})");
    // // }

    public override string Serialize()
    {
        return $"simple|{_name}|{_description}|{_goalPoints}|{_isFinished}";
    }


}