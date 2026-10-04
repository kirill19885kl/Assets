using UnityEngine;

namespace Architect.Test1
{
    public class UpgradeColculator : IUpgradeColculator
    {
        private readonly IContainerAggregator _containerAggregator;

        public UpgradeColculator(IContainerAggregator containerAggregator)
        {
            _containerAggregator = containerAggregator;
        }

        public double CalculatorClickPowerAll()
        {
            double Power = 0;

            foreach (var item in _containerAggregator.GetListData())
            {
                if (item.IsBuy)
                    Power += item.BaseClick * item.Level;
            }

            return Power;
        }

        public double GetValueBuyUpgrade(int id)
        {
            var element = _containerAggregator.GetElementData(id);
            return element.BaseBuyUpgrade * element.Level;
        }

        public double GetValueClick(int id)
        {
            var element = _containerAggregator.GetElementData(id);
            return element.BaseClick * element.Level;
        }
    }
}
