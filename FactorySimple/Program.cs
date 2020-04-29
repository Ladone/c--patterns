using System;
using FactorySimple.Model;

namespace FactorySimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Facory");

            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore pizzaStore = new PizzaStore(factory);

            pizzaStore.orderPizza("cheese");
        }
    }
}