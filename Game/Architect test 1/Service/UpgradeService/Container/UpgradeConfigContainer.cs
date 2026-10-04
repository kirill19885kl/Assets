using System.Collections.Generic;

namespace Architect.Test1
{
    public class UpgradeConfigContainer : IUpgradeConfigContainer
    {
        public List<UpgradeConfig> upgrades = new List<UpgradeConfig>();

        public void Add(UpgradeConfig upgrade) => upgrades.Add(upgrade);

        public UpgradeConfig GetElement(int index) => upgrades[index];

        public List<UpgradeConfig> GetList() => upgrades;

        public void Remove(UpgradeConfig upgrade) => upgrades.Remove(upgrade);
    }
}
