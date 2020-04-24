namespace Factory.Model
{
    public class NYStylePepperoniPizza: Pizza
    {
        public NYStylePepperoniPizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}