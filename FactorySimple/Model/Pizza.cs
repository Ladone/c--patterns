using System;
using System.Collections;

namespace FactorySimple.Model
{
    public abstract class Pizza
    {
        protected string name;
        protected string sauce;
        protected string dough;
        
        protected ArrayList toppings = new ArrayList();

        public void prepare()
        {
            Console.WriteLine(String.Format("Preparing {0}...", name));
            Console.WriteLine(String.Format("Tossing dough..."));
            Console.WriteLine(String.Format("Adding sauce..."));

            for (int i = 0; i < toppings.Count; i++)
            {
                Console.WriteLine(String.Format("    {0}", toppings[i]));
            }
        }

        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

    }
}