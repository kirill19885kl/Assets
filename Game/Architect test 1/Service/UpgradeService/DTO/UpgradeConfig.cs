using System;
using UnityEngine;

namespace Architect.Test1
{
    public class UpgradeConfig
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Sprite Icon { get; private set; }
        public double BaseBuyCoin { get; private set; }
        public double BaseClick { get; private set; }

        public UpgradeConfig(int id, string name, Sprite icon, double baseBuyCoin, double baseClick)
        {
            Id = id;
            Name = name;
            Icon = icon;
            BaseBuyCoin = baseBuyCoin;
            BaseClick = baseClick;
        }
    }
}
