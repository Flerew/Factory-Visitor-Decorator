using UnityEngine;

namespace Assets.Factory 
{
    public class ElfWizard : Wizard
    {
        public override void CastSpell()
        {
            base.CastSpell();
            Debug.Log("Создаю огонь");
        }
    }
}
