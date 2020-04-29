using System;
using Factory.Model;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fabric Pizza");
            
            PizzaStore nyPizzaStore = new NYPizzaStore();
            Pizza nyPizza = nyPizzaStore.orderPizza("cheese");
            Console.WriteLine(String.Format("Ethan ordered a {0} ", nyPizza.getName()));

            PizzaStore chicagoPizzaStore = new ChicacgoPizzaStore();
            Pizza chicagoPizza = chicagoPizzaStore.orderPizza("cheese");
            Console.WriteLine(String.Format("Ethan ordered a {0} ", chicagoPizza.getName()));
        }
    }
}