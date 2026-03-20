class GoalParser
{
    public Goal CreateItem(string data)
    {
        string[] parts = data.Split("|");
        string type = parts[0];

        if(type == "simple")
        {
            //$"simple|{_name}|{_description}|{_goalPoints}|{_isFinished}";
            string name = parts[1];
            string description = parts[2];
            int goalPoints = int.Parse(parts[3]);
            bool isFinished = bool.Parse(parts[4]);

            return new SimpleGoal(isFinished, name, description, goalPoints );
        }

        else if(type == "eternal")
        {

        }

        else if(type == "checklist")
        {

        }

        return null;
    }
}