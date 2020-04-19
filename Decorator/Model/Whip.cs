using System;

namespace Decorator.Model
{
    public class Whip: CondimentDecorator
    {
        protected Beverage Beverage;

        public Whip(Beverage beverage)
        {
            this.Beverage = beverage;
        }
        
        
        public override string getDescription()
        {
            return String.Format("{0}, {1}", Beverage.getDescription(), "Soy");
        }

        public override double cost()
        {
            return .10 + Beverage.cost();;
        }
    }
}