using UnityEngine;

namespace Patterns.AbstractFactory.Weapon
{
    public class BlueBow : Bow
    {
        [SerializeField] protected int _customSettings;

        public void CustomMethod()
        {
            Debug.Log("Custom Mehtod Blue Bow");
        }

    }
}
