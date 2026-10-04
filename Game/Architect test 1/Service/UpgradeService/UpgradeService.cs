using UnityEngine;

namespace Architect.Test1
{
    public class UpgradeService : IUpgradeService, IClickPowerProvider
    {
        private readonly IUpgradeColculator _colculator;
        private readonly IContainerAggregator _containerAggregator;
        private readonly IBuyUpgradeTransaction _buyUpgradeTransaction;

        public UpgradeService(
            IUpgradeColculator upgradeColculator,
            IContainerAggregator containerAggregator,
            IBuyUpgradeTransaction buyUpgradeTransaction)
        {
            _colculator = upgradeColculator;
            _containerAggregator = containerAggregator;
            _buyUpgradeTransaction = buyUpgradeTransaction;
        }

        public double GetClickPower() => _colculator.CalculatorClickPowerAll();

        public UpgradeViewData GetItem(int id) => _containerAggregator.GetViewData(id);

        public UpgradeViewData[] GetList() => _containerAggregator.GetViewListData();

        public void BuyUpgrade(int id) => _buyUpgradeTransaction.BuyUpgrade(id);
    }
}
