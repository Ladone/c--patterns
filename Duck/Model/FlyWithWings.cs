using System;
using Duck.Behaviour;

namespace Duck
{
    public class FlyWithWings: FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
