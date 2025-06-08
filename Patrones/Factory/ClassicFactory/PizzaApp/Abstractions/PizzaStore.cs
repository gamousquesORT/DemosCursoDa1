namespace PizzaApp.Abstractions;

public abstract class PizzaStore
{
    protected abstract Pizza CreatePizza();

    public Pizza OrderPizza()
    {
        Pizza pizza = CreatePizza();
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;
    }
}