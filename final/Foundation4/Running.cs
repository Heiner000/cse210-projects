using System.Collections.Specialized;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;        
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / base._length) * 60; // mph
    }

    public override double GetPace()
    {
        return base._length / _distance; // pace in minutes per mile
    }

}
