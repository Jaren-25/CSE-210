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

            return new SimpleGoal(isFinished, name, description, goalPoints);
        }

        else if(type == "eternal")
        {
            //return $"eternal|{_name}|{_description}|{_goalPoints}|{_isFinished}";
            string name = parts[1];
            string description = parts[2];
            int goalPoints = int.Parse(parts[3]);
            bool isFinished = bool.Parse(parts[4]);

            return new EternalGoal(isFinished, name, description, goalPoints );

        }

        else if(type == "checklist")
        {
            // return $"checklist|{_name}|{_description}|{_goalPoints}|{_isFinished}|{_loopAmt}|{_amtLooped}|{_bonusPoint}";
            string name = parts[1];
            string description = parts[2];
            int goalPoints = int.Parse(parts[3]);
            bool isFinished = bool.Parse(parts[4]);
            int loopAmt = int.Parse(parts[5]);
            int amtLooped = int.Parse(parts[6]);
            int bonusPoint = int.Parse(parts[7]);

            //int loopAmt, int amtLooped, int bonusPoint, bool isFinished, string name, string desription, int totalPoints
            return new ChecklistGoal(loopAmt, amtLooped, bonusPoint, isFinished, name, description, goalPoints );

        }

        return null;
    }
}