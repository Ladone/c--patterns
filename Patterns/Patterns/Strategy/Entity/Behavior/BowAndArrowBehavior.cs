using System;
using Strategy.Interface;

namespace Strategy.Entity.Behavior
{
    public class BowAndArrowBehavior: IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Use Bow and Arrow\n");
        }
    }
}