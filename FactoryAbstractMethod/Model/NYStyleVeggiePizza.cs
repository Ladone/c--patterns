namespace Factory.Model
{
    public class NYStyleVeggiePizza: Pizza
    {
        public NYStyleVeggiePizza()
        {
            name = "NY Style Sauce and Pineapple Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}