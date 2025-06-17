public abstract class Activity
{
    private DateTime _date;
    private double _lengthInMinutes;

    public Activity(string dateString, double lengthMinutes)
    {
        _lengthInMinutes = lengthMinutes;
        _date = DateTime.Parse(dateString);
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    protected abstract string ActivityTypeName();

    public string GetSummary()
    {
        return $"{GetDateString()} {ActivityTypeName()} ({GetLengthInMinutes()} min)- Distance {GetDistance().ToString("0.0")} miles, Speed {GetSpeed().ToString("0.0")} mph, Pace: {GetPace().ToString("0.0")} min per mile";
    }

    protected string GetDateString()
    {
        return _date.ToString("d MMM yyyy");
    }

    protected double GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }
}