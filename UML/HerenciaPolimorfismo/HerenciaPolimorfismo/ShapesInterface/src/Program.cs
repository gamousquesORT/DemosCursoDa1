using System;
namespace Drawings;

class Program
{
    static void Main(string[] args)
    {
        Rectangle shape1 = new Rectangle(5, 10);
        Console.WriteLine("Rectangle Area: " + shape1.GetArea());

        Circle shape2 = new Circle(7);
        Console.WriteLine("Circle Area: " + shape2.GetArea());
        
        Toy toy1 = new Toy(2.3, 4.5) {Name = "Woody", Description = "Sheriff", Materials = "Wood"};
        Console.WriteLine("Toy Name: {0} - Description: {1} - Material: {2}\n\n", toy1.Name, toy1.Description, toy1.Materials);
        
        // Usemos el polimorfismo
        Console.WriteLine("-- Ver como se dibujan las figuras usando polimorfismo --\n");
        List<IDrawingElement> drawingShapes = new List<IDrawingElement>();
        drawingShapes.Add(shape1);
        drawingShapes.Add(shape2);
        drawingShapes.Add(toy1);

        ListDrawingData(drawingShapes);

    }

    public static void ListDrawingData(List<IDrawingElement> drawings)
    {
        foreach (var d in drawings)
        {
            d.Draw();
            Console.WriteLine("Area: {0}\n", d.GetArea());
        }
    }
}