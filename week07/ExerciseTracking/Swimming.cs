public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, double length, int laps) 
        : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Length) * 60;
    }

    public override double GetPace()
    {
        return Length / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date:dd MMM yyyy} Swimming ({Length} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
