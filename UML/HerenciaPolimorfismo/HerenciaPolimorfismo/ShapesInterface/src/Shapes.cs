namespace Drawings;

using System;


class Rectangle : IDrawingElement
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double GetArea()
    {
        return length * width;
    }
    
    public void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

class Circle : IDrawingElement
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }
 
    public void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}


