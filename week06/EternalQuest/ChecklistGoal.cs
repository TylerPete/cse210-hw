public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int pointValue, int target, int bonus) : base(name, description, pointValue)
    {
        _target = target;
        _bonusPoints = bonus;
    }

    public override void RecordEvent()
    {
        //code
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        //code
    }

    public override string GetStringRepresentation()
    {
        //code
    }
}