using PizzaApp.Implementation;
using PizzaApp.Abstractions;
class Program
{
    static void Main()
    {
        PizzaStore nyStore = new NYPizzaStore();
        PizzaStore chicagoStore = new ChicagoPizzaStore();

        Console.WriteLine("Ordering from NY store:");
        nyStore.OrderPizza();

        Console.WriteLine("\nOrdering from Chicago store:");
        chicagoStore.OrderPizza();
    }
}