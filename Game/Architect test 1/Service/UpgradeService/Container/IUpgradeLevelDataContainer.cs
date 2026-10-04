using System.Collections.Generic;

namespace Architect.Test1
{
    public interface IUpgradeLevelDataContainer
    {
        public void Add(UpgradeLevelData upgrade);
        public void Remove(UpgradeLevelData upgrade);
        public void LevelUp(int index, int level, bool isBuy);
        public UpgradeLevelData GetElement(int index);
        public List<UpgradeLevelData> GetList();
    }
}
