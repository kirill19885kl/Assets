using UnityEngine;

namespace Patterns.AbstractFactory.Weapon
{
    public enum TypeFactory
    {
        Green,
        Blue,
        Purple
    }

    public enum TypeWeapon
    {
        Sword,
        Bow,
        Staff
    }

    public class Main : MonoBehaviour
    {
        [SerializeField] private Transform Spawner;

        private WeaponFactory factory;

        public void ActiveFactory(TypeFactory type)
        {
            switch (type)
            {
                case TypeFactory.Green:
                    factory = new GreenFactory();
                    break;
                case TypeFactory.Blue:
                    factory = new BlueFactory();
                    break;
                case TypeFactory.Purple:
                    factory = new PurpleFactory();
                    break;
            }
        }

        public void CreateWeapon(TypeWeapon type)
        {
            switch (type)
            {
                case TypeWeapon.Sword:
                    var sword = factory.CreateSword();
                    sword.transform.SetParent(Spawner);
                    break;
                case TypeWeapon.Bow:
                    var bow = factory.CreateBow();
                    bow.transform.SetParent(Spawner);
                    break;
                case TypeWeapon.Staff:
                    var staff = factory.CreateStaff();
                    staff.transform.SetParent(Spawner);
                    break;
            }
        }
    }
}
