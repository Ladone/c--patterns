using System;
using Adventure.Interface;

namespace Adventure.Entity.Behavior
{
    public class AxeBehavior: IWeaponBehavior
    {
        public void UseWeapon()
        {    
            Console.WriteLine("Use Axe\n");
        }
    }
}