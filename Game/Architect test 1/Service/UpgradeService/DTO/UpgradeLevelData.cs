using UnityEngine;

namespace Architect.Test1
{
    public class UpgradeLevelData
    {
        public int Id { get; private set; }
        public int Level;
        public bool IsBuy;

        public UpgradeLevelData(int id, int level, bool isBuy)
        {
            Id = id;
            Level = level;
            IsBuy = isBuy;
        }
    }
}
