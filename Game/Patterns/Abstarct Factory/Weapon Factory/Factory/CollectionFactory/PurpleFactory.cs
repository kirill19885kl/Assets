using UnityEngine;

namespace Patterns.AbstractFactory.Weapon
{
    public class PurpleFactory : WeaponFactory
    {
        public override Bow CreateBow()
        {
            var prefab = Resources.Load<GameObject>("Patterns/AbstarctFactory/Weapon/PurpleBow");
            var obj = GameObject.Instantiate(prefab);
            var bow = obj.GetComponent<PurpleBow>();

            bow.Init(1f, 5.2f);

            return bow;
        }

        public override Staff CreateStaff()
        {
            var prefab = Resources.Load<GameObject>("Patterns/AbstarctFactory/Weapon/PurpleStaff");
            var obj = GameObject.Instantiate(prefab);
            var staff = obj.GetComponent<PurpleStaff>();

            staff.Init(3.2f, 65);

            return staff;
        }

        public override Sword CreateSword()
        {
            var prefab = Resources.Load<GameObject>("Patterns/AbstarctFactory/Weapon/PurpleSword");
            var obj = GameObject.Instantiate(prefab);
            var sword = obj.GetComponent<PurpleSword>();

            sword.Init(9.1f);

            return sword;
        }
    }
}
