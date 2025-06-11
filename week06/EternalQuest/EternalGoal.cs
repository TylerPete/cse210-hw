public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int pointValue) : base(name, description, pointValue)
    {

    }

    public override void RecordEvent()
    {
        //code
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        //code
    }
}