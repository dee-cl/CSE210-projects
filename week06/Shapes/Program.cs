using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("blue", 10);
        Circle c1 = new Circle("red", 3);
        Rectangle r1 = new Rectangle("green", 3, 12);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s1);
        shapes.Add(c1);
        shapes.Add(r1);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The color of the shape is {color} and the area is {area}");
        }
    }
}