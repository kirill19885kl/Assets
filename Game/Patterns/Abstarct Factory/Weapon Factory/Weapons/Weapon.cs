using UnityEngine;

namespace Patterns.AbstractFactory.Weapon
{
    public abstract class Weapon : MonoBehaviour
    {
        [SerializeField] protected int _demage;

        public abstract void Atack();
    }
}
