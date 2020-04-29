using System;

namespace Factory.Model
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza;

            if (type.Equals("cheese"))
            { 
                return new NYStyleCheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                return new NYStyleVeggiePizza();
            }
            
            throw new Exception("Type of pizza not found");
        }
    }
}