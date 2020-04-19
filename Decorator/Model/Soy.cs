using System;

namespace Decorator.Model
{
    public class Soy: CondimentDecorator
    {
        public Beverage Beverage;

        public Soy(Beverage beverage)
        {
            this.Beverage = beverage;
        }
        
        public override string getDescription()
        {
            return String.Format("{0}, {1}", this.Beverage.getDescription(), "Soy");
        }

        public override double cost()
        {
            return .15 + Beverage.cost();
        }
    }
}