using UnityEngine;

namespace Patterns.FactoryMehtod.Item
{
    public class AppleFactory : ItemFactory
    {
        public override Item CreateItem()
        {
            return new AppleItem(0, "яблоко", null);
        }
    }
}
