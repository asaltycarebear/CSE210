using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("coral", 5);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("coral", 5, 10);
        shapes.Add(r1);

        Circle c1 = new Circle("coral", 3);
        shapes.Add(c1);

        foreach (Shape i in shapes)
        {
            string color = i.GetColor();
            double area = i.GetArea();
            string shape = i.GetType().Name; //This will assign the shape variable the class name. 

            Console.WriteLine($"This {shape} is {color} and has an area of {area:F2}"); //:F2 will make it only 2 decimal places (fixed point number)
        }

    }
}