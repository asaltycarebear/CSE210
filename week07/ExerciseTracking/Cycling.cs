public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, double length, double speed) 
        : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * Length) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{Date:dd MMM yyyy} Cycling ({Length} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
