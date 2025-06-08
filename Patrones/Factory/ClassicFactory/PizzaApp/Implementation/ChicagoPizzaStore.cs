using PizzaApp.Abstractions;

namespace PizzaApp.Implementation;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza()
    {
        return new ChicagoStyleCheesePizza();
    }
}