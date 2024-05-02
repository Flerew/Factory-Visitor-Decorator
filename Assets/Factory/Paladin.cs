using UnityEngine;

namespace Assets.Factory
{
    public class Paladin : Enemy
    {
        private void Awake()
        {
            Attack();
        }

        public virtual void Attack()
        {
            Debug.Log("Наношу удар");
        }
    }
}