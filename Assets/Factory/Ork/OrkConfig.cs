using System;
using UnityEngine;

namespace Assets.Factory
{
    [Serializable]
    public class OrkConfig
    {
        [SerializeField] private Enemy _orkPaladinPrefab;
        [SerializeField] private Enemy _orkWizardPrefab;

        public Enemy OrkPaladinPrefab => _orkPaladinPrefab;
        public Enemy OrkWizardPrefab => _orkWizardPrefab;
    }
}
