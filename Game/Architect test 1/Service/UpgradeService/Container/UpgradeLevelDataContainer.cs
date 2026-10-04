using System.Collections.Generic;

namespace Architect.Test1
{
    public class UpgradeLevelDataContainer : IUpgradeLevelDataContainer
    {
        public List<UpgradeLevelData> Upgrades = new List<UpgradeLevelData>();

        public void Add(UpgradeLevelData upgrade) => Upgrades.Add(upgrade);

        public UpgradeLevelData GetElement(int index) => Upgrades[index];

        public List<UpgradeLevelData> GetList() => Upgrades;

        public void LevelUp(int index, int level, bool isBuy)
        {
            Upgrades[index].Level = level;
            Upgrades[index].IsBuy = isBuy;
        }

        public void Remove(UpgradeLevelData upgrade) => Upgrades.Remove(upgrade);
    }
}
