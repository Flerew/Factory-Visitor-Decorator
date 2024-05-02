using System.Collections.Generic;
using UnityEngine;

namespace Assets.Factory
{
    public class SpawnerMediator : MonoBehaviour
    {
        [SerializeField] private List<EnemySpawner> _enemySpawners;

        public void SwitchSpawnerType()
        {
            foreach (EnemySpawner enemySpawner in _enemySpawners) 
            {
                enemySpawner.SetRandomCurrentEnemyFactory(); 
            }
        }
    }
}