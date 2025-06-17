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

    public abstract string ActivityTypeName();

    public string GetSummary()
    {
        return $"{GetDateString} {ActivityTypeName}";
    }

    protected string GetDateString()
    {
        return _date.ToString("d MMM yyyy");
    }
}