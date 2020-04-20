using System;

namespace Decorator.Model
{
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        public virtual string getDescription()
        {
            return description;
        }

        public void DisplayCost()
        {
            Console.WriteLine(String.Format("{0}, ${1}\n", getDescription(), Cost().ToString()));
        }

        public abstract double Cost();
    }
}