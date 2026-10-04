using UnityEngine;

namespace Architect.Test1
{
    public interface IContainerAggregator
    {
        public UpgradeArggregatorData GetElementData(int index);
        public UpgradeArggregatorData[] GetListData();
        public UpgradeViewData GetViewData(int index);
        public UpgradeViewData[] GetViewListData();
    }
}
