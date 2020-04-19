using System;
using Strategy.Interface;

namespace Strategy.Entity.Behavior
{
    public class AxeBehavior: IWeaponBehavior
    {
        public void UseWeapon()
        {    
            Console.WriteLine("Use Axe\n");
        }
    }
}