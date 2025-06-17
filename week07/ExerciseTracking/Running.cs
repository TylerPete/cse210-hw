using System.Diagnostics;

public class Running : Activity
{
    private double _distance;

    public Running(string dateString, double lengthMinutes, double distance) : base(dateString, lengthMinutes)
    {
        _distance = distance;
    }
}