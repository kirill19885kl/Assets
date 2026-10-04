using UnityEngine;

namespace Architect.Test1
{
    public class CurrentService : ICurrnetService
    {
        private double coin;

        public double GetCoin() => coin;
        public void SetCoin(double coin) => this.coin = coin;
        public void AddCoin(double coin) => this.coin += coin;
        public void RemoveCoin(double coin) => this.coin -= coin;
    }
}
