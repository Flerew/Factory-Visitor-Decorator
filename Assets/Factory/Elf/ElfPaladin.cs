using UnityEngine;

namespace Assets.Factory
{
    public class ElfPaladin : Paladin
    {
        public override void Attack()
        {
            base.Attack();
            Debug.Log("Добавляю урон стихией");
        }
    }
}