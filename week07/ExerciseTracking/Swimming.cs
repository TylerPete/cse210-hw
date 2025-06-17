public class Swimming : Activity
{
    private int _numLaps;

    public Swimming(string dateString, double lengthMinutes, int numLaps) : base(dateString, lengthMinutes)
    {
        _numLaps = numLaps;
    }

    public override double GetPace()
    {
        //stub
    }

    public override double GetSpeed()
    {
        //stub
    }

    public override double GetDistance()
    {
        //stub
    }

    protected override string ActivityTypeName()
    {
        //stub
    }

}