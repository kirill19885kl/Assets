using UnityEngine;

namespace Patterns.AbstractFactory.Weapon
{
    public abstract class WeaponFactory
    {
        public abstract Sword CreateSword();
        public abstract Bow CreateBow();
        public abstract Staff CreateStaff();
    }
}
