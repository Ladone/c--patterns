using System;
using Strategy.Interface;

namespace Strategy.Entity.Behavior
{
    public class SwordBehavior: IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Use Sword\n");
        }

    }
}