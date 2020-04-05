using System;
using Adventure.Entity.Behavior;

namespace Adventure.Entity
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