using System;
using Factory.Model;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fabric Pizza");
            
            PizzaStore pizzaStore = new NYPizzaStore();
            Pizza pizza = pizzaStore.orderPizza("cheese");
            Console.WriteLine(String.Format("Ethan ordered a {0} ", pizza.getName()));
        }
    }
}