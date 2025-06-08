using System;
using PizzaStoreSimpleFactory.Pizzas;
using PizzaStoreSimpleFactory.SimpleFactories;

namespace PizzaStoreSimpleFactory
{
    class Program
    {

        public static void Main(string[] args)
        {
            PizzaStore store = new PizzaStore();

            Pizza pizza = store.OrderPizza("Cheese");
            Console.WriteLine("We ordered a " + pizza.Name);

            pizza = store.OrderPizza("Veggie");
            Console.WriteLine("We ordered a " + pizza.Name);
        }
    }
}
