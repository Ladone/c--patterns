using System;
using Decorator.Model;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            espresso.DisplayCost();
            
            Beverage darkRoast = new DarkRoast();
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Whip(darkRoast);
            darkRoast.DisplayCost();
            
            Beverage houseBland = new HouseBland();
            houseBland = new Soy(houseBland);
            houseBland = new Mocha(houseBland);
            houseBland = new Whip(houseBland);
            houseBland.DisplayCost();
        }
    }
}