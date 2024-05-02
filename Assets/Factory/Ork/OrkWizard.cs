using UnityEngine;

namespace Assets.Factory
{
    public class OrkWizard : Wizard
    {
        public override void CastSpell()
        {
            base.CastSpell();
            Debug.Log("Накладываю защиту");
        }
    }
}
