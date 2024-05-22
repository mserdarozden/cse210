using System;
using System.Data;
using System.Formats.Asn1;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 5);
        double areaSquare = square.GetArea();
        //Console.WriteLine($"Area of square = {areaSquare}");

        Rectangle rectangle = new Rectangle("red", 5, 4);
        double areaRectangle = rectangle.GetArea();
        //Console.WriteLine($"Area of rectangle = {areaRectangle}");

        Circle circle = new Circle("yellow", 6);
        double areaCircle = circle.GetArea();
        //Console.WriteLine($"Area of circle = {areaCircle}");

        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(rectangle);
        shapeList.Add(square);
        shapeList.Add(circle);

        foreach (Shape shape in shapeList)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine($"Area = {area} Color = {color}");
        }

    }
}