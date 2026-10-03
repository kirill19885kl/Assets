using UnityEngine;

namespace Patterns.FactoryMehtod.Item
{
    public class BotelFactory : ItemFactory
    {
        public override Item CreateItem()
        {
            return new BotelItem(0, "Бутылка", null, 15);
        }
    }
}
