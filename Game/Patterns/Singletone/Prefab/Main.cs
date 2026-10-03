using UnityEngine;

namespace Patterns.Singleton.Monobeh
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log(Bank.Instance.Coin);
            Bank.Instance.SetCoin(15);
            Debug.Log(Bank.Instance.Coin);
        }
    }
}
