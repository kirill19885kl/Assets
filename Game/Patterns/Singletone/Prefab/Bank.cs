using UnityEngine;

namespace Patterns.Singleton.Monobeh
{
    public class Bank : MonoBehaviour
    {
        public static Bank Instance { get; private set; }

        public int Coin { get; private set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
                return;
            }

            Destroy(this.gameObject);
        }

        public void SetCoin(int coin) => this.Coin = coin;
    }
}
