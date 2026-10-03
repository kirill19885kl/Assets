using System;
using UnityEngine;

namespace Patterns.FactoryMehtod.Item
{
    public abstract class Item
    {
        public int _id { get; }
        public string _name { get; }
        public Sprite Icon {  get; }

        public Item(int id, string name, Sprite icon)
        {
            _id = id;
            _name = name;
            Icon = icon;
        }
    }
}
