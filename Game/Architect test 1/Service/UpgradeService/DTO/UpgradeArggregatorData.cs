using UnityEngine;

namespace Architect.Test1
{
    public class UpgradeArggregatorData
    {
        public int Id { get; private set; }
        public int Level { get; private set; }
        public bool IsBuy { get; private set; }
        public double BaseClick { get; private set; }
        public double BaseBuyUpgrade { get; private set; }

        public UpgradeArggregatorData(int id, int level, bool isbuy, double baseClick, double baseBuyUpgrade)
        {
            Id = id;
            Level = level;
            BaseClick = baseClick;
            BaseBuyUpgrade = baseBuyUpgrade;
            IsBuy = isbuy;
        }
    }
}
