using System;

namespace Duck
{
    public class MyDuck: Duck
    {
        public override void display()
        {
            Console.WriteLine("My Strategy");
        }
    }
}