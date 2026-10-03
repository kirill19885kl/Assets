using UnityEngine;

namespace Patterns.Singleton.Class
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log("Singleton class: " + Bank.Instance.Coin);
            Bank.Instance.SetCoin(15);
            Debug.Log("Singleton class: " + Bank.Instance.Coin);
        }
    }
}
