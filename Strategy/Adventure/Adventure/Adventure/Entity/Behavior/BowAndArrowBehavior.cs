using System;
using Adventure.Interface;

namespace Adventure.Entity.Behavior
{
    public class BowAndArrowBehavior: IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Use Bow and Arrow\n");
        }
    }
}