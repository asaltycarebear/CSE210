public class Running : Activity
{
    private double _distance;
    public Running(DateTime date, double length, double distance) 
        : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / Length) * 60;
    }

    public override double GetPace()
    {
        return Length / _distance;
    }

    public override string GetSummary()
    {
        return $"{Date:dd MMM yyyy} Running ({Length} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
