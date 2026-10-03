using UnityEngine;

namespace Patterns.AbstractFactory.Weapon
{
    public class GreenFactory : WeaponFactory
    {
        public override Bow CreateBow()
        {
            var prefab = Resources.Load<GameObject>("Patterns/AbstarctFactory/Weapon/GreenBow"); 
            var obj = GameObject.Instantiate(prefab);
            var bow = obj.GetComponent<GreenBow>();

            bow.Init(0.5f, 3.5f);

            return bow;
        }

        public override Staff CreateStaff()
        {
            var prefab = Resources.Load<GameObject>("Patterns/AbstarctFactory/Weapon/GreenStaff");
            var obj = GameObject.Instantiate(prefab);
            var staff = obj.GetComponent<GreenStaff>();

            staff.Init(12.3f, 30);

            return staff;
        }

        public override Sword CreateSword()
        {
            var prefab = Resources.Load<GameObject>("Patterns/AbstarctFactory/Weapon/GreenSword");
            var obj = GameObject.Instantiate(prefab);
            var sword = obj.GetComponent<GreenSword>();

            sword.Init(3.3f);

            return sword;
        }
    }
}
