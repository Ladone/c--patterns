using System;

namespace FactorySimple.Model
{
    public class SimplePizzaFactory
    {
        public Pizza createPizza(string type)
        {
            try
            {
                Pizza pizza = null;

                if (type.Equals("cheese"))
                {
                    pizza = new CheesePizza();
                }
                else if (type.Equals("veggie"))
                {
                    pizza = new VeggiePizza();
                }
                else if (type.Equals("clam"))
                {
                    pizza = new ClamPizza();
                }
                else if (type.Equals("peperoni"))
                {
                    pizza = new PepperoniPizza();
                }


                return pizza;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}