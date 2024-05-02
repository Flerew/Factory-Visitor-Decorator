using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Assets.Factory
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private float _spawnInterval;
        [SerializeField] private OrkFactory _orkFactory;
        [SerializeField] private ElfFactory _elfFactory;
        [SerializeField] private List<EnemyFactory> _enemyFactories;
        [SerializeField] private EnemyFactory _currentEnemyFactory;

        public EnemyFactory CurrentEnemyFactory => _currentEnemyFactory;

        private void Awake()
        {
            StartCoroutine(nameof(SpawnEnemy));
        }

        private void OnValidate()
        {
            _enemyFactories.Clear();
            _enemyFactories.Add(_orkFactory);
            _enemyFactories.Add(_elfFactory);
        }

        public void SetRandomCurrentEnemyFactory()
        {
            EnemyFactory enemyFactory = GetFactoryByRandomRace();

            if (enemyFactory == _currentEnemyFactory)
               SetRandomCurrentEnemyFactory();
            else
                _currentEnemyFactory = enemyFactory;
        }

        private IEnumerator SpawnEnemy()
        {
            while (true)
            {
                SpawnRandomEnemy();
                yield return new WaitForSeconds(_spawnInterval);
            }
        }

        private void SpawnRandomEnemy()
        {
            EnemyType enemyType = (EnemyType)Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length);
            _currentEnemyFactory.SpawnEnemy(enemyType);
        }

        private EnemyFactory GetFactoryByRandomRace()
        {
            RaceType raceType = (RaceType)Random.Range(0, Enum.GetValues(typeof(RaceType)).Length);

            switch (raceType)
            {
                case RaceType.Elf:
                    return _elfFactory;

                case RaceType.Ork:
                    return _orkFactory;

                default:
                    throw new ArgumentException(nameof(raceType));
            }
        }
    }
}