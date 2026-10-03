using UnityEngine;

namespace Patterns.Singleton.Class
{
    //Singleton pattern

    public class Bank
    {
        public static Bank Instance 
        { 
            get
            {
                if (_instance == null)
                    _instance = new Bank();
                return _instance;
            } 
        }

        private static Bank _instance;

        public int Coin { get; private set; }

        public void SetCoin(int coin)
        {
            this.Coin = coin;
        }
    }
}
