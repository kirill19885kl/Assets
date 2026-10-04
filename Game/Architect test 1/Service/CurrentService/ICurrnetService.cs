using UnityEngine;

namespace Architect.Test1
{
    public interface ICurrnetService 
    {
        public double GetCoin();
        public void SetCoin(double coin);
        public void AddCoin(double coin);
        public void RemoveCoin(double coin);
    }
}
