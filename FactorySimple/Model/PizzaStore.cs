namespace FactorySimple.Model
{
    public class PizzaStore
    {
        private SimplePizzaFactory _factory;
        
        public PizzaStore(SimplePizzaFactory factory)
        {
            this._factory = factory;
        }

        public Pizza orderPizza(string type)
        {
            Pizza pizza;
            
            pizza = _factory.createPizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
    }
}