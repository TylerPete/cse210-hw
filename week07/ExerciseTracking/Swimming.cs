public class Swimming : Activity
{
    private int _numLaps;

    public Swimming(string dateString, double lengthMinutes, int numLaps) : base(dateString, lengthMinutes)
    {
        _numLaps = numLaps;
    }

    public override double GetPace()
    {
        return (1 / GetSpeed()) * 60;
    }

    public override double GetSpeed()
    {
        return (_numLaps * 0.0310686) / (GetLengthInMinutes() / 60);
    }

    public override double GetDistance()
    {
        return _numLaps * 0.0310686;
    }

    protected override string ActivityTypeName()
    {
        return "Swimming";
    }

}