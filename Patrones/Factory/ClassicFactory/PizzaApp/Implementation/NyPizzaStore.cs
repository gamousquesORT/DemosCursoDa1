using PizzaApp.Abstractions;
namespace PizzaApp.Implementation;

public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza()
    {
        return new NYStyleCheesePizza();
    }
}

