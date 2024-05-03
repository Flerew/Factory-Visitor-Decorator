using UnityEngine;

namespace Assets.CoinSpawner
{
    public class Player : MonoBehaviour, ICoinPicker
    {
        private Wallet _wallet = new Wallet();

        public void PickUp(int value)
        {
            _wallet.AddMoney(value);
            Debug.Log(_wallet.Money);
        }
    }
}