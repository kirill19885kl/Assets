using UnityEngine;

namespace Patterns.AbstractFactory.Weapon
{
    public class BlueFactory : WeaponFactory
    {
        public override Bow CreateBow()
        {
            var prefab = Resources.Load<GameObject>("Patterns/AbstarctFactory/Weapon/BlueBow");
            var obj = GameObject.Instantiate(prefab);
            var bow = obj.GetComponent<BlueBow>();

            bow.Init(0.6f, 2.5f);

            return bow;
        }

        public override Staff CreateStaff()
        {
            var prefab = Resources.Load<GameObject>("Patterns/AbstarctFactory/Weapon/BlueStaff");
            var obj = GameObject.Instantiate(prefab);
            var staff = obj.GetComponent<BlueStaff>();

            staff.Init(9.2f, 15);

            return staff;
        }

        public override Sword CreateSword()
        {
            var prefab = Resources.Load<GameObject>("Patterns/AbstarctFactory/Weapon/BlueSword");
            var obj = GameObject.Instantiate(prefab);
            var sword = obj.GetComponent<BlueSword>();

            sword.Init(6.3f);

            return sword;
        }
    }
}
