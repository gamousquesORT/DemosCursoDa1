namespace Drawings;

public class Toy : IDrawingElement
{
    private double _side1 =0.0;
    private double _side2 =0.0;
    public Toy(double side1, double side2)
    {
        _side1 = side1;
        _side2 = side2;

    }
    public string? Name  { get; set; }
    public string? Description { get; set; }
    public string? Materials { get; set; }
    
    public double GetArea()
    {
        return _side1 * _side2;
    }
    
    public void Draw()
    {
        Console.WriteLine("Drawing a toy");
    }
}