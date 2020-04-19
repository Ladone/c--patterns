using System;
using Decorator.Model;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            Console.WriteLine(String.Format("{0}, ${1}\n", espresso.getDescription(), espresso.cost().ToString()));

            Beverage houseBland = new HouseBland();
            houseBland = new Soy(houseBland);
            houseBland = new Mocha(houseBland);
            houseBland = new Whip(houseBland);
            Console.WriteLine(String.Format("{0}, ${1}\n", houseBland.getDescription(), houseBland.cost().ToString()));
        }
    }
}