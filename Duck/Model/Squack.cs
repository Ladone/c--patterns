using System;
using Duck.Behaviour;

namespace Duck
{
    public class Squack: QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeack");
        }
    }
}
