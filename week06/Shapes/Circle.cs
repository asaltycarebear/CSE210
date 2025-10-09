using System.Net.NetworkInformation;

class Circle : Shape
{
    private double _radius;
    private double _pi = Math.PI; //I suppose I could have just put Math.PI in the formula for the area...

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * _pi;
    }
}