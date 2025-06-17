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
        //implement here
    }
}