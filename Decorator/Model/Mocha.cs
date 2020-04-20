using System;

namespace Decorator.Model
{
    public class Mocha: CondimentDecorator
    {
        protected Beverage Beverage;

        public Mocha(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public override double Cost()
        {
            return .20 + Beverage.Cost();
        }

        public override string getDescription()
        {
            return String.Format("{0}, {1}", Beverage.getDescription(), "Mocha");
        }
    }
}