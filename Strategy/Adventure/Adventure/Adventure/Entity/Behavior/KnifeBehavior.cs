using System;
using Adventure.Interface;

namespace Adventure.Entity.Behavior
{
    public class KnifeBehavior: IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Use Knife\n");
        }
    }
}