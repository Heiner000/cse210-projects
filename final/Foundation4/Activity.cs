public class Activity
{
    private string _date;
    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        return $"{_date} {GetType().Name} ({_length:F2} min)\nDistance: {distance:F2} miles\nSpeed: {speed:F2} mph\nPace: {pace:F2} min per mile";
    }

}