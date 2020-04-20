using System;

namespace Decorator.Model
{
    public abstract class CondimentDecorator: Beverage
    {
        public abstract override string getDescription();
    }
}