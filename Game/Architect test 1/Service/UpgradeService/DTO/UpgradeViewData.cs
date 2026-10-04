using UnityEngine;

namespace Architect.Test1
{
    public class UpgradeViewData
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Sprite Icon { get; private set; }
        public int Level { get; private set; }
        public double BuyUpgrade { get; private set; }
        public double Click {  get; private set; }

        public UpgradeViewData(int id, string name, Sprite icon, int level, double buyUpgrade, double click)
        {
            Id = id;
            Name = name;
            Icon = icon;
            Level = level;
            BuyUpgrade = buyUpgrade;
            Click = click;
        }
    }
}
