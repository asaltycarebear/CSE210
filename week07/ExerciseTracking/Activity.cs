using System;

public abstract class Activity
{
    private DateTime _date;
    private double _length;

    public Activity(DateTime date, double length)
    {
        _date = date;
        _length = length;
    }

    public DateTime Date => _date;
    public double Length => _length;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} ({_length} min) - Distance: {GetDistance():0.00}, Speed: {GetSpeed():0.00}, Pace: {GetPace():0.00}";
    }
}
