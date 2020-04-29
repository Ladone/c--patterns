using System;

namespace Factory.Model
{
    public class ChicagoStyleVeggiePizza: Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            name = "Chicago Style Deep Dish with Pineapple Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredered Mozzarella Cheese");
        }

        protected void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}