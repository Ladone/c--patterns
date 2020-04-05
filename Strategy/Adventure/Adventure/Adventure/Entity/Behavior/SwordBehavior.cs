using System;
using Adventure.Interface;

namespace Adventure.Entity.Behavior
{
    public class SwordBehavior: IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Use Sword\n");
        }

    }
}