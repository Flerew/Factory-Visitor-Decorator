using UnityEngine;

namespace Assets.Factory
{
    public abstract class EnemyFactory : ScriptableObject
    {
        public abstract Enemy SpawnEnemy(EnemyType type);

        public virtual Enemy Get(EnemyType type)
        {
            throw new System.ArgumentNullException();
        }
    }
}