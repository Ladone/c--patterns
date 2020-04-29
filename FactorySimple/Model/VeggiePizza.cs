namespace FactorySimple.Model
{
    public class VeggiePizza: Pizza
    {
        public VeggiePizza()
        {
            name  = "NY Style Sauce and Pineapple Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}