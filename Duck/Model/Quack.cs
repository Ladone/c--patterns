using System;
using Duck.Behaviour;

namespace Duck
{
    public class Quack: QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}