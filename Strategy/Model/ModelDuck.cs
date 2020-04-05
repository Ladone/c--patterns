using System;

namespace Duck
{
    public class ModelDuck: Duck
    {
        public ModelDuck()
        {
            flyBehavior   = new FlyNoWay();
            quackBehavior = new Quack();
        }
        
        public override void display()
        {
            Console.WriteLine("I‘m model duck");
        }
    }
}