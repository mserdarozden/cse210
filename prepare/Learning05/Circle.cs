using System.Security.Cryptography.X509Certificates;

public class Circle: Shape
{
    private double _radius;

    public Circle(string color, double radius): base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double area = Math.PI * _radius;
        return area;
    }
}