public abstract class Goal
{
    private string _goalName;
    private string _description;
    private int _pointValue;

    public Goal(string name, string description, int pointValue)
    {
        _goalName = name;
        _description = description;
        _pointValue = pointValue;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        //code for default behavior (will be adopted by SimpleGoal and EternalGoal)
        string result = "";
        if (IsComplete())
        {
            result += "[X]";
        }
        else
        {
            result += "[ ]";
        }
        return $"{result} {_goalName}: {_description}";
    }

    public abstract string GetStringRepresentation();
}