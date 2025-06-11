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

    public string GetDetailsString()
    {
        //code for default behavior (will be adopted by SimpleGoal and EternalGoal)
    }

    public abstract string GetStringRepresentation();
}