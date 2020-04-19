using System;
using Strategy.Entity.Behavior;

namespace Strategy.Entity
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