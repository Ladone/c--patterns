using System;
using Duck.Behaviour;

namespace Duck
{
    public class MallardDuck: Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
        
        public override void display()
        {
            Console.WriteLine("I'm real Mallard duck");
        }
    }
}