using UnityEngine;

namespace Architect.Test1
{
    public class ContainerAggregator : IContainerAggregator
    {
        private readonly IUpgradeConfigContainer _configContainer;
        private readonly IUpgradeLevelDataContainer _levelDataContainer;
        private readonly IUpgradeColculator _colculator;

        public ContainerAggregator(
            IUpgradeConfigContainer configContainer, 
            IUpgradeLevelDataContainer levelDataContainer,
            IUpgradeColculator upgradeColculator)
        {
            _configContainer = configContainer;
            _levelDataContainer = levelDataContainer;
            _colculator = upgradeColculator;
        }

        public UpgradeArggregatorData GetElementData(int index)
        {
            var config = _configContainer.GetElement(index);
            var leveldata = _levelDataContainer.GetElement(index);

            return new UpgradeArggregatorData(config.Id, leveldata.Level, leveldata.IsBuy, config.BaseClick, config.BaseBuyCoin);
        }

        public UpgradeArggregatorData[] GetListData()
        {
            var configs = _configContainer.GetList();
            var leveldatas = _levelDataContainer.GetList();

            UpgradeArggregatorData[] datas = new UpgradeArggregatorData[configs.Count];

            for (int i = 0; i < configs.Count; i++)
            {
                datas[i] = new UpgradeArggregatorData(configs[i].Id, leveldatas[i].Level, leveldatas[i].IsBuy, configs[i].BaseClick, configs[i].BaseBuyCoin);
            }

            return datas;
        }

        public UpgradeViewData GetViewData(int index)
        {
            var configs = _configContainer.GetList();
            var leveldatas = _levelDataContainer.GetList();

            return new UpgradeViewData(
                    configs[index].Id,
                    configs[index].Name,
                    configs[index].Icon,
                    leveldatas[index].Level,
                    _colculator.GetValueClick(index),
                    _colculator.GetValueBuyUpgrade(index));
        }

        public UpgradeViewData[] GetViewListData()
        {
            var configs = _configContainer.GetList();
            var leveldatas = _levelDataContainer.GetList();

            UpgradeViewData[] datas = new UpgradeViewData[configs.Count];

            for (int i = 0; i < configs.Count; i++)
            {

                datas[i] = new UpgradeViewData(
                    configs[i].Id,
                    configs[i].Name,
                    configs[i].Icon,
                    leveldatas[i].Level,
                    _colculator.GetValueClick(i),
                    _colculator.GetValueBuyUpgrade(i));
            }

            return datas;
        }
    }
}
