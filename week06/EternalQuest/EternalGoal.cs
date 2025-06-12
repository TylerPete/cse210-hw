public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int pointValue) : base(name, description, pointValue)
    {

    }

    public override int RecordEvent()
    {
        return GetPointValue();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal~{GetGoalName()}~{GetGoalDescription()}~{GetPointValue()}";
    }
}