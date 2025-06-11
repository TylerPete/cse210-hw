public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int pointValue) : base(name, description, pointValue)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        ///code   
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        //code
    }
}