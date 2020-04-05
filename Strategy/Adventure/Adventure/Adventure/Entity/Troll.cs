using System;

namespace Adventure.Entity.Behavior
{
    public class Troll: Character
    {
        public Troll()
        {
            this.SetWeapon(new KnifeBehavior());
        }
        
        public override void Display()
        {
            Console.WriteLine("Troll");
        }
    }
}