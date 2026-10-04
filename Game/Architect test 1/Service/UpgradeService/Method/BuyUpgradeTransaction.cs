using UnityEngine;

namespace Architect.Test1
{
    public class BuyUpgradeTransaction : IBuyUpgradeTransaction
    {
        private readonly IUpgradeLevelDataContainer _upgradeLevelDataContainer;
        private readonly IUpgradeColculator _colculator;
        
        private readonly ICurrnetService _currnetService;

        public BuyUpgradeTransaction(
            IUpgradeLevelDataContainer upgradeLevelDataContainer, 
            IUpgradeColculator colculator,
            ICurrnetService currnetService)
        {
            _upgradeLevelDataContainer = upgradeLevelDataContainer;
            _colculator = colculator;
            _currnetService = currnetService;
        }

        public void BuyUpgrade(int index)
        {
            var leveldata = _upgradeLevelDataContainer.GetElement(index);
            var price = _colculator.GetValueBuyUpgrade(index);

            if (_currnetService.GetCoin() >= price)
            {
                _currnetService.RemoveCoin(price);
                _upgradeLevelDataContainer.LevelUp(index, leveldata.Level + 1, true);
            }
        }
    }
}
