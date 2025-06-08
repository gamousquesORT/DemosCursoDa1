namespace PizzaApp.Abstractions;

public abstract class Pizza
{
    public string Name { get; protected set; }

    public virtual void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
    }

    public virtual void Bake()
    {
        Console.WriteLine("Baking...");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cutting...");
    }

    public virtual void Box()
    {
        Console.WriteLine("Boxing...");
    }
}