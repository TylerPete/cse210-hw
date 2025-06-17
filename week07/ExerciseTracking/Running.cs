using System.Diagnostics;

public class Running : Activity
{
    private double _distanceMiles;

    public Running(string dateString, double lengthMinutes, double distance) : base(dateString, lengthMinutes)
    {
        _distanceMiles = distance;
    }

    public override double GetDistance()
    {
        return _distanceMiles;
    }

    public override double GetSpeed()
    {
        double hours = GetLengthInMinutes() / 60;

        //miles    per   hour
        return _distanceMiles / hours;
    }

    protected override string ActivityTypeName()
    {
        return "Running";
    }

    public override double GetPace()
    {
        return GetLengthInMinutes() / _distanceMiles;
    }
}