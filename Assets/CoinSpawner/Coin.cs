using System;
using UnityEngine;

namespace Assets.CoinSpawner
{
    public class Coin : MonoBehaviour
    {
        [SerializeField] private int _moneyValue;

        public event Action PickUp;

        public GameObject CoinPrefab => gameObject;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out ICoinPicker coinPicker))
            {
                coinPicker.PickUp(_moneyValue);
                PickUp?.Invoke();
                Destroy(gameObject);
            }
        }
    }
}
