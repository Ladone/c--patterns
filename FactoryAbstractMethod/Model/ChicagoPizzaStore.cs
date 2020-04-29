using System;

namespace Factory.Model
{
    public class ChicacgoPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza;

            if (type.Equals("cheese"))
            { 
                return new ChicagoStyleCheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                return new ChicagoStyleVeggiePizza();
            }
            
            throw new Exception("Type of pizza not found");
        }
    }
}