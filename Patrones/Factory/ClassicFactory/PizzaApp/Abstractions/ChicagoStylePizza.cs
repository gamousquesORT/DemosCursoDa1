namespace PizzaApp.Abstractions;

public class ChicagoStyleCheesePizza : Pizza
{
    public ChicagoStyleCheesePizza()
    {
        Name = "Chicago Style Cheese Pizza";
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting the pizza into square slices");
    }
}