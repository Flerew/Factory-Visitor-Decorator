using UnityEngine;
using System;

namespace Assets.Factory
{
    [CreateAssetMenu(fileName = "EnemyOrkFactory", menuName = "Factory/EnemyOrkFactory")]
    public class OrkFactory : EnemyFactory
    {
        [SerializeField] private OrkConfig _config;

        public override Enemy SpawnEnemy(EnemyType type)
        {
            Enemy enemyType = Get(type);
            Enemy instance = Instantiate(enemyType);
            return instance;
        }

        public override Enemy Get(EnemyType type)
        {
            switch (type)
            {
                case EnemyType.Paladin:
                    return _config.OrkPaladinPrefab;

                case EnemyType.Wizard:
                    return _config.OrkWizardPrefab;

                default:
                    throw new ArgumentException(nameof(type));
            }
        }
    }
}