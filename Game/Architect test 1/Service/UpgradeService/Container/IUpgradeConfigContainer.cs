using System.Collections.Generic;

namespace Architect.Test1
{
    public interface IUpgradeConfigContainer
    {
        public void Add(UpgradeConfig upgrade);
        public void Remove(UpgradeConfig upgrade);
        public UpgradeConfig GetElement(int index);
        public List<UpgradeConfig> GetList();
    }
}
