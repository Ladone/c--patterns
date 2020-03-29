using System;
using Duck.Behaviour;

namespace Duck
{
    public class MuteQuack: QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}