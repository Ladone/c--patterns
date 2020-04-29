namespace FactorySimple.Model
{
    public class ClamPizza: Pizza
    {
        public ClamPizza()
        {
            name  = "NY Style Sauce and Clam Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");           
        }
    }
}