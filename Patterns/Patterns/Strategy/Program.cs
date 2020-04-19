using System;
using Strategy.Entity;
using Strategy.Entity.Behavior;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // init
            Console.WriteLine("Adventure Castle Game v1.0");

            Character king   = new King();
            Character queen  = new Queen();
            Character knight = new Knight();
            Character troll  = new Troll();

            king.Display();
            king.Fight();

            queen.Display();
            queen.Fight();

            knight.Display();
            knight.Fight();

            troll.Display();
            troll.Fight();

            Console.WriteLine();

            // change weapon
            king.Display();
            king.SetWeapon(new BowAndArrowBehavior());
            king.Fight();

            queen.Display();
            queen.SetWeapon(new KnifeBehavior());
            queen.Fight();

            knight.Display();
            knight.SetWeapon(new AxeBehavior());
            knight.Fight();

            troll.Display();
            troll.SetWeapon(new SwordBehavior());
            troll.Fight();

            Console.WriteLine("End fight");
        }
    }
}