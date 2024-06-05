public class Swimming : Activity
{
    private int _laps;
    private double LapDistance = 50; // lap length in meters

    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * LapDistance) / 1000 * 0.62; // distance in miles
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / base._length) * 60; // speed in mph
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return base._length / distance; // pace in minutes per mile
    }

}