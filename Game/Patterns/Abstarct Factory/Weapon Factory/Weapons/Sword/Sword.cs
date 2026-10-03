using UnityEngine;

namespace Patterns.AbstractFactory.Weapon
{
    public class Sword : Weapon
    {
        [SerializeField] protected float _speedAttack;

        public void Init(float SpeedAttack)
        {
            _speedAttack = SpeedAttack;
        }

        public override void Atack()
        {
            Debug.Log("Atack Sword");
        }
    }
}
