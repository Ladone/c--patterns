using System;
using Duck.Behaviour;

namespace Duck
{
    public class FlyNoWay: FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}