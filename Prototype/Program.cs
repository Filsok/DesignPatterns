using System.Globalization;
using Prototype;

Circle circle1 = new Circle()
{
    Radius = 5,
    X = 1,
    Y = 2,
    Border = new Border
    {
        Color = "red",
        Size = "2px"
    }
};

Circle circle2 = (Circle)circle1.Clone();

var referenceEquals = ReferenceEquals(circle2, circle1);
Console.WriteLine($"referenceEquals = {referenceEquals}");

var borderReferenceEquals = ReferenceEquals(circle2.Border, circle1.Border);
Console.WriteLine($"borderReferenceEquals = {borderReferenceEquals}");
