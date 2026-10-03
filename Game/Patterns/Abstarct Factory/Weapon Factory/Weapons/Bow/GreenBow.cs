using UnityEngine;

namespace Patterns.AbstractFactory.Weapon
{
    public class GreenBow : Bow
    {
        [SerializeField] protected int _customSettings;

        public void CustomMethod() { }
    }
}
