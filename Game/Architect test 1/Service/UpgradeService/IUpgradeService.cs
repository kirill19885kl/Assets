using UnityEngine;

namespace Architect.Test1
{
    public interface IUpgradeService
    {
        public void BuyUpgrade(int id);
        public UpgradeViewData GetItem(int id);
        public UpgradeViewData[] GetList();
    }
}
