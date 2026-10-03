using UnityEngine;

namespace Patterns.FactoryMehtod.Item
{
    public class BotelItem : Item
    {
        public int _hp { get; }
        public BotelItem(int id, string name, Sprite icon, int hp) : base(id, name, icon)
        {
            _hp = hp;
        }

        public int Action() => _hp;
    }
}
