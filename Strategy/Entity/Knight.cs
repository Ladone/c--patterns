using System;
using Strategy.Entity.Behavior;

namespace Strategy.Entity
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