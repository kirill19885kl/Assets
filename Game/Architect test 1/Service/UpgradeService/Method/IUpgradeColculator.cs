using UnityEngine;

namespace Architect.Test1
{
    public interface IUpgradeColculator
    {
        public double CalculatorClickPowerAll();
        public double GetValueClick(int id);
        public double GetValueBuyUpgrade(int id);
    }
}
