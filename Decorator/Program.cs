using System;
using System.IO;
using Decorator.Model;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Decorator");
            Console.Write("This program show to you 2 example.\n1. Coffee\n2. Text to lower\nSelect you example: ");
            var example = Console.ReadLine();
            Console.WriteLine();

            if (example == "1")
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
            } else
            {
                Console.Write("Write your path to text file: ");
                var filepath = Console.ReadLine();

                try
                {
                    using (LowerCaseInputStream reader = new LowerCaseInputStream(filepath))
                    {
                        while (true)
                        {
                            var line = reader.ReadLine();
                            if (line == null)
                            {
                                break;
                            }
                            Console.WriteLine(line); // Use line.
                        }
                    }
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}