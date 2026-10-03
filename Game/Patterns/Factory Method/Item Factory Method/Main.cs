using UnityEngine;
using static UnityEditor.Progress;

namespace Patterns.FactoryMehtod.Item
{
    public enum TypeItem
    {
        Apple,
        Botel
    }

    public class Main : MonoBehaviour
    {
        private ItemFactory _factory;

        void Start()
        {
            InitItem(TypeItem.Apple);
            Debug.Log(_factory.CreateItem()._name);
            InitItem(TypeItem.Botel);
            Debug.Log(_factory.CreateItem()._name);
        }


        private void InitItem(TypeItem type)
        {
            switch (type)
            { 
                case TypeItem.Apple:
                    _factory = new AppleFactory();
                    break;
                case TypeItem.Botel:
                    _factory = new BotelFactory();
                    break;
            }
        }
    }
}
