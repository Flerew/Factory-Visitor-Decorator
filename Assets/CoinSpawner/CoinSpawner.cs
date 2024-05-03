using System;
using System.Collections;
using UnityEngine;

namespace Assets.CoinSpawner
{
    public class CoinSpawner : MonoBehaviour
    {
        [SerializeField] private Coin _coinPrefab;
        [SerializeField] private float _spawnTime;

        private bool _isOccupied = false;
        private GameObject _currentCoin;

        private void Awake()
        {
            StartCoroutine(nameof(SpawnCoinPerTime));
        }

        private void OnDestroy()
        {
            UnsubscribeOnCoin(TryGetCoinComponent(_currentCoin));
        }

        public void ClearSpawner()
        {
            UnsubscribeOnCoin(TryGetCoinComponent(_currentCoin));
            _currentCoin = null;
            _isOccupied = false;
        }

        private IEnumerator SpawnCoinPerTime()
        {
            while (true)
            {
                if (_isOccupied == false)
                {
                    _currentCoin = Instantiate(_coinPrefab.CoinPrefab, transform);
                    SubscribeOnCoin(TryGetCoinComponent(_currentCoin));
                    _isOccupied = true;
                }
                yield return new WaitForSeconds(_spawnTime);
            }
        }

        private void SubscribeOnCoin(Coin coin)
        {
            coin.PickUp += ClearSpawner;
        }

        private void UnsubscribeOnCoin(Coin coin)
        {
            coin.PickUp -= ClearSpawner;
        }

        private Coin TryGetCoinComponent(GameObject coin)
        {
            if(coin.TryGetComponent(out Coin component))
                return component;
            else
                throw new NullReferenceException(nameof(coin));
        }
    }
}