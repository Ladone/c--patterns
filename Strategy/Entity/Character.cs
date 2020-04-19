using Strategy.Interface;

namespace Strategy.Entity
{
    public abstract class Character
    {
        private IWeaponBehavior _weaponBehavior;
        
        public void Fight()
        {
            _weaponBehavior.UseWeapon();
        }

        public void SetWeapon(IWeaponBehavior weapon)
        {
            this._weaponBehavior = weapon;
        }

        public abstract void Display();
    }
}