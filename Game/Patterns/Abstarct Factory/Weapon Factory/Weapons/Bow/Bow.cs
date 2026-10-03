using UnityEngine;


namespace Patterns.AbstractFactory.Weapon
{
    public class Bow : Weapon
    {
        [SerializeField] protected float _RangeDistance;
        [SerializeField] protected float _CoolDown;

        public void Init(float RangeDistance, float CoolDown)
        {
            _RangeDistance = RangeDistance;
            _CoolDown = CoolDown;
        }

        public override void Atack()
        {
            Debug.Log("Atack Bow");
        }
    }
}
