using System;
using Strategy.Entity.Behavior;

namespace Strategy.Entity
{
    public class Queen: Character
    {
        public Queen()
        {
            this.SetWeapon(new BowAndArrowBehavior());
        }
        
        public override void Display()
        {
            Console.WriteLine("Queen");
        }
    }
}