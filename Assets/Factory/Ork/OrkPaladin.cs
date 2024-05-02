using UnityEngine;

namespace Assets.Factory
{
    public class OrkPaladin : Paladin
    {
        public override void Attack()
        {
            base.Attack();
            Debug.Log("Надеваю броню");
        }
    }
}