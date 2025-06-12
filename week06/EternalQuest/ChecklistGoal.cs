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

    public override int RecordEvent()
    {
        _amountCompleted++;
        bool bonusBool = _amountCompleted == _target;
        int bonus = 0;
        if (bonusBool) { bonus = _bonusPoints; }

        return GetPointValue() + bonus;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string result = "";
        if (IsComplete())
        {
            result += "[X]";
        }
        else
        {
            result += "[ ]";
        }
        return $"{result} {GetGoalName()}: {GetGoalDescription()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist~{GetGoalName()}~{GetGoalDescription()}~{GetPointValue()}~{_target}~{_bonusPoints}~{_amountCompleted}";
    }
}