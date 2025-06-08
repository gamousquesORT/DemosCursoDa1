using System;
using PizzaStoreSimpleFactory.Pizzas;
using PizzaStoreSimpleFactory.SimpleFactories;

namespace PizzaStoreSimpleFactory
{
    public class PizzaStore
    {
        private Pizza _ordered;
        
        public Pizza OrderPizza(string type)
        {
            try
            {
                _ordered = Pizza.CreatePizza(type);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            
            _ordered.Prepare();
            _ordered.Bake();
            _ordered.Cut();
            _ordered.Box();

            return _ordered;
        }
    }
}