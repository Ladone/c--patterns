using System;
using Strategy.Interface;

namespace Strategy.Entity.Behavior
{
    public class KnifeBehavior: IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Use Knife\n");
        }
    }
}