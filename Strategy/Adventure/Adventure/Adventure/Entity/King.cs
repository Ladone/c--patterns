using System;
using Adventure.Entity.Behavior;

namespace Adventure.Entity
{
    public class King: Character
    {
        public King()
        {
            this.SetWeapon(new AxeBehavior());
        }

        public override void Display()
        {
            Console.WriteLine("King");
        }
    }
}