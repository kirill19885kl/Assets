using UnityEngine;

namespace Patterns.AbstractFactory.Weapon
{
    public class Staff : Weapon
    {
        [SerializeField] protected float _rangeDistance;
        [SerializeField] protected int _mp_buy;

        public void Init(float RangeDistance, int MP_Buy)
        {
            _rangeDistance = RangeDistance;
            _mp_buy = MP_Buy;
        }

        public override void Atack()
        {
            Debug.Log("Atatck Staff");
        }
    }
}
