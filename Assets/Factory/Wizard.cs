using UnityEngine;

namespace Assets.Factory
{
    public class Wizard : Enemy
    {
        private void Awake()
        {
            CastSpell();
        }

        public virtual void CastSpell()
        {
            Debug.Log("Произношу заклинание");
        }
    }
}