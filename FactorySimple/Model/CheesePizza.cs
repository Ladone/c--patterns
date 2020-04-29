namespace FactorySimple.Model
{
    public class CheesePizza: Pizza
    {
        public CheesePizza()
        {
            name  = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}