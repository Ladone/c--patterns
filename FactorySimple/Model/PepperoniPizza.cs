namespace FactorySimple.Model
{
    public class PepperoniPizza: Pizza
    {
        public PepperoniPizza()
        {
            name  = "NY Style Sauce and Pepperoni Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}