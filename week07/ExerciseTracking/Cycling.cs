public class Cycling : Activity
{
    private double _speedMPH;

    public Cycling(string dateString, double lengthMinutes, double speedMPH) : base(dateString, lengthMinutes)
    {
        _speedMPH = speedMPH;
    }

    public override double GetPace()
    {
        return (1 / _speedMPH) * 60;
    }

    public override double GetDistance()
    {
        double hours = GetLengthInMinutes() / 60;
        return _speedMPH * hours;
    }

    public override double GetSpeed()
    {
        return _speedMPH;
    }

    protected override string ActivityTypeName()
    {
        return "Cycling";
    }
}