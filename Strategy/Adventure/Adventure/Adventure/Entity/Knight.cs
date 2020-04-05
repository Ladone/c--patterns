using System;
using Adventure.Entity.Behavior;

namespace Adventure.Entity
{
    public class Knight: Character
    {
        public Knight()
        {
            this.SetWeapon(new SwordBehavior());
        }
        
        public override void Display()
        {
            Console.WriteLine("Knight");
        }
    }
}