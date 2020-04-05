using System;

namespace Duck.Behaviour
{
    public class FlyRocketPowered: FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I‘m flying with a rocket!");
        }
    }
}