using UnityEngine;
using System;
using Unity.VisualScripting.FullSerializer;
using Assets.Factory.Elf;

namespace Assets.Factory
{
    [CreateAssetMenu(fileName = "EnemyElfFactory", menuName = "Factory/EnemyElfFactory")]
    public class ElfFactory : EnemyFactory
    {
        [SerializeField] private ElfConfig _config;

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
                    return _config.ElfPaladinPrefab;

                case EnemyType.Wizard:
                    return _config.ElfWizardPrefab;

                default:
                    throw new ArgumentException(nameof(type));
            }
        }

    }
}